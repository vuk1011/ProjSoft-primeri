namespace Stoperica
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
            labelVreme = new Label();
            buttonPocni = new Button();
            buttonRestartuj = new Button();
            buttonZaustavi = new Button();
            SuspendLayout();
            // 
            // labelVreme
            // 
            labelVreme.AutoSize = true;
            labelVreme.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVreme.Location = new Point(305, 78);
            labelVreme.Name = "labelVreme";
            labelVreme.Size = new Size(25, 30);
            labelVreme.TabIndex = 0;
            labelVreme.Text = "0";
            // 
            // buttonPocni
            // 
            buttonPocni.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPocni.Location = new Point(66, 80);
            buttonPocni.Name = "buttonPocni";
            buttonPocni.Size = new Size(108, 30);
            buttonPocni.TabIndex = 1;
            buttonPocni.Text = "Pocni";
            buttonPocni.UseVisualStyleBackColor = true;
            // 
            // buttonRestartuj
            // 
            buttonRestartuj.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRestartuj.Location = new Point(66, 178);
            buttonRestartuj.Name = "buttonRestartuj";
            buttonRestartuj.Size = new Size(108, 30);
            buttonRestartuj.TabIndex = 2;
            buttonRestartuj.Text = "Restartuj";
            buttonRestartuj.UseVisualStyleBackColor = true;
            // 
            // buttonZaustavi
            // 
            buttonZaustavi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonZaustavi.Location = new Point(66, 129);
            buttonZaustavi.Name = "buttonZaustavi";
            buttonZaustavi.Size = new Size(108, 30);
            buttonZaustavi.TabIndex = 3;
            buttonZaustavi.Text = "Zaustavi";
            buttonZaustavi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 303);
            Controls.Add(buttonZaustavi);
            Controls.Add(buttonRestartuj);
            Controls.Add(buttonPocni);
            Controls.Add(labelVreme);
            MaximumSize = new Size(537, 342);
            MinimumSize = new Size(537, 342);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stoperica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVreme;
        private Button buttonPocni;
        private Button buttonRestartuj;
        private Button buttonZaustavi;
    }
}
