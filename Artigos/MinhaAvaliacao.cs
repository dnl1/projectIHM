using System;
using System.Windows.Forms;

namespace Artigos
{
    public partial class MinhaAvaliacao : Form
    {
        public Avaliacao Avaliacao1;
        public Artigo Artigo1;

        public MinhaAvaliacao(int avaliacao_id)
        {
            InitializeComponent();

            Avaliacao1 = new Avaliacao(avaliacao_id);

            Artigo1 = new Artigo(Avaliacao1.artigo_id);

            txtDescricao.Text = Artigo1.description;
            txtTitle.Text = Artigo1.title;

            int area_id = Artigo1.area_id;

            Area area1 = new Area(area_id);

            cmbAreas.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbAreas.Items.Add(area1);

            cmbAreas.DisplayMember = "nome";
            cmbAreas.ValueMember = "id";

            cmbAreas.SelectedIndex = 0;

            txtDescriptionAvaliacao.Text = Avaliacao1.description;
            chkInteressante.Checked = Avaliacao1.interessante;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Area areaSelecionada = (Area)cmbAreas.SelectedItem;

            Artigo1.area_id = areaSelecionada.id;
            Artigo1.title = txtTitle.Text;
            Artigo1.description = txtDescricao.Text;
            Artigo1.author_id = Usuario.Logado.usuario;

            Artigo1.alterar(Artigo1);

            MessageBox.Show("Artigo alterado com sucesso, aguarde a avaliação dos autores da área!");

            this.Close();
        }
    }
}