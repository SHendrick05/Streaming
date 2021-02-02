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
            this.minmax = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.playvid = new System.Windows.Forms.Button();
            this.vidGUI = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.Controls.Add(this.title);
            this.top.Controls.Add(this.min);
            this.top.Controls.Add(this.minmax);
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
            this.min.Location = new System.Drawing.Point(842, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(51, 33);
            this.min.TabIndex = 2;
            this.min.Text = "_";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // minmax
            // 
            this.minmax.Dock = System.Windows.Forms.DockStyle.Right;
            this.minmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minmax.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minmax.ForeColor = System.Drawing.SystemColors.Control;
            this.minmax.Location = new System.Drawing.Point(893, 0);
            this.minmax.Name = "minmax";
            this.minmax.Size = new System.Drawing.Size(51, 33);
            this.minmax.TabIndex = 1;
            this.minmax.Text = "⬜";
            this.minmax.UseVisualStyleBackColor = true;
            this.minmax.Click += new System.EventHandler(this.minmax_Click);
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
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // playvid
            // 
            this.playvid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playvid.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playvid.ForeColor = System.Drawing.SystemColors.Control;
            this.playvid.Location = new System.Drawing.Point(842, 82);
            this.playvid.Name = "playvid";
            this.playvid.Size = new System.Drawing.Size(141, 38);
            this.playvid.TabIndex = 3;
            this.playvid.Text = "Play video";
            this.playvid.UseVisualStyleBackColor = true;
            this.playvid.Click += new System.EventHandler(this.button1_Click);
            // 
            // vidGUI
            // 
            this.vidGUI.AutoScroll = true;
            this.vidGUI.ColumnCount = 1;
            this.vidGUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vidGUI.Location = new System.Drawing.Point(12, 126);
            this.vidGUI.Name = "vidGUI";
            this.vidGUI.RowCount = 1;
            this.vidGUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 404F));
            this.vidGUI.Size = new System.Drawing.Size(971, 404);
            this.vidGUI.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(21, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 31);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(703, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Video selected:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(706, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(264, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(995, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.vidGUI);
            this.Controls.Add(this.playvid);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button minmax;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button playvid;
        private System.Windows.Forms.TableLayoutPanel vidGUI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

