using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artigos
{
    public class Avaliacao
    {
        public int id { get; set; }
        public string description { get; set; }
        public string revisor_id { get; set; }
        public int artigo_id { get; set; }
        public bool interessante { get; set; }

        public Avaliacao() { }

        public Avaliacao(int id)
        {
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();

            string strCommand = string.Format("Select * from Avaliacao where id = {0}", id);
            SqlDataAdapter da = new SqlDataAdapter(strCommand, ConnectOpen);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                this.id = int.Parse(item[0].ToString());
                this.description = item[1].ToString();
                this.revisor_id = item[2].ToString();
                this.artigo_id = int.Parse(item[3].ToString());
                this.interessante = (bool)item[4];

            }
        }

        public void criar(Avaliacao avaliacao)
        {
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();
            //incluir o using System.Text
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO Avaliacao(description, revisor_id, artigo_id, interessante) ");
            sql.Append("Values (@description, @revisor_id, @artigo_id, @interessante)");
            SqlCommand command = null;

            command = new SqlCommand(sql.ToString(), ConnectOpen);
            command.Parameters.Add(new SqlParameter("@description", avaliacao.description));
            command.Parameters.Add(new SqlParameter("@revisor_id", avaliacao.revisor_id));
            command.Parameters.Add(new SqlParameter("@artigo_id", avaliacao.artigo_id));
            command.Parameters.Add(new SqlParameter("@interessante", avaliacao.interessante ? 1 : 0));
            command.ExecuteNonQuery();
    }

        internal Avaliacao obterPorArtigo(int artigo_id)
        {
            Avaliacao retorno = new Avaliacao();

            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();

            string strCommand = string.Format("Select * from Avaliacao where artigo_id = {0} AND revisor_id = '{1}'", artigo_id, Usuario.Logado.usuario);
            SqlDataAdapter da = new SqlDataAdapter(strCommand, ConnectOpen);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                retorno.id = int.Parse(item[0].ToString());
                retorno.description = item[1].ToString();
                retorno.revisor_id = item[2].ToString();
                retorno.artigo_id = int.Parse(item[3].ToString());
                retorno.interessante = (bool)item[4];
            }

            return retorno;
        }

        internal DataSet obterAvaliacoesDoAutor()
        {
            List<Artigo> retorno = new List<Artigo>();
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();

            string strCommand = string.Format("SELECT Avaliacao.* FROM Avaliacao INNER JOIN Artigo ON Avaliacao.artigo_id = Artigo.id WHERE Artigo.author_id = '{0}' ", Usuario.Logado.usuario);
            SqlDataAdapter da = new SqlDataAdapter(strCommand, ConnectOpen);
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds;
        }

        public void alterar(Avaliacao avaliacao)
        {
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();
            //incluir o using System.Text
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE Avaliacao ");
            sql.Append("SET description = @description, revisor_id = @revisor_id, artigo_id = @artigo_id, interessante = @interessante ");
            sql.Append("WHERE id = @id ");
            SqlCommand command = null;

            command = new SqlCommand(sql.ToString(), ConnectOpen);
            command.Parameters.Add(new SqlParameter("@id", avaliacao.id));
            command.Parameters.Add(new SqlParameter("@description", avaliacao.description));
            command.Parameters.Add(new SqlParameter("@revisor_id", avaliacao.revisor_id));
            command.Parameters.Add(new SqlParameter("@artigo_id", avaliacao.artigo_id));
            command.Parameters.Add(new SqlParameter("@interessante", avaliacao.interessante ? 1 : 0));
            command.ExecuteNonQuery();
        }
    }
}
