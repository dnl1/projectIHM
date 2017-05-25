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
    public partial class Avaliar : Form
    {
        public Artigo Artigo1;
        public Avaliacao Avaliacao1;
        public Avaliar(int artigo_id)
        {
            InitializeComponent();
            Artigo1 = new Artigo(artigo_id);

            txtAutor.Text = Artigo1.author_id;
            txtDescricao.Text = Artigo1.description;
            txtTitle.Text = Artigo1.title;

            int area_id = Artigo1.area_id;

            Area area1 = new Area(area_id);

            cmbAreas.Items.Add(area1.nome);
            cmbAreas.SelectedIndex = 0;

            Avaliacao1 = new Avaliacao();
            Avaliacao1 = Avaliacao1.obterPorArtigo(artigo_id);

            txtDescriptionAvaliacao.Text = Avaliacao1.description;
            chkInteressante.Checked = Avaliacao1.interessante;
        }

        private void btnPersistir_Click(object sender, EventArgs e)
        {
            Avaliacao1.description = txtDescriptionAvaliacao.Text;
            Avaliacao1.artigo_id = Artigo1.id;
            Avaliacao1.interessante = chkInteressante.Checked;
            Avaliacao1.revisor_id = Usuario.Logado.usuario;

            if(Avaliacao1.id == 0)
            {
                Avaliacao1.criar(Avaliacao1);
                MessageBox.Show("A avaliação foi criada com sucesso!");
            }
            else
            {
                Avaliacao1.alterar(Avaliacao1);
                MessageBox.Show("A avaliação foi atualizada com sucesso!");
            }

            this.Close();
        }
    }
}
