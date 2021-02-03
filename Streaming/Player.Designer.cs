using System.Drawing;

namespace Streaming
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.top = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.seek = new System.Windows.Forms.TrackBar();
            this.replay = new System.Windows.Forms.Button();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seek)).BeginInit();
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
            this.top.Size = new System.Drawing.Size(1125, 33);
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
            this.title.Size = new System.Drawing.Size(138, 24);
            this.title.TabIndex = 3;
            this.title.Text = "Video Player";
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // min
            // 
            this.min.Dock = System.Windows.Forms.DockStyle.Right;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.SystemColors.Control;
            this.min.Location = new System.Drawing.Point(1023, 0);
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
            this.close.Location = new System.Drawing.Point(1074, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(51, 33);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // video
            // 
            this.video.Enabled = true;
            this.video.Location = new System.Drawing.Point(63, 39);
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            this.video.Size = new System.Drawing.Size(960, 540);
            this.video.TabIndex = 2;
            this.video.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.Loaded);
            // 
            // play
            // 
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.ForeColor = System.Drawing.SystemColors.Control;
            this.play.Location = new System.Drawing.Point(64, 605);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 6;
            this.play.Text = "Pause";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.Play_Click);
            // 
            // stop
            // 
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.ForeColor = System.Drawing.SystemColors.Control;
            this.stop.Location = new System.Drawing.Point(145, 605);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 6;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // seek
            // 
            this.seek.LargeChange = 1;
            this.seek.Location = new System.Drawing.Point(51, 574);
            this.seek.Maximum = 50;
            this.seek.Name = "seek";
            this.seek.Size = new System.Drawing.Size(980, 45);
            this.seek.SmallChange = 50;
            this.seek.TabIndex = 3;
            this.seek.TickFrequency = 0;
            this.seek.TickStyle = System.Windows.Forms.TickStyle.None;
            this.seek.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            this.seek.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Seek_MouseUp);
            // 
            // replay
            // 
            this.replay.BackColor = System.Drawing.Color.Black;
            this.replay.BackgroundImage = global::Streaming.Properties.Resources.replay;
            this.replay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.replay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replay.ForeColor = System.Drawing.Color.Transparent;
            this.replay.Location = new System.Drawing.Point(479, 245);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(128, 128);
            this.replay.TabIndex = 7;
            this.replay.UseVisualStyleBackColor = false;
            this.replay.Visible = false;
            this.replay.Click += new System.EventHandler(this.Replay_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1125, 649);
            this.Controls.Add(this.replay);
            this.Controls.Add(this.play);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.seek);
            this.Controls.Add(this.video);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Player";
            this.Text = "Player";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button close;
        private AxWMPLib.AxWindowsMediaPlayer video;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TrackBar seek;
        private System.Windows.Forms.Button replay;
    }
}