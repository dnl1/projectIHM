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
    public partial class ListaAvaliacao : Form
    {
        public ListaAvaliacao()
        {
            InitializeComponent();

            var artigo1 = new Artigo();
            DataSet ds = artigo1.obterArtigosArea();

            if(ds.Tables.Count > 0)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView sender1 = (DataGridView)sender;

            string id = sender1.CurrentRow.Cells[0].Value.ToString();

            var form = new Avaliar(int.Parse(id));
            form.ShowDialog();
        }
    }
}
