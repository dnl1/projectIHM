using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artigos
{
    public partial class CadastrarArtigo : Form
    {
        public CadastrarArtigo()
        {
            InitializeComponent();
            preencherAreas();
        }

        private void preencherAreas()
        {
            cmbAreas.DropDownStyle = ComboBoxStyle.DropDownList;

            Area Area1 = new Area();
            var areas = Area1.obterTodos();

            cmbAreas.DisplayMember = "nome";
            cmbAreas.ValueMember = "id";

            foreach (var area in areas)
            {
                cmbAreas.Items.Add(area);
            }

            cmbAreas.SelectedIndex = 0;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Artigo Artigo1 = new Artigo();

            Area areaSelecionada = (Area)cmbAreas.SelectedItem;

            Artigo1.area_id = areaSelecionada.id;
            Artigo1.title = txtTitle.Text;
            Artigo1.description = txtDescricao.Text;
            Artigo1.author_id = Usuario.Logado.usuario;

            Artigo1.criar(Artigo1);

            MessageBox.Show("Artigo criado com sucesso, aguarde a avaliação dos autores da área!");

            this.Close();
        }
    }
}
