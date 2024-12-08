using Timer = System.Windows.Forms.Timer;

namespace SaTajmerom
{
    public partial class Forma : Form
    {
        Timer tajmer;
        
        public Forma()
        {
            InitializeComponent();

            labelVreme.Text = DateTime.Now.ToString();

            tajmer = new Timer();
            tajmer.Interval = 500;
            tajmer.Tick += PostaviTrenutnoVreme;
        }

        private void PostaviTrenutnoVreme(object? sender, EventArgs e)
        {
            labelVreme.Text = DateTime.Now.ToString();
        }

        private void buttonPokreni_Click(object? sender, EventArgs e)
        {
            tajmer.Start();
        }

        private void buttonZaustavi_Click(object? sender, EventArgs e)
        {
            tajmer.Stop();
        }
    }
}
