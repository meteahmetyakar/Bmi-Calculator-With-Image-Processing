namespace BMICalculator
{
    partial class ResultScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultScreen));
            this.DateLabel = new System.Windows.Forms.Label();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.ProgramName = new System.Windows.Forms.Label();
            this.WindowBorder = new System.Windows.Forms.Panel();
            this.ProgramLogo = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.BMIResultPanel = new System.Windows.Forms.Panel();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.BMILogo = new System.Windows.Forms.PictureBox();
            this.BMILabel = new System.Windows.Forms.Label();
            this.AdviceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.WindowBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.BMIResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMILogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.DateLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.DateLabel.Location = new System.Drawing.Point(507, 53);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(40, 18);
            this.DateLabel.TabIndex = 34;
            this.DateLabel.Text = "Date";
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ResultsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.ResultsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.ColumnHeadersVisible = false;
            this.ResultsDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.ResultsDataGridView.Location = new System.Drawing.Point(279, 74);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ResultsDataGridView.RowHeadersVisible = false;
            this.ResultsDataGridView.Size = new System.Drawing.Size(462, 216);
            this.ResultsDataGridView.TabIndex = 28;
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProgramName.Location = new System.Drawing.Point(47, 9);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(138, 25);
            this.ProgramName.TabIndex = 4;
            this.ProgramName.Text = "Bmı Calculator";
            this.ProgramName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgramName_MouseDown);
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
            this.WindowBorder.Size = new System.Drawing.Size(744, 37);
            this.WindowBorder.TabIndex = 30;
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
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Location = new System.Drawing.Point(711, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(33, 33);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitButton.TabIndex = 3;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BMIResultPanel
            // 
            this.BMIResultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.BMIResultPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BMIResultPanel.Controls.Add(this.BMITextBox);
            this.BMIResultPanel.Controls.Add(this.BMILogo);
            this.BMIResultPanel.Location = new System.Drawing.Point(279, 298);
            this.BMIResultPanel.Name = "BMIResultPanel";
            this.BMIResultPanel.Size = new System.Drawing.Size(113, 45);
            this.BMIResultPanel.TabIndex = 31;
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.BMITextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BMITextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.BMITextBox.Location = new System.Drawing.Point(40, 3);
            this.BMITextBox.Multiline = true;
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(67, 34);
            this.BMITextBox.TabIndex = 4;
            // 
            // BMILogo
            // 
            this.BMILogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BMILogo.BackgroundImage")));
            this.BMILogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMILogo.Location = new System.Drawing.Point(-2, -2);
            this.BMILogo.Name = "BMILogo";
            this.BMILogo.Size = new System.Drawing.Size(43, 42);
            this.BMILogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BMILogo.TabIndex = 4;
            this.BMILogo.TabStop = false;
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.BMILabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.BMILabel.Location = new System.Drawing.Point(276, 53);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(32, 18);
            this.BMILabel.TabIndex = 33;
            this.BMILabel.Text = "BMI";
            // 
            // AdviceRichTextBox
            // 
            this.AdviceRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.AdviceRichTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdviceRichTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.AdviceRichTextBox.Location = new System.Drawing.Point(279, 349);
            this.AdviceRichTextBox.Name = "AdviceRichTextBox";
            this.AdviceRichTextBox.Size = new System.Drawing.Size(462, 174);
            this.AdviceRichTextBox.TabIndex = 32;
            this.AdviceRichTextBox.Text = "";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(153)))), ((int)(((byte)(179)))));
            this.PhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PhotoPictureBox.Location = new System.Drawing.Point(3, 43);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(270, 480);
            this.PhotoPictureBox.TabIndex = 29;
            this.PhotoPictureBox.TabStop = false;
            // 
            // ResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(744, 532);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ResultsDataGridView);
            this.Controls.Add(this.WindowBorder);
            this.Controls.Add(this.BMIResultPanel);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.AdviceRichTextBox);
            this.Controls.Add(this.PhotoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultScreen";
            this.Text = "Bluu - BMI Calculator";
            this.Load += new System.EventHandler(this.ResultScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.WindowBorder.ResumeLayout(false);
            this.WindowBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.BMIResultPanel.ResumeLayout(false);
            this.BMIResultPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMILogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.Panel WindowBorder;
        private System.Windows.Forms.PictureBox ProgramLogo;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.Panel BMIResultPanel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.PictureBox BMILogo;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.RichTextBox AdviceRichTextBox;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
    }
}