using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artigos
{
    public partial class Login : Form
    {
        private Conexao conn;
        public static SqlConnection ConnectOpen;
        public static int perfilUsuario;

        public Login()
        {
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDatabase();
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string strCommand = "Select usuario, perfil from usuarios where usuario = '" + txtUsuario.Text + "' and " + "Senha = '" + txtSenha.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strCommand,ConnectOpen);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();

                DataRow row = dt.Rows[0];

                perfilUsuario = Convert.ToInt16(row[1]);

                Usuario User = new Usuario();

                User.usuario = row[0].ToString();
                User.perfil= (ePerfil)int.Parse(row[1].ToString());

                Usuario._logadoInstance = User;
                var form = new Dashboard();
                form.ShowDialog();
            }
            else
                MessageBox.Show("Usuário ou senha incorreto(s)!");

        }

        private void Focus(object sender, EventArgs e)
        {
            var btn = (TextBox)sender;
            btn.Text = string.Empty;
            btn.ForeColor = Color.Black;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.GotFocus += Focus;
            txtSenha.GotFocus += Focus;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new Cadastrar();
            frm.ShowDialog(); 

            
        }
    }
}
