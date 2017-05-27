using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Artigos
{
    public class Usuario
    {
        public static Usuario _logadoInstance;

        public static Usuario Logado
        {
            get
            {
                if (_logadoInstance == null)
                {
                    _logadoInstance = new Usuario();
                }
                return _logadoInstance;
            }
        }

        public string usuario { get; set; }
        public string senha { get; set; }
        public ePerfil perfil { get; set; }

        public void criar(Usuario usuario)
        {
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();
            //incluir o using System.Text
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into usuarios(Usuario, senha, perfil) ");
            sql.Append("Values (@usuario, @senha, @perfil)");
            SqlCommand command = null;

            command = new SqlCommand(sql.ToString(), ConnectOpen);
            command.Parameters.Add(new SqlParameter("@usuario", usuario.usuario));
            command.Parameters.Add(new SqlParameter("@senha", usuario.senha));
            command.Parameters.Add(new SqlParameter("@perfil", (int)usuario.perfil));
            command.ExecuteNonQuery();
        }

        public void alterar(Usuario usuario)
        {
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();

            StringBuilder sql = new StringBuilder();
            sql.Append(" update usuarios set ");
            sql.Append(" senha = @senha, ");
            sql.Append(" perfil = @perfil "); //Não esqueçam de dar um espaço no final
            sql.Append(" where usuario = @usuario");

            SqlCommand command = null;

            command = new SqlCommand(sql.ToString(), ConnectOpen);
            command.Parameters.Add(new SqlParameter("@senha", usuario.senha));
            command.Parameters.Add(new SqlParameter("@perfil", (int)usuario.perfil));
            command.Parameters.Add(new SqlParameter("@usuario", usuario.usuario));
            command.ExecuteNonQuery();
        }

        public List<Usuario> obterRevisoresEGerentes()
        {
            List<Usuario> retorno = new List<Usuario>();
            Conexao conn = new Conexao();
            SqlConnection ConnectOpen = conn.ConnectToDatabase();

            string strCommand = "Select * from usuarios where perfil IN (2,3)";
            SqlDataAdapter da = new SqlDataAdapter(strCommand, ConnectOpen);
            DataTable dt = new DataTable();

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Usuario usuario1 = new Usuario();
                    usuario1.usuario = item[0].ToString();
                    usuario1.senha = item[1].ToString();
                    usuario1.perfil = (ePerfil)int.Parse(item[2].ToString());
                    retorno.Add(usuario1);
                }
            }

            return retorno;
        }

        internal static void Logoff()
        {
            _logadoInstance = new Usuario();
        }
    }
}