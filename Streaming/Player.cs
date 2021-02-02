using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
        public Player()
        {
            InitializeComponent();
            initTimer();
        }

        // Top buttons
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minmax_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Video streaming buttons
        private void play_Click(object sender, EventArgs e)
        {
            if (play.Text == "Play")
            {
                video.Ctlcontrols.play();
                play.Text = "Pause";
            } else
            {
                video.Ctlcontrols.pause();
                play.Text = "Play";
            }
            
        }

        private void stop_Click(object sender, EventArgs e)
        {
            video.Ctlcontrols.stop();
            play.Text = "Play";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (debounce == true) return;
             debounce = true; 

            video.Ctlcontrols.pause();
            timer1.Stop();
            timer2 = new Timer();
            timer2.Interval = 100;
            timer2.Tick += new EventHandler(trackbar_seek);
            timer2.Start();
        }

        private void trackbar_seek(object sender, EventArgs e)
        {
            video.Ctlcontrols.currentPosition = seek.Value / 10;


            timer2.Stop();
            timer1.Start();
           debounce = false;
        }

        private void seek_MouseUp(object sender, MouseEventArgs e)
        {
            video.Ctlcontrols.play();
        }

        private Timer timer2;
        bool debounce = false;


        private void Loaded(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            seek.Maximum = (int)Math.Ceiling(video.currentMedia.duration)*10;
        }
        
        private Timer timer1;
        private void initTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(Update);
            timer1.Interval = 100;
            timer1.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            seek.Value = (int)(video.Ctlcontrols.currentPosition*10);
        }


    }
}
