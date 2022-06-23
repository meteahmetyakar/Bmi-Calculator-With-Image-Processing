namespace WindowsFormsApp121
{
    partial class FaceRecScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceRecScreen));
            this.RecognizeFaceButton = new System.Windows.Forms.Button();
            this.WindowBorder = new System.Windows.Forms.Panel();
            this.ProgramLogo = new System.Windows.Forms.PictureBox();
            this.ProgramName = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.PersonNameTxt = new System.Windows.Forms.TextBox();
            this.PersonLogo = new System.Windows.Forms.PictureBox();
            this.RedBox = new System.Windows.Forms.PictureBox();
            this.GreenBox = new System.Windows.Forms.PictureBox();
            this.CaptureImageBox = new Emgu.CV.UI.ImageBox();
            this.WindowBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RecognizeFaceButton
            // 
            this.RecognizeFaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.RecognizeFaceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecognizeFaceButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RecognizeFaceButton.FlatAppearance.BorderSize = 0;
            this.RecognizeFaceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.RecognizeFaceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.RecognizeFaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecognizeFaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.RecognizeFaceButton.ForeColor = System.Drawing.Color.Transparent;
            this.RecognizeFaceButton.Location = new System.Drawing.Point(509, 230);
            this.RecognizeFaceButton.Margin = new System.Windows.Forms.Padding(0);
            this.RecognizeFaceButton.Name = "RecognizeFaceButton";
            this.RecognizeFaceButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RecognizeFaceButton.Size = new System.Drawing.Size(133, 26);
            this.RecognizeFaceButton.TabIndex = 9;
            this.RecognizeFaceButton.Text = "Recognize Face";
            this.RecognizeFaceButton.UseMnemonic = false;
            this.RecognizeFaceButton.UseVisualStyleBackColor = false;
            this.RecognizeFaceButton.Click += new System.EventHandler(this.RecognizeFaceButton_Click);
            // 
            // WindowBorder
            // 
            this.WindowBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.WindowBorder.Controls.Add(this.ProgramLogo);
            this.WindowBorder.Controls.Add(this.ProgramName);
            this.WindowBorder.Controls.Add(this.ExitButton);
            this.WindowBorder.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WindowBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowBorder.ForeColor = System.Drawing.Color.Transparent;
            this.WindowBorder.Location = new System.Drawing.Point(0, 0);
            this.WindowBorder.Name = "WindowBorder";
            this.WindowBorder.Size = new System.Drawing.Size(756, 37);
            this.WindowBorder.TabIndex = 10;
            this.WindowBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowBorder_MouseDown);
            // 
            // ProgramLogo
            // 
            this.ProgramLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProgramLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProgramLogo.Image = ((System.Drawing.Image)(resources.GetObject("ProgramLogo.Image")));
            this.ProgramLogo.Location = new System.Drawing.Point(3, 3);
            this.ProgramLogo.Name = "ProgramLogo";
            this.ProgramLogo.Size = new System.Drawing.Size(38, 30);
            this.ProgramLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProgramLogo.TabIndex = 5;
            this.ProgramLogo.TabStop = false;
            this.ProgramLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgramLogo_MouseDown);
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramName.Location = new System.Drawing.Point(47, 9);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(138, 25);
            this.ProgramName.TabIndex = 4;
            this.ProgramName.Text = "Bmı Calculator";
            this.ProgramName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgramName_MouseDown);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Location = new System.Drawing.Point(723, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(33, 33);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitButton.TabIndex = 3;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.Transparent;
            this.BackButton.Location = new System.Drawing.Point(509, 300);
            this.BackButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackButton.Name = "BackButton";
            this.BackButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackButton.Size = new System.Drawing.Size(133, 26);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseMnemonic = false;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.Panel.Controls.Add(this.PersonNameTxt);
            this.Panel.Controls.Add(this.PersonLogo);
            this.Panel.Location = new System.Drawing.Point(509, 259);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(235, 38);
            this.Panel.TabIndex = 13;
            // 
            // PersonNameTxt
            // 
            this.PersonNameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.PersonNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.PersonNameTxt.Location = new System.Drawing.Point(38, 3);
            this.PersonNameTxt.Multiline = true;
            this.PersonNameTxt.Name = "PersonNameTxt";
            this.PersonNameTxt.Size = new System.Drawing.Size(194, 32);
            this.PersonNameTxt.TabIndex = 4;
            // 
            // PersonLogo
            // 
            this.PersonLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.PersonLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PersonLogo.BackgroundImage")));
            this.PersonLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PersonLogo.Location = new System.Drawing.Point(3, 3);
            this.PersonLogo.Name = "PersonLogo";
            this.PersonLogo.Size = new System.Drawing.Size(33, 32);
            this.PersonLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PersonLogo.TabIndex = 4;
            this.PersonLogo.TabStop = false;
            // 
            // RedBox
            // 
            this.RedBox.BackColor = System.Drawing.Color.Transparent;
            this.RedBox.Image = global::BMICalculator.Properties.Resources.kissclipart_red_dot_clip_art_clipart_computer_icons_desktop_wa_7e7be409d97e1a3f;
            this.RedBox.Location = new System.Drawing.Point(645, 230);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(26, 26);
            this.RedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedBox.TabIndex = 15;
            this.RedBox.TabStop = false;
            // 
            // GreenBox
            // 
            this.GreenBox.BackColor = System.Drawing.Color.Transparent;
            this.GreenBox.Image = global::BMICalculator.Properties.Resources.indir;
            this.GreenBox.Location = new System.Drawing.Point(645, 230);
            this.GreenBox.Name = "GreenBox";
            this.GreenBox.Size = new System.Drawing.Size(26, 26);
            this.GreenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenBox.TabIndex = 14;
            this.GreenBox.TabStop = false;
            // 
            // CaptureImageBox
            // 
            this.CaptureImageBox.Location = new System.Drawing.Point(3, 36);
            this.CaptureImageBox.Name = "CaptureImageBox";
            this.CaptureImageBox.Size = new System.Drawing.Size(480, 480);
            this.CaptureImageBox.TabIndex = 2;
            this.CaptureImageBox.TabStop = false;
            // 
            // FaceRecScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(756, 517);
            this.Controls.Add(this.RedBox);
            this.Controls.Add(this.GreenBox);
            this.Controls.Add(this.CaptureImageBox);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.WindowBorder);
            this.Controls.Add(this.RecognizeFaceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FaceRecScreen";
            this.Text = "YuzTanitma";
            this.Load += new System.EventHandler(this.FaceRecScreen_Load);
            this.WindowBorder.ResumeLayout(false);
            this.WindowBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RecognizeFaceButton;
        private System.Windows.Forms.Panel WindowBorder;
        private System.Windows.Forms.PictureBox ProgramLogo;
        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TextBox PersonNameTxt;
        private System.Windows.Forms.PictureBox PersonLogo;
        private Emgu.CV.UI.ImageBox CaptureImageBox;
        private System.Windows.Forms.PictureBox GreenBox;
        private System.Windows.Forms.PictureBox RedBox;
    }
}