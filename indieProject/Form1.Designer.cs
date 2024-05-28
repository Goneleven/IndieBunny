namespace indieProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            menuStrip1 = new MenuStrip();
            cadastroLoginToolStripMenuItem = new ToolStripMenuItem();
            quemSomosToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Rockwell", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(204, 49);
            label1.TabIndex = 0;
            label1.Text = "Cadastro";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(12, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 2;
            label2.Text = "Número de Celular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 177);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(12, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 23);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 250);
            label4.Name = "label4";
            label4.Size = new Size(138, 23);
            label4.TabIndex = 6;
            label4.Text = "Confirmar senha";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(12, 276);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(64, 329);
            button1.Name = "button1";
            button1.Size = new Size(138, 41);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar-se";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(852, 329);
            button2.Name = "button2";
            button2.Size = new Size(138, 41);
            button2.TabIndex = 15;
            button2.Text = "Entrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(800, 177);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 12;
            label6.Text = "Senha";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(800, 203);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(252, 23);
            textBox5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(800, 105);
            label7.Name = "label7";
            label7.Size = new Size(153, 23);
            label7.TabIndex = 10;
            label7.Text = "Número de Celular";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(800, 131);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(252, 23);
            textBox6.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Rockwell", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(864, 32);
            label8.Name = "label8";
            label8.Size = new Size(133, 49);
            label8.TabIndex = 8;
            label8.Text = "Login";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroLoginToolStripMenuItem, quemSomosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1064, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroLoginToolStripMenuItem
            // 
            cadastroLoginToolStripMenuItem.Name = "cadastroLoginToolStripMenuItem";
            cadastroLoginToolStripMenuItem.Size = new Size(105, 20);
            cadastroLoginToolStripMenuItem.Text = "Cadastro | Login";
            cadastroLoginToolStripMenuItem.Click += cadastroLoginToolStripMenuItem_Click;
            // 
            // quemSomosToolStripMenuItem
            // 
            quemSomosToolStripMenuItem.Name = "quemSomosToolStripMenuItem";
            quemSomosToolStripMenuItem.Size = new Size(91, 20);
            quemSomosToolStripMenuItem.Text = "Quem Somos";
            quemSomosToolStripMenuItem.Click += quemSomosToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1064, 511);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 114, 167);
            ClientSize = new Size(1064, 511);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Indie Frog - Entrar";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroLoginToolStripMenuItem;
        private ToolStripMenuItem quemSomosToolStripMenuItem;
        public PictureBox pictureBox1;
    }
}