using System.Diagnostics;

namespace Forma
{
    public partial class Forma : Form
    {
        private bool vremeTece = false;
        Thread nitVreme = null;

        public Forma()
        {
            InitializeComponent();

            labelVreme.Text = DateTime.Now.ToString();
        }

        private void buttonPokreni_Click(object sender, EventArgs e)
        {
            if (nitVreme is null || nitVreme.ThreadState == System.Threading.ThreadState.Stopped)
            {
                nitVreme = new Thread(AzurirajVreme);
                vremeTece = true;
                nitVreme.Start();
            }
            else
            {
                MessageBox.Show("Vreme vec tece!");
            }
        }

        private void buttonZaustavi_Click(object sender, EventArgs e)
        {
            vremeTece = false;
        }

        private void AzurirajVreme()
        {
            try
            {
                while (vremeTece)
                {
                    Invoke(() =>
                    {
                        labelVreme.Text = DateTime.Now.ToString();
                    });
                    Thread.Sleep(500);
                }
            }
            catch (ThreadInterruptedException ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
            }
        }

        private void Forma_FormClosing(object sender, FormClosingEventArgs e)
        {
            vremeTece = false;
            nitVreme?.Join();
            Environment.Exit(0);
        }
    }
}
