using System;
using System.Windows.Forms;

namespace Artigos
{
    public partial class Dashboard : Form
    {
        //1 - Autores
        //2 - Revisores
        //3 - Gerente
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var frmLogin = new Login();

            if (Usuario.Logado.usuario == string.Empty)
            {
                Close();
            }

            bool eGerente = Login.perfilUsuario == (int)ePerfil.Gerente;
            bool eRevisor = Login.perfilUsuario == (int)ePerfil.Revisores;
            bool eAutor = Login.perfilUsuario == (int)ePerfil.Autores;

            if (eGerente)
            {
                btnCadastrarUsuario.Enabled = true;
                btnCadastrarArea.Enabled = true;
                btnVincularRevisor.Enabled = true;
            }
            else
            {
                btnCadastrarUsuario.Enabled = false;
                btnCadastrarArea.Enabled = false;
                btnVincularRevisor.Enabled = false;
            }

            if (eRevisor || eGerente)
            {
                btnRevisarArtigo.Enabled = true;
            }
            else
            {
                btnRevisarArtigo.Enabled = false;
            }

            if (eAutor)
            {
                btnCadastrarArtigo.Enabled = true;
                btnMinhasAvaliacoes.Enabled = true;
            }
            else
            {
                btnCadastrarArtigo.Enabled = false;
                btnMinhasAvaliacoes.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cad = new Cadastrar();
            cad.ShowDialog();
        }

        private void btnCadastrarArtigo_Click(object sender, EventArgs e)
        {
            var form = new CadastrarArtigo();
            form.ShowDialog();
        }

        private void btnCadastrarArea_Click(object sender, EventArgs e)
        {
            var form = new CadastrarArea();
            form.ShowDialog();
        }

        private void btnVincularRevisor_Click(object sender, EventArgs e)
        {
            var form = new VincularRevisor();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new ListaAvaliacao();
            form.ShowDialog();
        }

        private void btnMinhasAvaliacoes_Click(object sender, EventArgs e)
        {
            var form = new MinhasAvaliacoes();
            form.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuario.Logoff();
            this.Hide();
            var form = new Login();
            form.ShowDialog();
            this.Close();
        }
    }
}