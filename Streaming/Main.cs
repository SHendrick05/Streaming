using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Streaming
{
    public partial class Main : Form
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
        public Main()
        {
            InitializeComponent();
            VideoLoad.Init();
            List<Panel> pList = Search.loadVidsIntoGUI(VideoLoad.videoList);


            int i = 0;
            RowStyle temp1 = vidGUI.RowStyles[0];
            vidGUI.RowStyles.Add(new RowStyle(temp1.SizeType, 150));
            vidGUI.RowStyles.Remove(temp1);
            foreach (Panel p in pList)
            {
                vidGUI.Controls.Add(p, 0, i);
                RowStyle temp = vidGUI.RowStyles[0];
                vidGUI.RowStyles.Add(new RowStyle(temp.SizeType, 150));
                i++;
            }


        }

        // Top bar
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

        private void button1_Click(object sender, EventArgs e)
        {
            Player plr = new Player();
            plr.ShowDialog();
        }

        // 
        private void Main_Load(object sender, EventArgs e)
        {
            string fol = @"videos";
            foreach(string file in Directory.EnumerateFiles(fol))
            {

            }
        }

        // Image selection
    }
}
