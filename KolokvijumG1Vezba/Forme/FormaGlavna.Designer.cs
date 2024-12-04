namespace Forme
{
    partial class FormaGlavna
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
            zadatak1ToolStripMenuItem = new ToolStripMenuItem();
            zadatak2ToolStripMenuItem = new ToolStripMenuItem();
            zadatak3ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { zadatak1ToolStripMenuItem, zadatak2ToolStripMenuItem, zadatak3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // zadatak1ToolStripMenuItem
            // 
            zadatak1ToolStripMenuItem.Name = "zadatak1ToolStripMenuItem";
            zadatak1ToolStripMenuItem.Size = new Size(106, 29);
            zadatak1ToolStripMenuItem.Text = "Zadatak 1";
            // 
            // zadatak2ToolStripMenuItem
            // 
            zadatak2ToolStripMenuItem.Name = "zadatak2ToolStripMenuItem";
            zadatak2ToolStripMenuItem.Size = new Size(109, 29);
            zadatak2ToolStripMenuItem.Text = "Zadatak 2";
            // 
            // zadatak3ToolStripMenuItem
            // 
            zadatak3ToolStripMenuItem.Name = "zadatak3ToolStripMenuItem";
            zadatak3ToolStripMenuItem.Size = new Size(109, 29);
            zadatak3ToolStripMenuItem.Text = "Zadatak 3";
            // 
            // FormaGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormaGlavna";
            Text = "Glavna Forma";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem zadatak1ToolStripMenuItem;
        private ToolStripMenuItem zadatak2ToolStripMenuItem;
        private ToolStripMenuItem zadatak3ToolStripMenuItem;
    }
}
