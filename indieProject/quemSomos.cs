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
    public partial class quemSomos : Form
    {
        public quemSomos()
        {
            InitializeComponent();
        }

        private void cadastroLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Tela = new Form1();
            Tela.Show();
            this.Hide();

        }

        private void quemSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quemSomos Tela = new quemSomos();
            Tela.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void quemSomos_Load(object sender, EventArgs e)
        {

        }
    }
}
