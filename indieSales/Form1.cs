using indieSales;

namespace PROJETO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login Tela = new login();
            Tela.Show();
            this.Hide();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicio Tela = new inicio();
            Tela.Show();
            this.Hide();
        }
    }
}
