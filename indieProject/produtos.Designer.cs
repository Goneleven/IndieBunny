namespace indieProject
{
    partial class produtos
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
            menuStrip1 = new MenuStrip();
            cadastroLoginToolStripMenuItem = new ToolStripMenuItem();
            quemSomosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroLoginToolStripMenuItem, quemSomosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(799, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroLoginToolStripMenuItem
            // 
            cadastroLoginToolStripMenuItem.Name = "cadastroLoginToolStripMenuItem";
            cadastroLoginToolStripMenuItem.Size = new Size(109, 20);
            cadastroLoginToolStripMenuItem.Text = "Home | Produtos";
            cadastroLoginToolStripMenuItem.Click += cadastroLoginToolStripMenuItem_Click;
            // 
            // quemSomosToolStripMenuItem
            // 
            quemSomosToolStripMenuItem.Name = "quemSomosToolStripMenuItem";
            quemSomosToolStripMenuItem.Size = new Size(38, 20);
            quemSomosToolStripMenuItem.Text = "Sair";
            quemSomosToolStripMenuItem.Click += quemSomosToolStripMenuItem_Click;
            // 
            // produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 381);
            Controls.Add(menuStrip1);
            Name = "produtos";
            Text = "Indie Frog - Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroLoginToolStripMenuItem;
        private ToolStripMenuItem quemSomosToolStripMenuItem;
    }
}