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
            //MENU para ir em Login/Cadastro:
            Form1 Tela = new Form1();
            Tela.Show();
            this.Hide();
        }

        private void quemSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MENU para ir em Quem Somos:
            quemSomos Tela = new quemSomos();
            Tela.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Botão para ir em Login/Cadastro (SE Senha e Celular estiverem corretos):
            produtos Tela = new produtos();
            Tela.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}