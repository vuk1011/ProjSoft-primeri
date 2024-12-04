namespace Forme
{
    partial class FormaZadatak3
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
            listBoxProfesori = new ListBox();
            label1 = new Label();
            label2 = new Label();
            buttonVidiAngazovanja = new Button();
            panel1 = new Panel();
            label3 = new Label();
            dataGridViewPP = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPP).BeginInit();
            SuspendLayout();
            // 
            // listBoxProfesori
            // 
            listBoxProfesori.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxProfesori.FormattingEnabled = true;
            listBoxProfesori.ItemHeight = 20;
            listBoxProfesori.Location = new Point(72, 158);
            listBoxProfesori.Name = "listBoxProfesori";
            listBoxProfesori.SelectionMode = SelectionMode.MultiSimple;
            listBoxProfesori.Size = new Size(173, 144);
            listBoxProfesori.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 43);
            label1.Name = "label1";
            label1.Size = new Size(403, 25);
            label1.TabIndex = 1;
            label1.Text = "Uvid u angazovanje profesora na predmetima";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 116);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 2;
            label2.Text = "Izaberite profesora/e";
            // 
            // buttonVidiAngazovanja
            // 
            buttonVidiAngazovanja.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVidiAngazovanja.Location = new Point(72, 338);
            buttonVidiAngazovanja.Name = "buttonVidiAngazovanja";
            buttonVidiAngazovanja.Size = new Size(173, 36);
            buttonVidiAngazovanja.TabIndex = 3;
            buttonVidiAngazovanja.Text = "Vidi angazovanja";
            buttonVidiAngazovanja.UseVisualStyleBackColor = true;
            buttonVidiAngazovanja.Click += VidiAngazovanja;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewPP);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(387, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 258);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 5);
            label3.Name = "label3";
            label3.Size = new Size(154, 21);
            label3.TabIndex = 0;
            label3.Text = "Pregled angazovanja";
            // 
            // dataGridViewPP
            // 
            dataGridViewPP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPP.Location = new Point(10, 49);
            dataGridViewPP.Name = "dataGridViewPP";
            dataGridViewPP.Size = new Size(488, 198);
            dataGridViewPP.TabIndex = 1;
            // 
            // FormaZadatak3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 575);
            Controls.Add(panel1);
            Controls.Add(buttonVidiAngazovanja);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxProfesori);
            MaximumSize = new Size(981, 614);
            MinimumSize = new Size(981, 614);
            Name = "FormaZadatak3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zadatak 3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxProfesori;
        private Label label1;
        private Label label2;
        private Button buttonVidiAngazovanja;
        private Panel panel1;
        private DataGridView dataGridViewPP;
        private Label label3;
    }
}