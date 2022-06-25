namespace BMICalculator
{
    partial class CameraScreen
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraScreen));
            this.WindowBorder = new System.Windows.Forms.Panel();
            this.ProgramLogo = new System.Windows.Forms.PictureBox();
            this.ProgramName = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CameraButton = new System.Windows.Forms.Button();
            this.CameraPictureBox = new System.Windows.Forms.PictureBox();
            this.WindowBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.WindowBorder.Size = new System.Drawing.Size(563, 37);
            this.WindowBorder.TabIndex = 19;
            this.WindowBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowBorder_MouseDown);
            // 
            // ProgramLogo
            // 
            this.ProgramLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgramLogo.BackgroundImage")));
            this.ProgramLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProgramLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
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
            this.ExitButton.Location = new System.Drawing.Point(530, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(33, 33);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitButton.TabIndex = 3;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Location = new System.Drawing.Point(248, 940);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(77, 60);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = " ";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Location = new System.Drawing.Point(474, 658);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(77, 60);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = " ";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CameraButton
            // 
            this.CameraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.CameraButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CameraButton.BackgroundImage")));
            this.CameraButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CameraButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CameraButton.Location = new System.Drawing.Point(240, 941);
            this.CameraButton.Name = "CameraButton";
            this.CameraButton.Size = new System.Drawing.Size(92, 59);
            this.CameraButton.TabIndex = 16;
            this.CameraButton.UseVisualStyleBackColor = false;
            this.CameraButton.Click += new System.EventHandler(this.CameraButton_Click);
            // 
            // CameraPictureBox
            // 
            this.CameraPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CameraPictureBox.Location = new System.Drawing.Point(11, 44);
            this.CameraPictureBox.Name = "CameraPictureBox";
            this.CameraPictureBox.Size = new System.Drawing.Size(540, 960);
            this.CameraPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CameraPictureBox.TabIndex = 15;
            this.CameraPictureBox.TabStop = false;
            // 
            // CameraScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(563, 1012);
            this.Controls.Add(this.WindowBorder);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CameraButton);
            this.Controls.Add(this.CameraPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraScreen";
            this.Text = "Bluu - BMI Calculator";
            this.Load += new System.EventHandler(this.CameraScreen_Load);
            this.WindowBorder.ResumeLayout(false);
            this.WindowBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraPictureBox)).EndInit();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CameraButton;
        private System.Windows.Forms.PictureBox CameraPictureBox;
        private System.Windows.Forms.Panel WindowBorder;
        private System.Windows.Forms.PictureBox ProgramLogo;
        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.PictureBox ExitButton;
    }
}