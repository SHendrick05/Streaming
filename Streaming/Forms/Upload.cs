using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Streaming
{
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();
        }

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

        // Top buttons
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        //

        private void UploadButton_Click(object sender, EventArgs e) // On click, shows confirmation Y/N
        {
            Y_button.Visible = true;
            N_button.Visible = true;
            Confirmation.Visible = true;
            error.Visible = false;
        }

        private void N_button_Click(object sender, EventArgs e) // No confirmation
        {
            Y_button.Visible = false;
            N_button.Visible = false;
            Confirmation.Visible = false;
        }

        private void Y_button_Click(object sender, EventArgs e) // The button that uploads the video
        {
            string title = TitleBox.Text;
            string desc = string.Join(@"\n", DescBox.Lines);
            string path = PathBox.Text;
            string filName = Path.GetFileName(path);
            if (string.IsNullOrWhiteSpace(title)
                || string.IsNullOrWhiteSpace(desc)
                || string.IsNullOrWhiteSpace(path)) // Makes sure no fields are empty.
            {
                Y_button.Visible = false;
                N_button.Visible = false;
                Confirmation.Visible = false;
                error.Visible = true;
                return;
            }
            string fullPath = @"videos\";
            if (File.Exists(@"videos\" + filName)) // Naming rules to prevent duplicates
            {
                string fil, xt;
                int i = 1;
                do
                {
                    fil = Path.GetFileNameWithoutExtension(path);
                    xt = Path.GetExtension(path);
                    fil += i.ToString();
                } while (File.Exists(@"videos\" + fil + xt));
                fullPath += fil + xt;
            }
            else fullPath += filName;
            File.Copy(path, fullPath);
            Video newVid = new Video(fullPath, title, desc, Search.currUser.Username, AdultCheck.Checked);
            Videos.videoList.Add(newVid); // Upload the video and add to vid list
            Videos.Save(); // Save to list.json
            success.Visible = true;
            Thread.Sleep(1000);
            Close();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dia = new OpenFileDialog())
            {
                dia.InitialDirectory = @"C:\"; // .mp4.avi.mov.webm.flv
                dia.Filter = "Videos|*.mp4;*.avi;*.mov;*.webm;*.flv|MP4|*.mp4|AVI|*.avi|MOV|*.mov|WEBM|*.webm|FLV|*.flv"; // Suitable video types
                dia.RestoreDirectory = true;
                
                if (dia.ShowDialog() == DialogResult.OK)
                {
                    PathBox.Text = dia.FileName; // Upload path to the textbox
                }
            }
        }
    }
}
