namespace indieProject
{
    public partial class Form1 : Form
    {
        // quntidade de usuários que o programa guarda o cadastro
        private string[] telefones = new string[100];
        private string[] senhas = new string[100];
        private int contadorUser = 0;// contador de usuários

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
            string telefone = textBox6.Text;
            string senha = textBox5.Text;

            if (Autenticar(telefone, senha))
            {
                //Botão para ir em Login/Cadastro (SE Senha e Celular estiverem corretos):
                MessageBox.Show("Login bem sucedido!");
                produtos Tela = new produtos();
                Tela.Show();
                this.Hide();
                limparCaixa();
            }
            else
            {
                MessageBox.Show("número de telefone ou senha incorretos");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ////botão cadastrar

            //string telefone = textBox1.Text;
            //string senha = textBox2.Text;
            //string confirmar = textBox3.Text;

            ////"Registro" é o procedimento que foi criado, aqui ele é puxado.
            //if (Registro(telefone, senha, confirmar))
            //{
            //    MessageBox.Show("Cadastro bem-sucedido!");
            //    limparCaixa();
            //}
            //else
            //{
            //    MessageBox.Show("Erro no cadastro. Telefone já existe, campos inválidos ou senhas não coincidem.");
            //}


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Autenticar(string telefone, string senha)
        {
            for (int i = 0; i < contadorUser; i++)
            {
                if (telefones[i] == telefone && senhas[i] == senha)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Registro(string telefone, string senha, string confirmar)
        {
            if (string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmar))
            {
                return false;
            }

            if (senha != confirmar)
            {
                return false;
            }

            for (int i = 0; i < contadorUser; i++)
            {
                if (telefones[i] == telefone)
                {
                    return false;
                }

            }
            telefones[contadorUser] = telefone;
            senhas[contadorUser] = senha;
            contadorUser++;
            return true;

        }
        private void limparCaixa()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //botão cadastrar

            string telefone = textBox1.Text;
            string senha = textBox2.Text;
            string confirmar = textBox3.Text;

            //"Registro" é o procedimento que foi criado, aqui ele é puxado.
            if (Registro(telefone, senha, confirmar))
            {
                MessageBox.Show("Cadastro bem-sucedido!");
                limparCaixa();
            }
            else
            {
                MessageBox.Show("Erro no cadastro. Telefone já existe, campos inválidos ou senhas não coincidem.");
            }

        }
    }
}