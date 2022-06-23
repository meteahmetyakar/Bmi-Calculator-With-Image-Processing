using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;

namespace WindowsFormsApp121
{
    public partial class CameraScreen : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,           
        int Msg, int wParam, int lParam);                           
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        MJPEGStream stream;

        public CameraScreen(string ip = "")                         //The ip address in the ip textbox from the /input form is assigned to the ip variable.
        {
            InitializeComponent();
            stream = new MJPEGStream("http://"+ip+":8080/videofeed");   //The necessary block of code for connecting the program to the phone camera and for projecting the image.
            stream.NewFrame += NewFrame;
        }

        //Events

        private void CameraScreen_Load(object sender, EventArgs e) //The stream is started and the delete button is completely deactivated and the camera button is activated.
        {
            DeleteButton.Enabled = false;
            DeleteButton.Visible = false;
            CameraButton.Enabled = true;
            CameraButton.Visible = true;
            stream.Start();
        }

        private void CameraButton_Click(object sender, EventArgs e) //The stream is stopped and the delete button is activated and the camera button is deactivated.
        {
            stream.Stop();
            CameraButton.Enabled = false;
            CameraButton.Visible = false;
            DeleteButton.Enabled = true;
            DeleteButton.Visible = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {                                                         
            /* 
             * Transfer the frame in the picturebox to a bitmap called bmp and import the image saves it as jpg to the program's debug folder.
             * Then he hides this form and opens the Account screen form.
             */

            Bitmap bmp = new Bitmap(CameraPictureBox.Image);
            bmp.Save("image.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            this.Close();
            ResultScreen frm2 = new ResultScreen();
            frm2.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e) //The stream is started and the delete button is completely deactivated and the camera button is activated.
        {
            stream.Start();
            DeleteButton.Enabled = false;
            DeleteButton.Visible = false;
            CameraButton.Enabled = true;
            CameraButton.Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e) //Exit button
        {
            stream.Stop();
            Application.Exit();
        }


        /*
        * From here until to functions, the following section is the label, picturebox, and the program when the panel is pressed
        * it makes window move
        */

        private void ProgramLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ProgramName_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void WindowBorder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



        //Functions
        void NewFrame(object sender, NewFrameEventArgs eventArgs)   //Reflects the frame that the phone camera sees to the picturebox.
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            CameraPictureBox.Image = bmp;
            CameraPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
    }
}