using Timer = System.Windows.Forms.Timer;

namespace Stoperica
{
    public partial class Form1 : Form
    {
        Timer timer;
        int sekunde;
        
        public Form1()
        {
            sekunde = 0;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += TimerTick;

            InitializeComponent();

            buttonPocni.Click += buttonPocni_Click;
            buttonZaustavi.Click += buttonZaustavi_Click;
            buttonRestartuj.Click += buttonRestartuj_Click;
        }

        public void buttonPocni_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
        
        public void buttonZaustavi_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        
        public void buttonRestartuj_Click(object sender, EventArgs e)
        {
            timer.Stop();
            sekunde = 0;
            labelVreme.Text = sekunde.ToString();
        }

        public void TimerTick(object sender, EventArgs e)
        {
            sekunde++;
            labelVreme.Text = sekunde.ToString();
        }
    }
}
