using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artigos
{
    public class Artigo
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int area_id { get; set; }
        public string author_id { get; set; }

        public Artigo() { }

        public Artigo(int id)
        {
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();

            string strCommand = string.Format("Select * from Artigo where id = {0}", id);
            SqlDataAdapter da = new SqlDataAdapter(strCommand, ConnectOpen);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                this.id = int.Parse(item[0].ToString());
                this.description = item[1].ToString();
                this.area_id = int.Parse(item[2].ToString());
                this.title = item[3].ToString();
                this.author_id = item[4].ToString();

            }
        }

        public void criar(Artigo artigo)
        {
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();
            //incluir o using System.Text
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO Artigo(description, area_id, title, author_id) ");
            sql.Append("Values (@description, @area_id, @title, @author_id)");
            SqlCommand command = null;

            command = new SqlCommand(sql.ToString(), ConnectOpen);
            command.Parameters.Add(new SqlParameter("@description", artigo.description));
            command.Parameters.Add(new SqlParameter("@area_id", artigo.area_id));
            command.Parameters.Add(new SqlParameter("@title", artigo.title));
            command.Parameters.Add(new SqlParameter("@author_id", artigo.author_id));
            command.ExecuteNonQuery();
        }

        internal DataSet obterArtigosDoRevisor()
        {
            List<Artigo> retorno = new List<Artigo>();
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();

            string strCommand = string.Format("Select * from Artigo where author_id = '{0}'", Usuario.Logado.usuario);
            SqlDataAdapter da = new SqlDataAdapter(strCommand, ConnectOpen);
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds;
        }

        internal DataSet obterArtigosArea()
        {
            RevisorArea RevisorArea1 = new RevisorArea();
            List<RevisorArea> RevisorAreas = RevisorArea1.obterTodosPorUsuario();

            List<Artigo> retorno = new List<Artigo>();
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();

            var areas = string.Join("," ,RevisorAreas.Select(rA => rA.area_id).ToArray());

            if (areas.Length == 0) return new DataSet();

            string strCommand = string.Format("Select id AS ID, description AS Descrição, title AS Título, author_id AS Autor from Artigo where area_id IN ({0})", areas);
            SqlDataAdapter da = new SqlDataAdapter(strCommand, ConnectOpen);
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds;
            //DataTable dt = new DataTable();

            //da.Fill(dt);

            //foreach (DataRow item in dt.Rows)
            //{
            //    Artigo artigo1 = new Artigo();

            //    artigo1.id = int.Parse(item[0].ToString());
            //    artigo1.description = item[1].ToString();
            //    artigo1.area_id = int.Parse(item[2].ToString());
            //    artigo1.title = item[3].ToString();
            //    artigo1.author_id = item[4].ToString();

            //    retorno.Add(artigo1);
            //}

            //return retorno;
        }

        public void alterar(Artigo artigo)
        {
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();
            //incluir o using System.Text
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE Artigo ");
            sql.Append("set description = @description, area_id = @area_id, title = @title, author_id = @author_id ");
            SqlCommand command = null;

            command = new SqlCommand(sql.ToString(), ConnectOpen);
            command.Parameters.Add(new SqlParameter("@description", artigo.description));
            command.Parameters.Add(new SqlParameter("@area_id", artigo.area_id));
            command.Parameters.Add(new SqlParameter("@title", artigo.title));
            command.Parameters.Add(new SqlParameter("@author_id", artigo.author_id));
            command.ExecuteNonQuery();
        }
    }
}
