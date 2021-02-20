using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;

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
        public Main(User usr)
        {
            CurrentUser = usr;
            InitializeComponent();
            vids = Videos.videoList;
            if (usr.access == Level.CHILD)
                vids = vids.Where(x => x.AdultOnly == false).ToList();
            LoadPanelsToGUI();
            foreach(Video vid in Videos.videoList)
            {
                if (!usr.Ratings.ContainsKey(vid.Path))
                    usr.Rate(vid, lState.NONE);
            }
        }

        // Top bar
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minmax_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void Min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PlayVid(object sender, EventArgs e)
        {
            if (selectedVid == null) return;
            selectedVid.Views++;
            Videos.Save();
            Player plr = new Player(selectedVid);
            plr.ShowDialog();
        }

        // Video selection

        internal Video selectedVid = null;
        internal List<Video> vids;
        internal List<Panel> pList;
        internal User CurrentUser = null;

        private void SelVid(object sender, MouseEventArgs e)
        {
            Control sndr = (Control)sender;
            string nam = sender is Panel ? sndr.Name : sndr.Parent.Name;
            int id = int.Parse(nam.Substring(5));
            selectedVid = vids[id];

            selthumb.Image = selectedVid.Thumbnail;
            seltitle.Text = selectedVid.Title.Length < 20 ? selectedVid.Title : selectedVid.Title.Substring(0, 17) + "...";
        }

        // Video load + Search
        private void LoadPanelsToGUI() // Takes a list of videos and puts it on the GUI for the user to select from
        {
            pList = Search.LoadVidsIntoGUI(vids); // Get videos
            int i = 0;
            RowStyle temp1 = vidGUI.RowStyles[0];
            vidGUI.RowStyles.Add(new RowStyle(temp1.SizeType, 150));
            vidGUI.RowStyles.Remove(temp1);
            foreach (Panel p in pList)
            {
                p.Controls[0].MouseClick += new MouseEventHandler(SelVid);
                p.Controls[1].MouseClick += new MouseEventHandler(SelVid);
                p.Controls[2].MouseClick += new MouseEventHandler(SelVid);
                p.Controls[3].MouseClick += new MouseEventHandler(SelVid);
                p.MouseClick += new MouseEventHandler(SelVid);
                vidGUI.Controls.Add(p, 0, i); // Add this panel to the list
                RowStyle temp = vidGUI.RowStyles[0];
                vidGUI.RowStyles.Add(new RowStyle(temp.SizeType, 150));
                i++;
            }
        }

        private void ClearPanels() // Clear panels (for refresh + search)
        {
            foreach (Panel p in pList)
            {
                vidGUI.Controls.Remove(p);
            }
            vidGUI.RowStyles.Clear();
            vidGUI.RowStyles.Add(new RowStyle(SizeType.Absolute, 150));
        }

        private void SearchButton_Click(object sender, EventArgs e) // Interface for the search algorithm
        {
            vids = Search.SearchVids(searchBar.Text, Videos.videoList);
            if (CurrentUser.access == Level.CHILD)
                vids = vids.Where(x => x.AdultOnly == false).ToList();
            ClearPanels();
            LoadPanelsToGUI();
        }

        private void refresh_Click(object sender, EventArgs e) // Refresh video list
        {
            vids = Videos.videoList;
            if (CurrentUser.access == Level.CHILD)
                vids = vids.Where(x => x.AdultOnly == false).ToList();
            ClearPanels();
            LoadPanelsToGUI();
        }

        private void upl_Click(object sender, EventArgs e) // Upload
        {
            Upload upl = new Upload();
            upl.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            lgn.Show();
            Close();
        }
    }
}
