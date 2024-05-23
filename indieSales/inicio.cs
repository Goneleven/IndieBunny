using PROJETO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indieSales
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GYV Games é uma empresa sonhadora! Temos a vontade de ser a maior empresa revendedora de jogos Indie. Por isso, decidimos criar este site para vender esses maravilhosos jogos em mídia física. Nossa maior vontade é fazer todos felizes com esta nova forma de venda. Esperamos que aproveitem e comprem, é claro. rsrs :)");
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            login Tela = new login();
            Tela.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Tela = new Form1();
            Tela.Show();
            this.Hide();
        }
    }
}
