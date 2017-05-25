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
    public partial class CadastrarArea : Form
    {
        public CadastrarArea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Area Area1 = new Area();

            Area1.nome = txtArea.Text;

            Area1.criar(Area1);

            MessageBox.Show("Area criada com sucesso!");
            this.Close();
        }
    }
}
