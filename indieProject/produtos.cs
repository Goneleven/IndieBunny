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
        String[] nome = new string[7];
        double valorDosJogosDouble = 0;
        string valorDosJogosString;
        string precoComMensagem;

        public produtos()
        {
            InitializeComponent();
        }

        private void cadastroLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MENU para ir em Produtos:
            produtos Tela = new produtos();
            Tela.Show();
            this.Hide();
        }

        private void quemSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MENU para sair e ir para Log/Cad:
            Form1 Tela = new Form1();
            Tela.Show();
            this.Hide();

        }

        //Botões de COMPRA Carrinho:

        //Jogo 1:
        private void button1_Click(object sender, EventArgs e)
        {
            nome[0] = ("Hollow Knight | R$ 39,99");
            listBox1.Items.Add(nome[0]);
            valorDosJogosDouble = (valorDosJogosDouble + 39.99);

        }

        //Jogo 2:
        private void button2_Click(object sender, EventArgs e)
        {
            nome[1] = ("Celeste | R$ 26,99");
            listBox1.Items.Add(nome[1]);
            valorDosJogosDouble = (valorDosJogosDouble + 26.99);

        }

        //Jogo 3:
        private void button3_Click(object sender, EventArgs e)
        {
            nome[2] = ("Omori | R$ 32,99");
            listBox1.Items.Add(nome[2]);
            valorDosJogosDouble = (valorDosJogosDouble + 32.99);

        }

        //Jogo 4:
        private void button4_Click(object sender, EventArgs e)
        {
            nome[3] = ("Cuphead | R$ 24,99");
            listBox1.Items.Add(nome[3]);
            valorDosJogosDouble = (valorDosJogosDouble + 24.99);

        }

        //Jogo 5:
        private void button5_Click(object sender, EventArgs e)
        {
            nome[4] = ("Undertale | R$ 21,99");
            listBox1.Items.Add(nome[4]);
            valorDosJogosDouble = (valorDosJogosDouble + 21.99);

        }

        //Jogo 6:
        private void button6_Click(object sender, EventArgs e)
        {
            nome[5] = ("Cult of Lamb | R$ 19,99");
            listBox1.Items.Add(nome[5]);
            valorDosJogosDouble = (valorDosJogosDouble + 19.99);

        }

        //Jogo 7:
        private void button7_Click(object sender, EventArgs e)
        {
            nome[6] = ("Hades | R$ 69,99");
            listBox1.Items.Add(nome[6]);
            valorDosJogosDouble = (valorDosJogosDouble + 69.99);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Clear(nome);
            valorDosJogosDouble = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            valorDosJogosString = valorDosJogosDouble.ToString();
            precoComMensagem = "O Valor foi de: R$" + valorDosJogosString;
            MessageBox.Show(precoComMensagem, "Compra Efetuada");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
