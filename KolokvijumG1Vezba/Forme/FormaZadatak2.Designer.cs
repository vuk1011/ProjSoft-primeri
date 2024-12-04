namespace Forme
{
    partial class FormaZadatak2
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
            dataGridViewProfesori = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            textBoxIme = new TextBox();
            textBoxPrezime = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxZvanje = new ComboBox();
            buttonSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfesori).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Profesori";
            // 
            // dataGridViewProfesori
            // 
            dataGridViewProfesori.AllowUserToAddRows = false;
            dataGridViewProfesori.AllowUserToDeleteRows = false;
            dataGridViewProfesori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProfesori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProfesori.Location = new Point(12, 79);
            dataGridViewProfesori.MultiSelect = false;
            dataGridViewProfesori.Name = "dataGridViewProfesori";
            dataGridViewProfesori.ReadOnly = true;
            dataGridViewProfesori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProfesori.Size = new Size(941, 220);
            dataGridViewProfesori.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonSacuvaj);
            panel1.Controls.Add(comboBoxZvanje);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxPrezime);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxIme);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 326);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 139);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 20);
            label2.Name = "label2";
            label2.Size = new Size(214, 21);
            label2.TabIndex = 0;
            label2.Text = "Izmeni podatke o profesoru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 69);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 1;
            label3.Text = "Ime";
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(31, 89);
            textBoxIme.MaxLength = 50;
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(92, 23);
            textBoxIme.TabIndex = 2;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(159, 89);
            textBoxPrezime.MaxLength = 50;
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(92, 23);
            textBoxPrezime.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(159, 69);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 3;
            label4.Text = "Prezime";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(282, 69);
            label5.Name = "label5";
            label5.Size = new Size(45, 17);
            label5.TabIndex = 5;
            label5.Text = "Zvanje";
            // 
            // comboBoxZvanje
            // 
            comboBoxZvanje.FormattingEnabled = true;
            comboBoxZvanje.Items.AddRange(new object[] { "docent", "redovni profesor", "vanredni profesor" });
            comboBoxZvanje.Location = new Point(282, 89);
            comboBoxZvanje.Name = "comboBoxZvanje";
            comboBoxZvanje.Size = new Size(131, 23);
            comboBoxZvanje.TabIndex = 6;
            // 
            // buttonSacuvaj
            // 
            buttonSacuvaj.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSacuvaj.Location = new Point(461, 75);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new Size(98, 37);
            buttonSacuvaj.TabIndex = 7;
            buttonSacuvaj.Text = "Sacuvaj";
            buttonSacuvaj.UseVisualStyleBackColor = true;
            // 
            // FormaZadatak2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 575);
            Controls.Add(panel1);
            Controls.Add(dataGridViewProfesori);
            Controls.Add(label1);
            MaximumSize = new Size(981, 614);
            MinimumSize = new Size(981, 614);
            Name = "FormaZadatak2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zadatak 2";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfesori).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewProfesori;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox textBoxIme;
        private TextBox textBoxPrezime;
        private Label label4;
        private ComboBox comboBoxZvanje;
        private Label label5;
        private Button buttonSacuvaj;
    }
}