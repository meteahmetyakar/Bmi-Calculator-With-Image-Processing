using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace WindowsFormsApp121
{
    public partial class IpCameraEnterScreen : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]                                          
        public static extern int SendMessage(IntPtr hWnd,                           
        int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public static string nameForDb;

        public IpCameraEnterScreen()
        {
            InitializeComponent();
        }

        private void OpenCameraButton_Click(object sender, EventArgs e) //Open Camera button. textbox also sends the ip address that says the camera screen form and switches to the camera screen form.
        {
            if (IpTxt.Text != "")
            {
                this.Hide();
                CameraScreen frm4 = new CameraScreen(IpTxt.Text);
                frm4.Show();
            }
            else
                MessageBox.Show("Please Enter Ip Address Of Ip Camera.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void RecognizeFaceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaceRecScreen frm = new FaceRecScreen();
            frm.Show();
        }

        private void IpCameraEnterScreen_Load(object sender, EventArgs e)
        {
            ExitButton.SizeMode = PictureBoxSizeMode.StretchImage;
            if (System.IO.File.Exists(Application.StartupPath + "\\image.png"))
            {
                System.IO.File.Delete(Application.StartupPath + "\\image.png");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) //Exit button
        {
            Application.Exit();
        }

        /*
         * From here, the following section is the label, picturebox, and the program when the panel is pressed
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

    }
}
