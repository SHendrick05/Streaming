
namespace Streaming
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.top = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.regTab = new System.Windows.Forms.TabPage();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.RegSuccess = new System.Windows.Forms.Label();
            this.RegError = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PW2L = new System.Windows.Forms.Label();
            this.R_PW2 = new System.Windows.Forms.TextBox();
            this.PW1L = new System.Windows.Forms.Label();
            this.R_PW1 = new System.Windows.Forms.TextBox();
            this.R_ULabel = new System.Windows.Forms.Label();
            this.R_User = new System.Windows.Forms.TextBox();
            this.logTab = new System.Windows.Forms.TabPage();
            this.LogSuccess = new System.Windows.Forms.Label();
            this.LogError = new System.Windows.Forms.Label();
            this.L_PW = new System.Windows.Forms.TextBox();
            this.L_user = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.L_ULabel = new System.Windows.Forms.Label();
            this.L_PWLabel = new System.Windows.Forms.Label();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.top.SuspendLayout();
            this.regTab.SuspendLayout();
            this.logTab.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.Controls.Add(this.title);
            this.top.Controls.Add(this.min);
            this.top.Controls.Add(this.close);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(800, 33);
            this.top.TabIndex = 1;
            this.top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(331, 24);
            this.title.TabIndex = 3;
            this.title.Text = "Video Streaming Service - Login";
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // min
            // 
            this.min.Dock = System.Windows.Forms.DockStyle.Right;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.SystemColors.Control;
            this.min.Location = new System.Drawing.Point(698, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(51, 33);
            this.min.TabIndex = 2;
            this.min.Text = "_";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.Min_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.Control;
            this.close.Location = new System.Drawing.Point(749, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(51, 33);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // regTab
            // 
            this.regTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.regTab.Controls.Add(this.dayBox);
            this.regTab.Controls.Add(this.monthBox);
            this.regTab.Controls.Add(this.yearBox);
            this.regTab.Controls.Add(this.RegSuccess);
            this.regTab.Controls.Add(this.RegError);
            this.regTab.Controls.Add(this.RegisterButton);
            this.regTab.Controls.Add(this.PW2L);
            this.regTab.Controls.Add(this.R_PW2);
            this.regTab.Controls.Add(this.PW1L);
            this.regTab.Controls.Add(this.R_PW1);
            this.regTab.Controls.Add(this.R_ULabel);
            this.regTab.Controls.Add(this.R_User);
            this.regTab.Location = new System.Drawing.Point(4, 34);
            this.regTab.Name = "regTab";
            this.regTab.Padding = new System.Windows.Forms.Padding(3);
            this.regTab.Size = new System.Drawing.Size(792, 375);
            this.regTab.TabIndex = 2;
            this.regTab.Text = "Register";
            // 
            // dayBox
            // 
            this.dayBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayBox.Location = new System.Drawing.Point(278, 151);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(75, 29);
            this.dayBox.TabIndex = 27;
            // 
            // monthBox
            // 
            this.monthBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.monthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.monthBox.Location = new System.Drawing.Point(359, 151);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(90, 29);
            this.monthBox.TabIndex = 26;
            this.monthBox.SelectedIndexChanged += new System.EventHandler(this.MonthChanged);
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.yearBox.Location = new System.Drawing.Point(455, 151);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(87, 29);
            this.yearBox.TabIndex = 25;
            // 
            // RegSuccess
            // 
            this.RegSuccess.AutoSize = true;
            this.RegSuccess.ForeColor = System.Drawing.Color.Green;
            this.RegSuccess.Location = new System.Drawing.Point(311, 271);
            this.RegSuccess.Name = "RegSuccess";
            this.RegSuccess.Size = new System.Drawing.Size(177, 22);
            this.RegSuccess.TabIndex = 24;
            this.RegSuccess.Text = "Account created!";
            this.RegSuccess.Visible = false;
            // 
            // RegError
            // 
            this.RegError.AutoSize = true;
            this.RegError.ForeColor = System.Drawing.Color.Red;
            this.RegError.Location = new System.Drawing.Point(311, 249);
            this.RegError.Name = "RegError";
            this.RegError.Size = new System.Drawing.Size(136, 22);
            this.RegError.TabIndex = 23;
            this.RegError.Text = "Error Message";
            this.RegError.Visible = false;
            // 
            // RegisterButton
            // 
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RegisterButton.Location = new System.Drawing.Point(278, 213);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(137, 33);
            this.RegisterButton.TabIndex = 22;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // PW2L
            // 
            this.PW2L.AutoSize = true;
            this.PW2L.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PW2L.ForeColor = System.Drawing.SystemColors.Control;
            this.PW2L.Location = new System.Drawing.Point(99, 105);
            this.PW2L.Name = "PW2L";
            this.PW2L.Size = new System.Drawing.Size(173, 22);
            this.PW2L.TabIndex = 21;
            this.PW2L.Text = "Confirm password";
            // 
            // R_PW2
            // 
            this.R_PW2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.R_PW2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.R_PW2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_PW2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.R_PW2.Location = new System.Drawing.Point(278, 105);
            this.R_PW2.Name = "R_PW2";
            this.R_PW2.PasswordChar = '*';
            this.R_PW2.Size = new System.Drawing.Size(264, 26);
            this.R_PW2.TabIndex = 20;
            // 
            // PW1L
            // 
            this.PW1L.AutoSize = true;
            this.PW1L.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PW1L.ForeColor = System.Drawing.SystemColors.Control;
            this.PW1L.Location = new System.Drawing.Point(157, 73);
            this.PW1L.Name = "PW1L";
            this.PW1L.Size = new System.Drawing.Size(95, 22);
            this.PW1L.TabIndex = 19;
            this.PW1L.Text = "Password";
            // 
            // R_PW1
            // 
            this.R_PW1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.R_PW1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.R_PW1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_PW1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.R_PW1.Location = new System.Drawing.Point(278, 73);
            this.R_PW1.Name = "R_PW1";
            this.R_PW1.PasswordChar = '*';
            this.R_PW1.Size = new System.Drawing.Size(264, 26);
            this.R_PW1.TabIndex = 18;
            // 
            // R_ULabel
            // 
            this.R_ULabel.AutoSize = true;
            this.R_ULabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_ULabel.ForeColor = System.Drawing.SystemColors.Control;
            this.R_ULabel.Location = new System.Drawing.Point(157, 41);
            this.R_ULabel.Name = "R_ULabel";
            this.R_ULabel.Size = new System.Drawing.Size(101, 22);
            this.R_ULabel.TabIndex = 17;
            this.R_ULabel.Text = "Username";
            // 
            // R_User
            // 
            this.R_User.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.R_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.R_User.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_User.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.R_User.Location = new System.Drawing.Point(278, 41);
            this.R_User.Name = "R_User";
            this.R_User.Size = new System.Drawing.Size(264, 26);
            this.R_User.TabIndex = 16;
            // 
            // logTab
            // 
            this.logTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.logTab.Controls.Add(this.LogSuccess);
            this.logTab.Controls.Add(this.LogError);
            this.logTab.Controls.Add(this.L_PW);
            this.logTab.Controls.Add(this.L_user);
            this.logTab.Controls.Add(this.LoginButton);
            this.logTab.Controls.Add(this.L_ULabel);
            this.logTab.Controls.Add(this.L_PWLabel);
            this.logTab.Location = new System.Drawing.Point(4, 34);
            this.logTab.Name = "logTab";
            this.logTab.Padding = new System.Windows.Forms.Padding(3);
            this.logTab.Size = new System.Drawing.Size(792, 375);
            this.logTab.TabIndex = 1;
            this.logTab.Text = "Login";
            // 
            // LogSuccess
            // 
            this.LogSuccess.AutoSize = true;
            this.LogSuccess.ForeColor = System.Drawing.Color.Green;
            this.LogSuccess.Location = new System.Drawing.Point(291, 221);
            this.LogSuccess.Name = "LogSuccess";
            this.LogSuccess.Size = new System.Drawing.Size(138, 22);
            this.LogSuccess.TabIndex = 21;
            this.LogSuccess.Text = "Login success!";
            this.LogSuccess.Visible = false;
            // 
            // LogError
            // 
            this.LogError.AutoSize = true;
            this.LogError.ForeColor = System.Drawing.Color.Red;
            this.LogError.Location = new System.Drawing.Point(291, 199);
            this.LogError.Name = "LogError";
            this.LogError.Size = new System.Drawing.Size(136, 22);
            this.LogError.TabIndex = 20;
            this.LogError.Text = "Error Message";
            this.LogError.Visible = false;
            // 
            // L_PW
            // 
            this.L_PW.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.L_PW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_PW.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PW.Location = new System.Drawing.Point(253, 63);
            this.L_PW.Name = "L_PW";
            this.L_PW.PasswordChar = '*';
            this.L_PW.Size = new System.Drawing.Size(264, 26);
            this.L_PW.TabIndex = 17;
            // 
            // L_user
            // 
            this.L_user.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.L_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_user.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_user.Location = new System.Drawing.Point(253, 31);
            this.L_user.Name = "L_user";
            this.L_user.Size = new System.Drawing.Size(264, 26);
            this.L_user.TabIndex = 15;
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginButton.Location = new System.Drawing.Point(253, 127);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(137, 33);
            this.LoginButton.TabIndex = 19;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // L_ULabel
            // 
            this.L_ULabel.AutoSize = true;
            this.L_ULabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ULabel.ForeColor = System.Drawing.SystemColors.Control;
            this.L_ULabel.Location = new System.Drawing.Point(132, 31);
            this.L_ULabel.Name = "L_ULabel";
            this.L_ULabel.Size = new System.Drawing.Size(101, 22);
            this.L_ULabel.TabIndex = 16;
            this.L_ULabel.Text = "Username";
            // 
            // L_PWLabel
            // 
            this.L_PWLabel.AutoSize = true;
            this.L_PWLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PWLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.L_PWLabel.Location = new System.Drawing.Point(132, 63);
            this.L_PWLabel.Name = "L_PWLabel";
            this.L_PWLabel.Size = new System.Drawing.Size(95, 22);
            this.L_PWLabel.TabIndex = 18;
            this.L_PWLabel.Text = "Password";
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.logTab);
            this.MainTab.Controls.Add(this.regTab);
            this.MainTab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTab.ItemSize = new System.Drawing.Size(100, 30);
            this.MainTab.Location = new System.Drawing.Point(0, 39);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(800, 413);
            this.MainTab.TabIndex = 16;
            this.MainTab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControl1_DrawItem);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.regTab.ResumeLayout(false);
            this.regTab.PerformLayout();
            this.logTab.ResumeLayout(false);
            this.logTab.PerformLayout();
            this.MainTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TabPage regTab;
        private System.Windows.Forms.TabPage logTab;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label PW2L;
        private System.Windows.Forms.TextBox R_PW2;
        private System.Windows.Forms.Label PW1L;
        private System.Windows.Forms.TextBox R_PW1;
        private System.Windows.Forms.Label R_ULabel;
        private System.Windows.Forms.TextBox R_User;
        private System.Windows.Forms.TextBox L_PW;
        private System.Windows.Forms.TextBox L_user;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label L_ULabel;
        private System.Windows.Forms.Label L_PWLabel;
        private System.Windows.Forms.Label RegSuccess;
        private System.Windows.Forms.Label RegError;
        private System.Windows.Forms.Label LogSuccess;
        private System.Windows.Forms.Label LogError;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.ComboBox yearBox;
    }
}