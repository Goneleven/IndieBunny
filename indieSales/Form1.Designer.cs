﻿namespace indieSales
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
            menuStrip1 = new MenuStrip();
            aaaToolStripMenuItem = new ToolStripMenuItem();
            bbbToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aaaToolStripMenuItem, bbbToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(897, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aaaToolStripMenuItem
            // 
            aaaToolStripMenuItem.Name = "aaaToolStripMenuItem";
            aaaToolStripMenuItem.Size = new Size(37, 20);
            aaaToolStripMenuItem.Text = "aaa";
            aaaToolStripMenuItem.Click += aaaToolStripMenuItem_Click;
            // 
            // bbbToolStripMenuItem
            // 
            bbbToolStripMenuItem.Name = "bbbToolStripMenuItem";
            bbbToolStripMenuItem.Size = new Size(40, 20);
            bbbToolStripMenuItem.Text = "bbb";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 558);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aaaToolStripMenuItem;
        private ToolStripMenuItem bbbToolStripMenuItem;
    }
}
