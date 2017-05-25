using System.Data;
using System.Windows.Forms;

namespace Artigos
{
    public partial class MinhasAvaliacoes : Form
    {
        public MinhasAvaliacoes()
        {
            InitializeComponent();

            var avaliacao1 = new Avaliacao();
            DataSet ds = avaliacao1.obterAvaliacoesDoAutor();

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView sender1 = (DataGridView)sender;

            if (sender1.CurrentRow != null)
            {
                string id = sender1.CurrentRow.Cells[0].Value.ToString();

                var form = new MinhaAvaliacao(int.Parse(id));
                form.ShowDialog();
            }
        }
    }
}