using Timer = System.Windows.Forms.Timer;

namespace Forma
{
    public partial class Forma : Form
    {
        Timer tajmer1, tajmer2;
        bool uslov1 = true, uslov2 = true;

        public Forma()
        {
            InitializeComponent();

            tajmer1 = new Timer();
            tajmer2 = new Timer();
            tajmer1.Interval = 500;
            tajmer2.Interval = 1000;
            tajmer1.Tick += OsveziPanel1;
            tajmer2.Tick += OsveziPanel2;

            buttonPokreniTajmere.Click += PokreniTajmere;
            buttonZaustaviTajmere.Click += ZaustaviTajmere;
        }

        private void PokreniTajmere(object? sender, EventArgs e)
        {
            tajmer1.Start();
            tajmer2.Start();
        }

        private void ZaustaviTajmere(object? sender, EventArgs e)
        {
            tajmer1.Stop();
            tajmer2.Stop();
        }

        public void OsveziPanel1(object? sender, EventArgs e)
        {
            if (uslov1)
            {
                panel1.BackColor = System.Drawing.Color.Aqua;
            }
            else
            {
                panel1.BackColor = System.Drawing.Color.White;
            }
            uslov1 = !uslov1;
        }

        public void OsveziPanel2(object? sender, EventArgs e)
        {
            if (uslov2)
            {
                panel2.BackColor = System.Drawing.Color.BlueViolet;
            }
            else
            {
                panel2.BackColor = System.Drawing.Color.White;
            }
            uslov2 = !uslov2;
        }
    }
}
