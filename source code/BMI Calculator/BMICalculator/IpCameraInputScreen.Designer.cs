namespace WindowsFormsApp121
{
    partial class IpCameraEnterScreen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IpCameraEnterScreen));
            this.OpenCameraButton = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.IpTxt = new System.Windows.Forms.TextBox();
            this.IpIcon = new System.Windows.Forms.PictureBox();
            this.WindowBorder = new System.Windows.Forms.Panel();
            this.ProgramLogo = new System.Windows.Forms.PictureBox();
            this.ProgramName = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.RecognizeFaceButton = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpIcon)).BeginInit();
            this.WindowBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenCameraButton
            // 
            this.OpenCameraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.OpenCameraButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenCameraButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.OpenCameraButton.FlatAppearance.BorderSize = 0;
            this.OpenCameraButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.OpenCameraButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.OpenCameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCameraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.OpenCameraButton.ForeColor = System.Drawing.Color.Transparent;
            this.OpenCameraButton.Location = new System.Drawing.Point(3, 88);
            this.OpenCameraButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenCameraButton.Name = "OpenCameraButton";
            this.OpenCameraButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OpenCameraButton.Size = new System.Drawing.Size(94, 26);
            this.OpenCameraButton.TabIndex = 0;
            this.OpenCameraButton.Text = "Open Camera";
            this.OpenCameraButton.UseMnemonic = false;
            this.OpenCameraButton.UseVisualStyleBackColor = false;
            this.OpenCameraButton.Click += new System.EventHandler(this.OpenCameraButton_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.Panel.Controls.Add(this.IpTxt);
            this.Panel.Controls.Add(this.IpIcon);
            this.Panel.Location = new System.Drawing.Point(3, 43);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(235, 38);
            this.Panel.TabIndex = 0;
            // 
            // IpTxt
            // 
            this.IpTxt.BackColor = System.Drawing.SystemColors.Control;
            this.IpTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.IpTxt.Location = new System.Drawing.Point(38, 3);
            this.IpTxt.Multiline = true;
            this.IpTxt.Name = "IpTxt";
            this.IpTxt.Size = new System.Drawing.Size(194, 32);
            this.IpTxt.TabIndex = 4;
            // 
            // IpIcon
            // 
            this.IpIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.IpIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IpIcon.BackgroundImage")));
            this.IpIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IpIcon.Location = new System.Drawing.Point(3, 3);
            this.IpIcon.Name = "IpIcon";
            this.IpIcon.Size = new System.Drawing.Size(33, 32);
            this.IpIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IpIcon.TabIndex = 4;
            this.IpIcon.TabStop = false;
            // 
            // WindowBorder
            // 
            this.WindowBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.WindowBorder.Controls.Add(this.ProgramLogo);
            this.WindowBorder.Controls.Add(this.ProgramName);
            this.WindowBorder.Controls.Add(this.ExitButton);
            this.WindowBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowBorder.ForeColor = System.Drawing.Color.Transparent;
            this.WindowBorder.Location = new System.Drawing.Point(0, 0);
            this.WindowBorder.Name = "WindowBorder";
            this.WindowBorder.Size = new System.Drawing.Size(241, 37);
            this.WindowBorder.TabIndex = 7;
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
            this.ExitButton.Location = new System.Drawing.Point(208, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(33, 33);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitButton.TabIndex = 3;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            this.RecognizeFaceButton.Location = new System.Drawing.Point(129, 88);
            this.RecognizeFaceButton.Margin = new System.Windows.Forms.Padding(0);
            this.RecognizeFaceButton.Name = "RecognizeFaceButton";
            this.RecognizeFaceButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RecognizeFaceButton.Size = new System.Drawing.Size(109, 26);
            this.RecognizeFaceButton.TabIndex = 8;
            this.RecognizeFaceButton.Text = "Recognize Face";
            this.RecognizeFaceButton.UseMnemonic = false;
            this.RecognizeFaceButton.UseVisualStyleBackColor = false;
            this.RecognizeFaceButton.Click += new System.EventHandler(this.RecognizeFaceButton_Click);
            // 
            // IpCameraEnterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(241, 119);
            this.Controls.Add(this.RecognizeFaceButton);
            this.Controls.Add(this.WindowBorder);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.OpenCameraButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IpCameraEnterScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Bluu - BMI Calculator";
            this.Load += new System.EventHandler(this.IpCameraEnterScreen_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpIcon)).EndInit();
            this.WindowBorder.ResumeLayout(false);
            this.WindowBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenCameraButton;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.PictureBox IpIcon;
        private System.Windows.Forms.TextBox IpTxt;
        private System.Windows.Forms.Panel WindowBorder;
        private System.Windows.Forms.PictureBox ProgramLogo;
        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.Button RecognizeFaceButton;
    }
}

