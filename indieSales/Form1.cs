namespace indieSales
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

        private void aaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produtos Tela = new produtos();
            Tela.Show();
            this.Hide();
        }
    }
}
