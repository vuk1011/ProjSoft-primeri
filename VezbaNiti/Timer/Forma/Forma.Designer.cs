namespace Forma
{
    partial class Forma
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
            labelNaslov = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonPokreniTajmere = new Button();
            buttonZaustaviTajmere = new Button();
            SuspendLayout();
            // 
            // labelNaslov
            // 
            labelNaslov.AutoSize = true;
            labelNaslov.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNaslov.Location = new Point(75, 57);
            labelNaslov.Name = "labelNaslov";
            labelNaslov.Size = new Size(438, 30);
            labelNaslov.TabIndex = 0;
            labelNaslov.Text = "Forma demonstrira rad sa 2 razlicita tajmera";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(92, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 200);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(339, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 200);
            panel2.TabIndex = 2;
            // 
            // buttonPokreniTajmere
            // 
            buttonPokreniTajmere.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPokreniTajmere.Location = new Point(582, 252);
            buttonPokreniTajmere.Name = "buttonPokreniTajmere";
            buttonPokreniTajmere.Size = new Size(185, 38);
            buttonPokreniTajmere.TabIndex = 3;
            buttonPokreniTajmere.Text = "Pokreni tajmere";
            buttonPokreniTajmere.UseVisualStyleBackColor = true;
            // 
            // buttonZaustaviTajmere
            // 
            buttonZaustaviTajmere.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonZaustaviTajmere.Location = new Point(582, 311);
            buttonZaustaviTajmere.Name = "buttonZaustaviTajmere";
            buttonZaustaviTajmere.Size = new Size(185, 38);
            buttonZaustaviTajmere.TabIndex = 4;
            buttonZaustaviTajmere.Text = "Zaustavi tajmere";
            buttonZaustaviTajmere.UseVisualStyleBackColor = true;
            // 
            // Forma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonZaustaviTajmere);
            Controls.Add(buttonPokreniTajmere);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelNaslov);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Forma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNaslov;
        private Panel panel1;
        private Panel panel2;
        private Button buttonPokreniTajmere;
        private Button buttonZaustaviTajmere;
    }
}
