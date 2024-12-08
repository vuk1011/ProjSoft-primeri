namespace SaTajmerom
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
            labelVreme = new Label();
            buttonPokreni = new Button();
            buttonZaustavi = new Button();
            SuspendLayout();
            // 
            // labelVreme
            // 
            labelVreme.AutoSize = true;
            labelVreme.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVreme.Location = new Point(113, 71);
            labelVreme.Name = "labelVreme";
            labelVreme.Size = new Size(87, 30);
            labelVreme.TabIndex = 0;
            labelVreme.Text = "[vreme]";
            // 
            // buttonPokreni
            // 
            buttonPokreni.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonPokreni.Location = new Point(113, 146);
            buttonPokreni.Name = "buttonPokreni";
            buttonPokreni.Size = new Size(151, 33);
            buttonPokreni.TabIndex = 1;
            buttonPokreni.Text = "Pokreni vreme";
            buttonPokreni.UseVisualStyleBackColor = true;
            buttonPokreni.Click += buttonPokreni_Click;
            // 
            // buttonZaustavi
            // 
            buttonZaustavi.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonZaustavi.Location = new Point(113, 214);
            buttonZaustavi.Name = "buttonZaustavi";
            buttonZaustavi.Size = new Size(151, 33);
            buttonZaustavi.TabIndex = 2;
            buttonZaustavi.Text = "Zaustavi vreme";
            buttonZaustavi.UseVisualStyleBackColor = true;
            buttonZaustavi.Click += this.buttonZaustavi_Click;
            // 
            // Forma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 386);
            Controls.Add(buttonZaustavi);
            Controls.Add(buttonPokreni);
            Controls.Add(labelVreme);
            MaximumSize = new Size(655, 425);
            MinimumSize = new Size(655, 425);
            Name = "Forma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVreme;
        private Button buttonPokreni;
        private Button buttonZaustavi;
    }
}
