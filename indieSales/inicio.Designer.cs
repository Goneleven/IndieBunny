namespace indieSales
{
    partial class inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Perpetua Titling MT", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 31);
            label1.Name = "label1";
            label1.Size = new Size(322, 56);
            label1.TabIndex = 0;
            label1.Text = "GYV GAMES";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(352, 87);
            label2.Name = "label2";
            label2.Size = new Size(150, 31);
            label2.TabIndex = 1;
            label2.Text = "Bem-Vindo :)";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Malgun Gothic", 12F);
            button1.Location = new Point(352, 226);
            button1.Name = "button1";
            button1.Size = new Size(159, 55);
            button1.TabIndex = 2;
            button1.Text = "Quem somos?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Malgun Gothic", 12F);
            button3.Location = new Point(351, 295);
            button3.Name = "button3";
            button3.Size = new Size(159, 55);
            button3.TabIndex = 4;
            button3.Text = "Cadastrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Malgun Gothic", 12F);
            button4.Location = new Point(352, 361);
            button4.Name = "button4";
            button4.Size = new Size(159, 55);
            button4.TabIndex = 5;
            button4.Text = "Login";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(860, 465);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "inicio";
            Text = "inicio";
            Load += inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}