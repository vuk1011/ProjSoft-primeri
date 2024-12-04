namespace Forme
{
    public partial class FormaGlavna : Form
    {
        public FormaGlavna()
        {
            InitializeComponent();

            zadatak1ToolStripMenuItem.Click += OtvoriFormuZadatak1;
            zadatak2ToolStripMenuItem.Click += OtvoriFormuZadatak2;
            zadatak3ToolStripMenuItem.Click += OtvoriFormuZadatak3;
        }

        public void OtvoriFormuZadatak1(object sender, EventArgs e)
        {
            FormaZadatak1 fz1 = new FormaZadatak1();
            fz1.ShowDialog();
        }
        public void OtvoriFormuZadatak2(object sender, EventArgs e)
        {
            FormaZadatak2 fz2 = new FormaZadatak2();
            fz2.ShowDialog();
        }
        public void OtvoriFormuZadatak3(object sender, EventArgs e)
        {
            FormaZadatak3 fz3 = new FormaZadatak3();
            fz3.ShowDialog();
        }

        public static void PrikaziGreskuZaLosUnos(string poruka)
        {
            MessageBox.Show(poruka, "Los korisnicki unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
