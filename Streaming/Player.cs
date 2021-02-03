using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Streaming
{
    public partial class Player : Form
    {
        // Draggable top
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Init
        public Player(Video vid)
        {
            InitializeComponent();
            InitTimer();
            video.URL = vid.Path;
        }

        // Top buttons
        private void Close_Click(object sender, EventArgs e)
        {
            video.Ctlcontrols.stop();
            Close();
        }

        private void Minmax_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void Min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Video streaming buttons
        private void Play_Click(object sender, EventArgs e)
        {
            replay.Visible = false;
            if (play.Text == "Play")
            {
                video.Ctlcontrols.play();
                play.Text = "Pause";
            }
            else
            {
                video.Ctlcontrols.pause();
                play.Text = "Play";
            }

        }

        // Timers
        private Timer timer2;
        private Timer timer1;
        bool debounce = false; 
        private void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(Update);
            timer1.Interval = 100;
            timer1.Start();
        }


        private void Stop_Click(object sender, EventArgs e)
        {
            video.Ctlcontrols.stop();
            play.Text = "Play";
        }

        // Seeking
        private void TrackBar1_Scroll(object sender, EventArgs e) // Timers are to minimise lag when seeking throughout video
        {
            if (debounce == true) return;
            debounce = true;

            video.Ctlcontrols.pause();
            timer1.Stop();
            timer2 = new Timer
            {
                Interval = 100
            };
            timer2.Tick += new EventHandler(Trackbar_seek);
            timer2.Start();
        }

        private void Trackbar_seek(object sender, EventArgs e)
        {
            video.Ctlcontrols.currentPosition = seek.Value / 10;
            video.Ctlcontrols.play();
            play.Text = "Pause";
            timer2.Stop();
            timer1.Start();
            debounce = false;
        }

        private void Seek_MouseUp(object sender, MouseEventArgs e)
        {
            video.Ctlcontrols.play();
        }

        private void Loaded(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            seek.Maximum = (int)Math.Ceiling(video.currentMedia.duration) * 10;
        }



        // Progress bar
        private void Update(object sender, EventArgs e)
        {
            int pos = (int)(video.Ctlcontrols.currentPosition * 10);
            bool comp = pos <= seek.Maximum;
            seek.Value = comp ? pos : seek.Maximum;
            if (!comp) // If video ended, wait 0.5s and show replay button
            {
                play.Text = "Play";
                Thread.Sleep(500);
                replay.Visible = true;
            }
        }

        private void Replay_Click(object sender, EventArgs e) // Replay button
        {
            video.Ctlcontrols.currentPosition = 0;
            video.Ctlcontrols.play();
            replay.Visible = false;
        }
    }
}
