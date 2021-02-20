
namespace Streaming
{
    partial class Upload
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
            this.PathBox = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.DescLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.Y_button = new System.Windows.Forms.Button();
            this.N_button = new System.Windows.Forms.Button();
            this.Confirmation = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.success = new System.Windows.Forms.Label();
            this.AdultCheck = new System.Windows.Forms.CheckBox();
            this.top.SuspendLayout();
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
            this.top.Size = new System.Drawing.Size(666, 33);
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
            this.title.Size = new System.Drawing.Size(170, 24);
            this.title.TabIndex = 3;
            this.title.Text = "Video Uploader";
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // min
            // 
            this.min.Dock = System.Windows.Forms.DockStyle.Right;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.SystemColors.Control;
            this.min.Location = new System.Drawing.Point(564, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(51, 33);
            this.min.TabIndex = 2;
            this.min.Text = "_";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.Control;
            this.close.Location = new System.Drawing.Point(615, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(51, 33);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // PathBox
            // 
            this.PathBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathBox.Location = new System.Drawing.Point(153, 94);
            this.PathBox.Name = "PathBox";
            this.PathBox.ReadOnly = true;
            this.PathBox.Size = new System.Drawing.Size(483, 26);
            this.PathBox.TabIndex = 2;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PathLabel.Location = new System.Drawing.Point(12, 94);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(115, 22);
            this.PathLabel.TabIndex = 3;
            this.PathLabel.Text = "Video path";
            // 
            // Browse
            // 
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.SystemColors.Control;
            this.Browse.Location = new System.Drawing.Point(153, 55);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(137, 33);
            this.Browse.TabIndex = 4;
            this.Browse.Text = "Browse..";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // DescBox
            // 
            this.DescBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescBox.Location = new System.Drawing.Point(153, 184);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(483, 114);
            this.DescBox.TabIndex = 5;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DescLabel.Location = new System.Drawing.Point(16, 184);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(111, 22);
            this.DescLabel.TabIndex = 6;
            this.DescLabel.Text = "Description";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleLabel.Location = new System.Drawing.Point(84, 146);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(43, 22);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "Title";
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.Location = new System.Drawing.Point(153, 146);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(483, 26);
            this.TitleBox.TabIndex = 7;
            // 
            // UploadButton
            // 
            this.UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadButton.ForeColor = System.Drawing.SystemColors.Control;
            this.UploadButton.Location = new System.Drawing.Point(153, 351);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(214, 52);
            this.UploadButton.TabIndex = 9;
            this.UploadButton.Text = "Upload!";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // Y_button
            // 
            this.Y_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y_button.ForeColor = System.Drawing.Color.Green;
            this.Y_button.Location = new System.Drawing.Point(373, 351);
            this.Y_button.Name = "Y_button";
            this.Y_button.Size = new System.Drawing.Size(85, 23);
            this.Y_button.TabIndex = 10;
            this.Y_button.UseVisualStyleBackColor = true;
            this.Y_button.Visible = false;
            this.Y_button.Click += new System.EventHandler(this.Y_button_Click);
            // 
            // N_button
            // 
            this.N_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.N_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_button.ForeColor = System.Drawing.Color.Red;
            this.N_button.Location = new System.Drawing.Point(373, 380);
            this.N_button.Name = "N_button";
            this.N_button.Size = new System.Drawing.Size(85, 23);
            this.N_button.TabIndex = 11;
            this.N_button.UseVisualStyleBackColor = true;
            this.N_button.Visible = false;
            this.N_button.Click += new System.EventHandler(this.N_button_Click);
            // 
            // Confirmation
            // 
            this.Confirmation.AutoSize = true;
            this.Confirmation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmation.ForeColor = System.Drawing.SystemColors.Control;
            this.Confirmation.Location = new System.Drawing.Point(464, 366);
            this.Confirmation.Name = "Confirmation";
            this.Confirmation.Size = new System.Drawing.Size(136, 22);
            this.Confirmation.TabIndex = 12;
            this.Confirmation.Text = "Are you sure?";
            this.Confirmation.Visible = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(149, 419);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(384, 22);
            this.error.TabIndex = 13;
            this.error.Text = "One or more inputs was empty or invalid.";
            this.error.Visible = false;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.ForeColor = System.Drawing.Color.Green;
            this.success.Location = new System.Drawing.Point(194, 419);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(275, 22);
            this.success.TabIndex = 14;
            this.success.Text = "Video uploaded successfully!";
            this.success.Visible = false;
            // 
            // AdultCheck
            // 
            this.AdultCheck.AutoSize = true;
            this.AdultCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdultCheck.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.AdultCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.AdultCheck.Location = new System.Drawing.Point(153, 319);
            this.AdultCheck.Name = "AdultCheck";
            this.AdultCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdultCheck.Size = new System.Drawing.Size(133, 26);
            this.AdultCheck.TabIndex = 15;
            this.AdultCheck.Text = "Adult only?";
            this.AdultCheck.UseVisualStyleBackColor = true;
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.AdultCheck);
            this.Controls.Add(this.success);
            this.Controls.Add(this.error);
            this.Controls.Add(this.Confirmation);
            this.Controls.Add(this.N_button);
            this.Controls.Add(this.Y_button);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Upload";
            this.Text = "upload";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button Y_button;
        private System.Windows.Forms.Button N_button;
        private System.Windows.Forms.Label Confirmation;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.CheckBox AdultCheck;
    }
}