namespace indieProject
{
    partial class quemSomos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quemSomos));
            menuStrip1 = new MenuStrip();
            cadastroLoginToolStripMenuItem = new ToolStripMenuItem();
            quemSomosToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroLoginToolStripMenuItem, quemSomosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(799, 24);
            menuStrip1.TabIndex = 17;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 28F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(317, 27);
            label1.Name = "label1";
            label1.Size = new Size(156, 35);
            label1.TabIndex = 18;
            label1.Text = "Que somos?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(3, 164);
            label2.Name = "label2";
            label2.Size = new Size(791, 85);
            label2.TabIndex = 20;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // quemSomos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(799, 381);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "quemSomos";
            Text = "Indie Frog - Quem Somos?";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroLoginToolStripMenuItem;
        private ToolStripMenuItem quemSomosToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}