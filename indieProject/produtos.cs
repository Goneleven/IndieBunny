using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indieProject
{
    public partial class produtos : Form
    {
        public produtos()
        {
            InitializeComponent();
        }

        private void cadastroLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produtos Tela = new produtos();
            Tela.Show();
            this.Hide();
        }

        private void quemSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Tela = new Form1();
            Tela.Show();
            this.Hide();

        }
    }
}
