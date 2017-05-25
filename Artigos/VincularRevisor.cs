using System;
using System.Windows.Forms;

namespace Artigos
{
    public partial class VincularRevisor : Form
    {
        public VincularRevisor()
        {
            InitializeComponent();
            preencherAreas();
            preencherRevisores();
        }

        private void preencherRevisores()
        {
            cmbRevisores.DropDownStyle = ComboBoxStyle.DropDownList;

            Usuario Usuario1 = new Usuario();
            var revisores = Usuario1.obterRevisoresEGerentes();

            cmbRevisores.DisplayMember = "usuario";
            cmbRevisores.ValueMember = "usuario";

            foreach (var revisor in revisores)
            {
                cmbRevisores.Items.Add(revisor);
            }

            cmbRevisores.SelectedIndex = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Area areaSelecionada = (Area)cmbAreas.SelectedItem;
            Usuario revisorSelecionado = (Usuario)cmbRevisores.SelectedItem;

            RevisorArea RevisorArea1 = new RevisorArea();
            RevisorArea1.area_id = areaSelecionada.id;
            RevisorArea1.revisor_id = revisorSelecionado.usuario;

            try
            {
                RevisorArea1.criar(RevisorArea1);
                MessageBox.Show("Vinculo criado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}