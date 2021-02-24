using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Streaming
{
    public enum LState
    {
        DISLIKE,
        LIKE,
        NONE
    }

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
            currVid = vid;
            if (Search.currUser.Ratings.ContainsKey(currVid.Path))
            {
                if (Search.currUser.Ratings[currVid.Path] == LState.DISLIKE)
                    ThumbsDown.BackgroundImage = Properties.Resources.down_fl;
                else if (Search.currUser.Ratings[currVid.Path] == LState.LIKE)
                    ThumbsUp.BackgroundImage = Properties.Resources.up_fl;
            } 
            else Search.currUser.Rate(currVid, LState.NONE);
            UpLabel.Text = currVid.Likes.ToString();
            DownLabel.Text = currVid.Dislikes.ToString();
            likeRatio.Value = Convert.ToInt32(currVid.LR_Ratio * 100);
            vidTitle.Text = vid.Title;
            vidUploader.Text = vid.Uploader;
            vidDesc.Text = vid.Desc;
        }

        public Video currVid;

        // Top buttons
        private void Close_Click(object sender, EventArgs e)
        {
            video.Ctlcontrols.stop();
            Users.Save();
            Videos.Save();
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
            TimeSpan len = new TimeSpan(0, 0, (int)video.Ctlcontrols.currentItem.duration);
            TimeSpan pass = new TimeSpan(0, 0, (int)video.Ctlcontrols.currentPosition);
            timestamp.Text = $"{Math.Floor(pass.TotalHours)}:{pass.Minutes}:{pass.Seconds}/{Math.Floor(len.TotalHours)}:{len.Minutes}:{len.Seconds}";
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
            play.Text = "Pause";
        }

        private void ThumbsUp_Click(object sender, EventArgs e)
        {
            if (Search.currUser.Ratings[currVid.Path] == LState.LIKE)
            {
                // Cancel a like
                Search.currUser.Rate(currVid, LState.NONE);
                ThumbsUp.BackgroundImage = Streaming.Properties.Resources.up_ol;
                currVid.Likes--;
            }
            else
            {
                // Like the video
                if (Search.currUser.Ratings[currVid.Path] == LState.DISLIKE)
                    currVid.Dislikes--;
                Search.currUser.Rate(currVid, LState.LIKE);
                ThumbsUp.BackgroundImage = Streaming.Properties.Resources.up_fl;
                ThumbsDown.BackgroundImage = Streaming.Properties.Resources.down_ol;
                currVid.Likes++;
            }
            DownLabel.Text = currVid.Dislikes.ToString();
            UpLabel.Text = currVid.Likes.ToString();
            likeRatio.Value = Convert.ToInt32(currVid.LR_Ratio * 100);
        }

        private void ThumbsDown_Click(object sender, EventArgs e)
        {
            if (Search.currUser.Ratings[currVid.Path] == LState.DISLIKE)
            {
                // Cancel a dislike
                Search.currUser.Rate(currVid, LState.NONE);
                ThumbsDown.BackgroundImage = Streaming.Properties.Resources.down_ol;
                currVid.Dislikes--;
            }
            else
            {
                //Dislike the video
                if (Search.currUser.Ratings[currVid.Path] == LState.LIKE)
                    currVid.Likes--;
                Search.currUser.Rate(currVid, LState.DISLIKE);
                ThumbsDown.BackgroundImage = Streaming.Properties.Resources.down_fl;
                ThumbsUp.BackgroundImage = Streaming.Properties.Resources.up_ol;
                currVid.Dislikes++;

            }
            DownLabel.Text = currVid.Dislikes.ToString();
            UpLabel.Text = currVid.Likes.ToString();
            likeRatio.Value = Convert.ToInt32(currVid.LR_Ratio * 100);
        }
    }
}
