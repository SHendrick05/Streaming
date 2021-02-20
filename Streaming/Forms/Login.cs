using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace Streaming
{
    public partial class Login : Form
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

        public Login()
        {
            _ = Videos.videoList;
            InitializeComponent();
        }


        // Top bar
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(41, 44, 51)), MainTab.ClientRectangle);
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds);
        }

        // Combobox init
        private List<string> ints(int a, int b)
        {
            List<string> res = new List<string>();
            for (int i = a; i <= b; i++)
            {
                res.Add(i.ToString());
            }
            return res;
        }
        private void monthChanged(object sender, EventArgs e)
        {
            if ("JanMarMayJulAugOctDec".Contains(monthBox.Text))
            {
                dayBox.Items.Clear();
                dayBox.Items.AddRange(ints(1, 31).ToArray());
            }
            else if ("AprJunSepNov".Contains(monthBox.Text))
            {
                dayBox.Items.Clear();
                dayBox.Items.AddRange(ints(1, 30).ToArray());
            }
            else
            {
                dayBox.Items.Clear();
                dayBox.Items.AddRange(ints(1, 28).ToArray());
            }
        }

        //
        // Registration
        //
        private DateTime GetDOB()
        {
            int day = dayBox.SelectedIndex + 1;
            int year = yearBox.SelectedIndex + 1900;
            int mon = monthBox.SelectedIndex + 1;
            if (day == 0 || mon == 0 || year == 1899) throw new Exception();
            DateTime DOB = new DateTime(year, mon, day);
            return DOB;
        }
        private int MakeAccount() 
        {
            string PW = R_PW1.Text;
            if (PW != R_PW2.Text) return 1; // Non-matching passwords
            string USR = R_User.Text;
            if (string.IsNullOrWhiteSpace(USR) || string.IsNullOrEmpty(PW)) return 4; // Empty fields

            DateTime DOB;
            try
            {
                DOB = GetDOB();
            } catch (Exception)
            {
                return 3; // Invalid Date of Birth
            }

            if (DOB.Year < 13) return 5; // Underaged

            List<string> uNames = Users.userList.Count == 0 ? new List<string>() : Users.userList.ConvertAll(x => x.Username);
            if (uNames.Contains(USR)) return 2; // Taken username

            return 0; // Success
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {


            List<User> userList = Users.userList;

            RegError.Visible = false;
            int result = MakeAccount();
            switch(result)
            {
                case 0:
                    string salt = AccSecurity.genText(5);
                    string hash = AccSecurity.Hashval(R_PW1.Text + salt);
                    User newUser = new User(R_User.Text, hash, salt, GetDOB());
                    Users.userList.Add(newUser);
                    Users.Save();
                    RegSuccess.Visible = true;
                    Thread.Sleep(1000);
                    LoadAccount(newUser);
                    return;
                case 1:
                    RegError.Visible = true;
                    RegError.Text = "Passwords are not matching.";
                    return;
                case 2:
                    RegError.Visible = true;
                    RegError.Text = "Username already taken.";
                    return;
                case 3:
                    RegError.Visible = true;
                    RegError.Text = "Please enter a valid date.";
                    return;
                case 4:
                    RegError.Visible = true;
                    RegError.Text = "Please do not enter blank values.";
                    return;
                case 5:
                    RegError.Visible = true;
                    RegError.Text = "This platform is for users aged 13 and up.";
                    return;
                default:
                    RegError.Visible = true;
                    RegError.Text = "Unknown error. Please try again later.";
                    return;
            }
        }

        //
        // Login
        //

        private void LoadAccount(User usr)
        {
            Search.currUser = usr;
            Main mn = new Main(usr);
            Hide();
            mn.Show();
        }

        private int LoginAcc(string uName, string pass, List<User> userList)
        {
            if (string.IsNullOrWhiteSpace(uName) || string.IsNullOrEmpty(pass)) return 2;
            User attemptedUser;
            try
            {
                attemptedUser = userList.First(x => x.Username == uName);
            }
            catch (InvalidOperationException)
            {
                return 3; // Nonexistent username
            }
            string attemptedPW = AccSecurity.Hashval(pass + attemptedUser.Salt);
            if (attemptedPW != attemptedUser.Hash)
                return 1;
            else return 0;
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            List<User> userList = Users.userList;
            LogError.Visible = false;
            int result = LoginAcc(L_user.Text, L_PW.Text, userList);

            switch(result)
            {
                case 0:
                    L_user.ReadOnly = true;
                    LogSuccess.Visible = true;
                    Thread.Sleep(1000);
                    LoadAccount(userList.First(x => x.Username == L_user.Text));
                    return;
                case 1:
                    LogError.Visible = true;
                    LogError.Text = "Incorrect password.";
                    return;
                case 2:
                    LogError.Visible = true;
                    LogError.Text = "Please do not enter blank values.";
                    return;
               case 3:
                    LogError.Visible = true;
                    LogError.Text = "Username does not exist.";
                    return;
                default:
                    LogError.Visible = true;
                    LogError.Text = "Unknown error. Please try again later.";
                    return;
            }
        }

    }
}
