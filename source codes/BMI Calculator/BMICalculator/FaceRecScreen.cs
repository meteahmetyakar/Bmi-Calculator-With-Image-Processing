using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using FaceDetection;
namespace WindowsFormsApp121
{
    public partial class FaceRecScreen : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]                                          
        public static extern int SendMessage(IntPtr hWnd,                           
        int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();

        public FaceRecScreen()
        {
            CameraCapture();
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public static int id;
        public static string[] nameCharString;
        public static string nameForDb;
        public static string idForDb;
        string tableName;

        Image<Bgr, Byte> image;
        Image<Bgr, Byte> image2;
        private Capture _capture = null;


        SqlConnection conn = new SqlConnection(@"Server=BLUU\SQLEXPRESS;Database=RecognizedFaces;Trusted_Connection=True;");


        //Events
        private void FaceRecScreen_Load(object sender, EventArgs e)
        {
            _capture.Start();
        }

        private void RecognizeFaceButton_Click(object sender, EventArgs e)
        {
            if (GreenBox.Visible) //if greenBox is visible, this mean is there is face on camera
            {
                if (PersonNameTxt.Text != "")
                {
                    nameForDb = PersonNameTxt.Text;
                    string[] nameCharString = PersonNameTxt.Text.Split(' '); //split by space, we will use that when creating table
                    tableName = "";
                    for (int i = 0; i < nameCharString.Length; i++)
                    {
                        tableName += nameCharString[i];
                    }

                    /* creating unique filename, "person name + date + time" */
                    string fileNamee = PersonNameTxt.Text + "_" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString()
                    + "-" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + ".jpg";

                    image2._EqualizeHist();
                    image2.Resize(250, 250, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC).ToBitmap().Save("TrainedFaces\\" + fileNamee); //Save to file.

                    if (isThereTable(tableName) == 0) //If person is not in the database.
                    {
                        /* creating a new table with person name as PersonName.dbo*/
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "CREATE TABLE [dbo].[" + tableName + "](" +
                            "[Name Surname] [varchar] (50)," +
                            "[BMI] [varchar](50) NULL," +
                            "[Date] [datetime] DEFAULT getdate()" +
                            ")" +
                            "Insert Into " + tableName + "([Name Surname]) Values ('" + nameForDb + "');";
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                        tableName = "";
                    }
                    PersonNameTxt.Text = "";
                    MessageBox.Show("Succesfull", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                    MessageBox.Show("Please Enter Name.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("There Is No Face!");
            }
        }

        private void ProgramLogo_MouseDown(object sender, MouseEventArgs e)
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

        private void ProgramName_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) //Exit Button
        {
            _capture.Stop();
            Application.Exit();
        }


        private void BackButton_Click(object sender, EventArgs e) //Back to IpCameraEnterScreen
        {
            _capture.Stop();
            IpCameraEnterScreen frm = new IpCameraEnterScreen();
            this.Hide();
            frm.Show();
        }


        //Functions

        int isThereTable(string x) 
        {
            /*
             * This function checks if the table given name is in the database.                                  
             * There is another table named isThere in the database, if table exist we write 1 to isThere table otherwise we write 0
             * and then we read this isThere table, and return its value
             */

            int a;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select case when exists((select* from INFORMATION_SCHEMA.TABLES where TABLE_NAME = '" + x + "')) then 1 else 0 end";
            cmd.ExecuteNonQuery();
            a = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            conn.Close();
            return a;
        }

        private void CameraCapture()
        {
            try
            {
                _capture = new Capture();

                _capture.ImageGrabbed += ProcessFrame2;

            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void ProcessFrame2(object sender, EventArgs arg)
        {

            //it must be half of camera taking size(in my camera 1280 x 960 that's why I wrote 640-480)
            image = _capture.RetrieveBgrFrame().Resize(640, 480, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);  

            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();
            long detectionTime;

            DetectFace.Detect(image, "haarcascade_frontalface_default.xml", "haarcascade_eye.xml", faces, eyes, out detectionTime);


            if (faces.Count == 0)   //if there is no face in camera
            {
                GreenBox.Visible = false;
                RedBox.Visible = true;
            }
            else //if there is    
            {
                RedBox.Visible = false;
                GreenBox.Visible = true;
            }

            Rectangle CropRectangle = new Rectangle(0, 0, 480, 480);    //drawing rectangle from x=0, y=0
            Bitmap bmpForFunc = new Bitmap(image.Bitmap);
            image = CropImage(bmpForFunc, CropRectangle);
            image2 = image;
            CaptureImageBox.Image = image;

        }

        private Image<Bgr, Byte> CropImage(Bitmap img, Rectangle rect)
        {
            Bitmap bmpForReturn = img.Clone(rect, img.PixelFormat);
            Image<Bgr, Byte> returnImage = new Image<Bgr, Byte>(bmpForReturn);
            return returnImage;
        }

       
    }
}
