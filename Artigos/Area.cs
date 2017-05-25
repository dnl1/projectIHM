using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Artigos
{
    public class Area
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Area() { }

        public Area(int id)
        {
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();

            string strCommand = string.Format("Select * from Area where id = {0}", id);
            SqlDataAdapter da = new SqlDataAdapter(strCommand, ConnectOpen);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                this.id = int.Parse(item[0].ToString());
                this.nome = item[1].ToString();
            }
        }

        public void criar(Area area)
        {
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();
            //incluir o using System.Text
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into Area(Nome) ");
            sql.Append("Values (@nome)");
            SqlCommand command = null;

            command = new SqlCommand(sql.ToString(), ConnectOpen);
            command.Parameters.Add(new SqlParameter("@nome", area.nome));
            command.ExecuteNonQuery();
        }

        public List<Area> obterTodos()
        {
            List<Area> retorno = new List<Area>();
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();

            string strCommand = "Select * from area";
            SqlDataAdapter da = new SqlDataAdapter(strCommand, ConnectOpen);
            DataTable dt = new DataTable();

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Area area1 = new Area();
                    area1.id = int.Parse(item[0].ToString());
                    area1.nome = item[1].ToString();
                    retorno.Add(area1);
                }
            }

            return retorno;
        }
    }
}