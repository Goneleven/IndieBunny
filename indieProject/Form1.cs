namespace indieProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            produtos Tela = new produtos();
            Tela.Show();
            this.Hide();

        }
    }
}