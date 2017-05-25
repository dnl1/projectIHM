using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Artigos
{
    public class RevisorArea
    {
        public int id { get; set; }
        public int area_id { get; set; }
        public string revisor_id { get; set; }

        public void criar(RevisorArea revisorArea)
        {
            bool existeVinculo = contemVinculo(revisorArea);

            if (!existeVinculo)
            {
                Conexao conn = new Conexao();
                SqlConnection ConnectOpen = conn.ConnectToDatabase();
                //incluir o using System.Text
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into RevisorArea(area_id, revisor_id) ");
                sql.Append("Values (@area_id, @revisor_id)");
                SqlCommand command = null;

                command = new SqlCommand(sql.ToString(), ConnectOpen);
                command.Parameters.Add(new SqlParameter("@area_id", revisorArea.area_id));
                command.Parameters.Add(new SqlParameter("@revisor_id", revisorArea.revisor_id));
                command.ExecuteNonQuery();
            }
            else
            {
                throw new System.Exception("Este revisor já está vinculado a esta area!");
            }
        }

        private bool contemVinculo(RevisorArea revisorArea)
        {
            List<Area> retorno = new List<Area>();
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();

            string strCommand = string.Format("Select * from RevisorArea where area_id = {0} AND revisor_id = '{1}'", revisorArea.area_id, revisorArea.revisor_id);
            SqlDataAdapter da = new SqlDataAdapter(strCommand, ConnectOpen);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows.Count > 0;
        }

        internal List<RevisorArea> obterTodosPorUsuario()
        {
            List<RevisorArea> retorno = new List<RevisorArea>();
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();

            string strCommand = string.Format("Select id, area_id, revisor_id from RevisorArea where revisor_id = '{0}'", Usuario.Logado.usuario);
            SqlDataAdapter da = new SqlDataAdapter(strCommand, ConnectOpen);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                RevisorArea revisorArea1 = new RevisorArea();

                revisorArea1.id = int.Parse(item[0].ToString());
                revisorArea1.area_id = int.Parse(item[1].ToString());
                revisorArea1.revisor_id = item[2].ToString();

                retorno.Add(revisorArea1);
            }

            return retorno;
        }
    }
}