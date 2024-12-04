namespace Forme
{
    partial class FormaZadatak1
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
            comboBoxProizvodi = new ComboBox();
            panel1 = new Panel();
            buttonIzmeniProizvod = new Button();
            comboBoxPoreskaStopa = new ComboBox();
            comboBoxProizvodjaci = new ComboBox();
            numericUpDownCena = new NumericUpDown();
            label6 = new Label();
            textBoxNaziv = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            labelDetaljiNaziv = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            labelNaziv = new Label();
            labelCena = new Label();
            labelProizvodjac = new Label();
            labelPoreskaStopa = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCena).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 45);
            label1.Name = "label1";
            label1.Size = new Size(267, 25);
            label1.TabIndex = 0;
            label1.Text = "Izmena podataka o proizvodu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 118);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 1;
            label2.Text = "Izaberite proizvod:";
            // 
            // comboBoxProizvodi
            // 
            comboBoxProizvodi.FormattingEnabled = true;
            comboBoxProizvodi.Location = new Point(220, 118);
            comboBoxProizvodi.Name = "comboBoxProizvodi";
            comboBoxProizvodi.Size = new Size(175, 23);
            comboBoxProizvodi.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonIzmeniProizvod);
            panel1.Controls.Add(comboBoxPoreskaStopa);
            panel1.Controls.Add(comboBoxProizvodjaci);
            panel1.Controls.Add(numericUpDownCena);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxNaziv);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(52, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 294);
            panel1.TabIndex = 3;
            // 
            // buttonIzmeniProizvod
            // 
            buttonIzmeniProizvod.BackColor = Color.PaleGreen;
            buttonIzmeniProizvod.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzmeniProizvod.Location = new Point(326, 239);
            buttonIzmeniProizvod.Name = "buttonIzmeniProizvod";
            buttonIzmeniProizvod.Size = new Size(137, 32);
            buttonIzmeniProizvod.TabIndex = 10;
            buttonIzmeniProizvod.Text = "Primeni izmene";
            buttonIzmeniProizvod.UseVisualStyleBackColor = false;
            buttonIzmeniProizvod.Click += buttonIzmeniProizvod_Click;
            // 
            // comboBoxPoreskaStopa
            // 
            comboBoxPoreskaStopa.FormattingEnabled = true;
            comboBoxPoreskaStopa.Location = new Point(240, 144);
            comboBoxPoreskaStopa.Name = "comboBoxPoreskaStopa";
            comboBoxPoreskaStopa.Size = new Size(78, 23);
            comboBoxPoreskaStopa.TabIndex = 9;
            // 
            // comboBoxProizvodjaci
            // 
            comboBoxProizvodjaci.FormattingEnabled = true;
            comboBoxProizvodjaci.Location = new Point(239, 63);
            comboBoxProizvodjaci.Name = "comboBoxProizvodjaci";
            comboBoxProizvodjaci.Size = new Size(124, 23);
            comboBoxProizvodjaci.TabIndex = 8;
            // 
            // numericUpDownCena
            // 
            numericUpDownCena.DecimalPlaces = 2;
            numericUpDownCena.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDownCena.Location = new Point(39, 144);
            numericUpDownCena.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numericUpDownCena.Name = "numericUpDownCena";
            numericUpDownCena.Size = new Size(85, 29);
            numericUpDownCena.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 113);
            label6.Name = "label6";
            label6.Size = new Size(37, 18);
            label6.TabIndex = 5;
            label6.Text = "Cena";
            // 
            // textBoxNaziv
            // 
            textBoxNaziv.Location = new Point(39, 63);
            textBoxNaziv.Name = "textBoxNaziv";
            textBoxNaziv.Size = new Size(108, 23);
            textBoxNaziv.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(239, 113);
            label5.Name = "label5";
            label5.Size = new Size(91, 18);
            label5.TabIndex = 2;
            label5.Text = "Poreska stopa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(239, 33);
            label4.Name = "label4";
            label4.Size = new Size(79, 18);
            label4.TabIndex = 1;
            label4.Text = "Proizvodjac";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 33);
            label3.Name = "label3";
            label3.Size = new Size(42, 18);
            label3.TabIndex = 0;
            label3.Text = "Naziv";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelPoreskaStopa);
            panel2.Controls.Add(labelProizvodjac);
            panel2.Controls.Add(labelCena);
            panel2.Controls.Add(labelNaziv);
            panel2.Controls.Add(labelDetaljiNaziv);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(585, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 199);
            panel2.TabIndex = 4;
            // 
            // labelDetaljiNaziv
            // 
            labelDetaljiNaziv.AutoSize = true;
            labelDetaljiNaziv.Location = new Point(135, 71);
            labelDetaljiNaziv.Name = "labelDetaljiNaziv";
            labelDetaljiNaziv.Size = new Size(0, 15);
            labelDetaljiNaziv.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 101);
            label11.Name = "label11";
            label11.Size = new Size(37, 15);
            label11.TabIndex = 4;
            label11.Text = "Cena:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 130);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 3;
            label10.Text = "Proizvodjac:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 158);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 2;
            label9.Text = "Poreska stopa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 71);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 1;
            label8.Text = "Naziv:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 20);
            label7.Name = "label7";
            label7.Size = new Size(196, 17);
            label7.TabIndex = 0;
            label7.Text = "Detalji o izabranom proizvodu";
            // 
            // labelNaziv
            // 
            labelNaziv.AutoSize = true;
            labelNaziv.Location = new Point(122, 71);
            labelNaziv.Name = "labelNaziv";
            labelNaziv.Size = new Size(44, 15);
            labelNaziv.TabIndex = 6;
            labelNaziv.Text = "label12";
            // 
            // labelCena
            // 
            labelCena.AutoSize = true;
            labelCena.Location = new Point(122, 101);
            labelCena.Name = "labelCena";
            labelCena.Size = new Size(44, 15);
            labelCena.TabIndex = 7;
            labelCena.Text = "label12";
            // 
            // labelProizvodjac
            // 
            labelProizvodjac.AutoSize = true;
            labelProizvodjac.Location = new Point(122, 130);
            labelProizvodjac.Name = "labelProizvodjac";
            labelProizvodjac.Size = new Size(44, 15);
            labelProizvodjac.TabIndex = 8;
            labelProizvodjac.Text = "label12";
            // 
            // labelPoreskaStopa
            // 
            labelPoreskaStopa.AutoSize = true;
            labelPoreskaStopa.Location = new Point(122, 158);
            labelPoreskaStopa.Name = "labelPoreskaStopa";
            labelPoreskaStopa.Size = new Size(44, 15);
            labelPoreskaStopa.TabIndex = 9;
            labelPoreskaStopa.Text = "label12";
            // 
            // FormaZadatak1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 575);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(comboBoxProizvodi);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(981, 614);
            MinimumSize = new Size(981, 614);
            Name = "FormaZadatak1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zadatak 1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCena).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxProizvodi;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxNaziv;
        private NumericUpDown numericUpDownCena;
        private Label label6;
        private ComboBox comboBoxProizvodjaci;
        private ComboBox comboBoxPoreskaStopa;
        private Button buttonIzmeniProizvod;
        private Panel panel2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label labelDetaljiNaziv;
        private Label labelNaziv;
        private Label labelPoreskaStopa;
        private Label labelProizvodjac;
        private Label labelCena;
    }
}