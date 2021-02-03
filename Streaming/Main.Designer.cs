namespace Streaming
{
    partial class Main
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
            this.playvid = new System.Windows.Forms.Button();
            this.vidGUI = new System.Windows.Forms.TableLayoutPanel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.selintro = new System.Windows.Forms.Label();
            this.selthumb = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.seltitle = new System.Windows.Forms.Label();
            this.upl = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selthumb)).BeginInit();
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
            this.top.Size = new System.Drawing.Size(995, 33);
            this.top.TabIndex = 0;
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
            this.title.Size = new System.Drawing.Size(258, 24);
            this.title.TabIndex = 3;
            this.title.Text = "Video Streaming Service";
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // min
            // 
            this.min.Dock = System.Windows.Forms.DockStyle.Right;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.SystemColors.Control;
            this.min.Location = new System.Drawing.Point(893, 0);
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
            this.close.Location = new System.Drawing.Point(944, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(51, 33);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // playvid
            // 
            this.playvid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playvid.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playvid.ForeColor = System.Drawing.SystemColors.Control;
            this.playvid.Location = new System.Drawing.Point(842, 82);
            this.playvid.Name = "playvid";
            this.playvid.Size = new System.Drawing.Size(141, 31);
            this.playvid.TabIndex = 3;
            this.playvid.Text = "Play video";
            this.playvid.UseVisualStyleBackColor = true;
            this.playvid.Click += new System.EventHandler(this.PlayVid);
            // 
            // vidGUI
            // 
            this.vidGUI.AutoScroll = true;
            this.vidGUI.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.vidGUI.ColumnCount = 1;
            this.vidGUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vidGUI.ForeColor = System.Drawing.SystemColors.Control;
            this.vidGUI.Location = new System.Drawing.Point(12, 126);
            this.vidGUI.Name = "vidGUI";
            this.vidGUI.RowCount = 1;
            this.vidGUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 404F));
            this.vidGUI.Size = new System.Drawing.Size(971, 404);
            this.vidGUI.TabIndex = 4;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.ForeColor = System.Drawing.SystemColors.Window;
            this.searchBar.Location = new System.Drawing.Point(12, 46);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(237, 31);
            this.searchBar.TabIndex = 5;
            // 
            // selintro
            // 
            this.selintro.AutoSize = true;
            this.selintro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selintro.ForeColor = System.Drawing.SystemColors.Control;
            this.selintro.Location = new System.Drawing.Point(703, 45);
            this.selintro.Name = "selintro";
            this.selintro.Size = new System.Drawing.Size(91, 16);
            this.selintro.TabIndex = 6;
            this.selintro.Text = "Video selected:";
            // 
            // selthumb
            // 
            this.selthumb.Location = new System.Drawing.Point(706, 65);
            this.selthumb.Name = "selthumb";
            this.selthumb.Size = new System.Drawing.Size(100, 50);
            this.selthumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selthumb.TabIndex = 7;
            this.selthumb.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchButton.Location = new System.Drawing.Point(255, 46);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(141, 31);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // seltitle
            // 
            this.seltitle.AutoSize = true;
            this.seltitle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seltitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.seltitle.Location = new System.Drawing.Point(800, 46);
            this.seltitle.Name = "seltitle";
            this.seltitle.Size = new System.Drawing.Size(37, 16);
            this.seltitle.TabIndex = 9;
            this.seltitle.Text = "None";
            // 
            // upl
            // 
            this.upl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upl.ForeColor = System.Drawing.SystemColors.Control;
            this.upl.Location = new System.Drawing.Point(159, 82);
            this.upl.Name = "upl";
            this.upl.Size = new System.Drawing.Size(141, 31);
            this.upl.TabIndex = 10;
            this.upl.Text = "Upload Video";
            this.upl.UseVisualStyleBackColor = true;
            this.upl.Click += new System.EventHandler(this.upl_Click);
            // 
            // refresh
            // 
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.refresh.Location = new System.Drawing.Point(12, 82);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(141, 31);
            this.refresh.TabIndex = 11;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(757, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Made by Sean Hendrick 10P";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(995, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.upl);
            this.Controls.Add(this.seltitle);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.selthumb);
            this.Controls.Add(this.selintro);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.vidGUI);
            this.Controls.Add(this.playvid);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selthumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button playvid;
        private System.Windows.Forms.TableLayoutPanel vidGUI;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label selintro;
        private System.Windows.Forms.PictureBox selthumb;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label seltitle;
        private System.Windows.Forms.Button upl;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label1;
    }
}

