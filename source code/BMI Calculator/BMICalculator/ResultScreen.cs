using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Net.Http;
using FaceDetection;
using BMICalculator;

namespace BMICalculator
{
    public partial class ResultScreen : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]                  
        public static extern int SendMessage(IntPtr hWnd,   
        int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Database db = new Database();


        public static double BMI = 0;
        public static string BMIForDB;
        int tf = 0;
        public ResultScreen()
        {
            InitializeComponent();
        }


        public static string id;
        string PersonName;

        Image<Bgr, Byte> image;

        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);

        int lbphTrainedImageCounter;
        List<Image<Gray, byte>> lbphTrainingImages = new List<Image<Gray, byte>>();
        List<int> lbphIntlabels = new List<int>();
        List<string> lbphlabels = new List<string>();
        LBPHFaceRecognizer lbphFaceRecognizer;

        //Events

        private void ResultScreen_Load(object sender, EventArgs e)
        {

            TrainDatabase();

            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                /* here (until 69) we use remove.bg API for remove background of image */
                formData.Headers.Add("X-Api-Key", "eGpXTbJ4zsS2PeawEwZhwobG");
                formData.Add(new ByteArrayContent(File.ReadAllBytes(Application.StartupPath + "\\image.jpg")), "image_file", "file.jpg");
                formData.Add(new StringContent("auto"), "size");
                var response = client.PostAsync("https://api.remove.bg/v1.0/removebg", formData).Result;

                if (response.IsSuccessStatusCode)
                {
                    FileStream fileStream = new FileStream("image.png", FileMode.Create, FileAccess.Write, FileShare.None);
                    response.Content.CopyToAsync(fileStream).ContinueWith((copyTask) => { fileStream.Close(); });
                }
                else
                {
                    Console.WriteLine("Error: " + response.Content.ReadAsStringAsync().Result);
                }

            }

            image = new Image<Bgr, byte>(Application.StartupPath + "\\image.jpg");
            image._EqualizeHist();


            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();
            long detectionTime;
            /* recognizing processes */
            DetectFace.Detect(image, "haarcascade_frontalface_default.xml", "haarcascade_eye.xml", faces, eyes, out detectionTime);
            foreach (Rectangle face in faces)
            {

                var result = lbphFaceRecognizer.Predict(image.Convert<Gray, Byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC));
                if (result.Label != -1)
                {
                    CvInvoke.cvResetImageROI(image);
                    PersonName = lbphlabels[result.Label].ToString();
                }
                else
                {
                    PersonName = null;
                }

                CvInvoke.cvResetImageROI(image);
            }

            // If the person is known, the person name is not null
            if (PersonName != null)
            {
                string[] nameArray = PersonName.Split('_'); //name saving as "name surname_date_time..." if we split with '_' we can take person's name
                PersonName = nameArray[0]; //index 0 is name

                ResultsDataGridView.DataSource = db.fetchAllWithName(PersonName);
                
            }

            do
            {
                try
                {
                    PhotoPictureBox.Image = Image.FromFile(Application.StartupPath + "\\image.jpg");  //Puts the image.png file whose directory we have specified into the picturebox.
                    tf = 1;
                }
                catch (Exception)
                { tf = 0; }
            } while (tf == 0);

            Bitmap bm = new Bitmap(Application.StartupPath + "\\image.png");            //Throws the image.png file into the bitmap named bm.
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            for (int y = 0; y < bm.Height; y++)                                         // Because the program will calculate BMI over a black and white silhouette
            {                                                                           // In this for loop, transparent parts are painted black.
                for (int x = 0; x < bm.Width; x++)
                {
                    if (bm.GetPixel(x, y) == Color.FromArgb(0, 0, 0, 0))
                    {
                        bm.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                    }
                }
            }
            for (int y = 0; y < bm.Height; y++)                                         //Here, non-black parts are painted white to create a silhouette.
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    if (bm.GetPixel(x, y) != Color.FromArgb(255, 0, 0, 0))
                    {
                        bm.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                    }
                }
            }
            double A = 0;
            double H = 0;
            double H2 = 0;
            double H1 = 0;
            int a = 0;
            int b = 0;

            while (bm.GetPixel(a, b) != Color.FromArgb(255, 255, 255, 255))             //Looping up to the first white pixel so that the highest point of the silhouette is found.
            {
                H1 = b;
                a++;
                if (a == bm.Width)
                {
                    b++;
                    a = 0;
                }
            }

            for (int y = 0; y < bm.Height; y++)                                         //Here, the white pixels are counted, the silhouette area is calculated, and when each white pixel is reached,
            {                                                                           //The height of that pixel is assigned to the variable H2 and in this way the lowest point of the silhouette is calculated.
                for (int x = 0; x < bm.Width; x++)                                      // Every time a white pixel appears, variable A increases by 1 and the area of the silhouette is calculated.
                {
                    if (bm.GetPixel(x, y) == Color.FromArgb(255, 255, 255, 255))
                    {
                        A++;
                        H2 = y;
                    }
                }
            }

            H = H2 - H1;                                                                //The highest and lowest points of the silhouette are subtracted from each other and the length of the silhouette is calculated.
            BMI = ((((((22 / 7) * A * A) / (8 * H * H * H)) - 4.1219) / 0.1963));       //BMI calculation is done with the formula I got from the article named "Calculation of Body Mass Index using Image Processing Techniques".
            BMITextBox.Text = BMI.ToString("0.##");
            BMIForDB = BMI.ToString("0.##");

            
            double lastMeasuredBMI = db.LastMeasuredBMI(PersonName);

            PhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            if (PersonName == null) //if person is not recognized
            {
                AdviceRichTextBox.AppendText("Öncelikle hoş geldin. Fakat seni tanıyamadım. Bu yüzden sadece vücut kitle endeksin üzerinden konuşacağım. ");
                BMIAdvice(BMI);
            }
            else if (db.fetchAllWithName(PersonName).Rows.Count == 0) //if it is the first measurement 
            {
                AdviceRichTextBox.AppendText("İlk ölçümüne hoşgeldin " + PersonName + ". ");
                BMIAdvice(BMI);
            }
            else //if not measuring for the first time
            {
                AdviceRichTextBox.AppendText("Hoşgeldin " + PersonName + ". Önceki tarihlerdeki ölçümlerini yukarıda görebilirsin. Son ölçümün üzerinden ");
                if (db.LastMeasureDate(PersonName) > 30)
                {
                    AdviceRichTextBox.AppendText("çok zaman geçmiş. Ölçümlerin arasındaki zamanı bu kadar uzun tutmamalısın ki takibini daha iyi yapalım ve ona göre hareket edelim. ");
                    if (CheckChange(BMI, lastMeasuredBMI))
                    {
                        AdviceRichTextBox.AppendText("Son ölçümünden bu yana çok fazla bir değişim yok. ");
                        if (NoMoreChanges(BMI, lastMeasuredBMI))
                        {
                            AdviceRichTextBox.AppendText("Değişim çok da isteyeceğimiz bir şey değil. Çünkü durumun gayet iyi. ");
                            BMIAdvice(BMI);
                        }
                        else
                        {
                            AdviceRichTextBox.AppendText("Fakat bu durumda moral bozmak gibi bir hata yapmamalısın. Henüz bir diyetisyenle görüşmediysen, " +
                                "hemen randevu alıp görüşmeni tavsiye ederim. Diyetisyeninin tavsiyelerini uygulayıp sporunu da aksatmazsan istediğin " +
                                "fiziğe hızlı bir şekilde ulaşacağından eminim. ");
                            BMIAdvice(BMI);
                        }
                    }
                    else
                    {
                        AdviceRichTextBox.AppendText("Son ölçümünden bu yana çok büyük bir değişim var. ");
                        if (ThereAreMoreChanges(BMI, lastMeasuredBMI))
                        {
                            AdviceRichTextBox.AppendText("Değişimin gayet iyi görünüyor. Bu zamana kadar uyguladığın diyet ve spor programına devam etmeni tavsiye ederim. ");
                            BMIAdvice(BMI);
                        }
                        else
                        {
                            AdviceRichTextBox.AppendText("Son ölçümünden sonra çok yanlış beslenmiş gibi görünüyorsun. Ölçümlerini, diyetini ve sporunu aksatma. " +
                                "Eğer bu durumun kötü beslenme dışında sebepleri olduğunu düşünüyorsan lütfen bir diyetisyenle görüş. ");
                            BMIAdvice(BMI);
                        }
                    }
                }
                else
                {
                    AdviceRichTextBox.AppendText("çok zaman geçmemiş. ");
                    if (CheckChange(BMI, lastMeasuredBMI))
                    {
                        AdviceRichTextBox.AppendText("Bunun da etkisiyle birlikte çok bir değişim yok. ");
                        if (NoMoreChanges(BMI, lastMeasuredBMI))
                        {
                            AdviceRichTextBox.AppendText("Değişim çok da isteyeceğimiz bir şey değil. Durumun gayet iyi görünüyor. ");
                            BMIAdvice(BMI);
                        }
                        else
                        {
                            AdviceRichTextBox.AppendText("Fakat bu durumda moral bozmak gibi bir hata yapmamalısın. Henüz bir diyetisyenle görüşmediysen, hemen randevu alıp görüşmeni tavsiye ederim. " +
                                "Diyetisyeninin tavsiyelerini uygulayıp sporunu da aksatmazsan istediğin fiziğe hızlı bir şekilde ulaşacağından eminim. ");
                            BMIAdvice(BMI);
                        }
                    }
                    else
                    {
                        AdviceRichTextBox.AppendText("Buna rağmen büyük bir değişim yaşadığını görüyorum. ");
                        if (ThereAreMoreChanges(BMI, lastMeasuredBMI))
                        {
                            AdviceRichTextBox.AppendText("Değişimin isteyeceğimiz bir yönde olsa bile. Hızlı kilo almak da vermek de fazlasıyla zararlı bir durum. " +
                                "Önemli olan kilo vermek değil yağ oranından kaybetmek. Aynı şekilde kilo almak değil, kiloyu kas kütlesi olarak almak. " +
                                "Bir diyetisyene gidip, bazal metabolizma hızını ve yağ oranını ölçtürüp bir profesyonelden tavsiye alman senin için çok daha iyi olur. ");
                            BMIAdvice(BMI);
                        }
                        else
                        {
                            AdviceRichTextBox.AppendText("Bu kadar kısa sürede bu denli kilo almak da kilo vermek de fazlasıyla zararlı bir durum. " +
                                "Amacın kilo almak veya kilo vermek olsa da bunu en doğru ve en sağlıklı şekilde yapmak zorundasın çünkü bu durum ciddi sağlık sorunlarına yol açabilir. " +
                                "Eğer bu değişim için herhangi bir diyet yapmadıysan ve istemeden olduysa bir diyetisyene gitmelisin. ");
                            BMIAdvice(BMI);
                        }
                    }
                }
            }

            if (PersonName != null) //saving datas to database
            {
                db.addRow(PersonName, BMIForDB); //Saves the BMI measurement to the corresponding location in the database.

            }

        }

        private void ExitButton_Click(object sender, EventArgs e) //Exit button
        {
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

        bool CheckChange(double BMI, double SonOlcum) // It questions whether the change is more or less compared to the previous measurement.
        {
            bool x = false;
            if (BMI - SonOlcum > -1.5 && BMI - SonOlcum < 1.5)
                x = true;
            else
                x = false;
            return x;
        }       

        bool ThereAreMoreChanges(double BMI, double SonOlcum) //What to do if there are too many changes.
        { 
            bool x = false;
            if (BMI >= 23)
            {
                if (BMI - SonOlcum < -1.5)
                {
                    x = true;
                }
                else if (BMI - SonOlcum > 1.5)
                {
                    x = false;
                }
            }
            else if (BMI < 23)
            {
                if (BMI - SonOlcum < -1.5)
                {
                    x = false;
                }
                else if (BMI - SonOlcum > 1.5)
                {
                    x = true;
                }
            }
            return x;
        }       

        bool NoMoreChanges(double BMI, double SonOlcum) // What to do if there are not many changes.
        {
            bool x = false;
            if (BMI >= 25)
            {
                if (BMI - SonOlcum > -1.5 && BMI - SonOlcum < 0)
                {
                    x = false;
                }
                else if (BMI - SonOlcum < 1.5 && BMI - SonOlcum > 0)
                {
                    x = false;
                }
            }
            else if (BMI < 25)
            {
                x = true;
            }
            return x;
        }       

        void BMIAdvice(double BMI) // Recommendations are made to the person according to the calculated BMI.
        { 
            if (BMI < 18.5)                                                             
            {
                AdviceRichTextBox.AppendText("Eğer çeşitli gıdalarla ve dengeli besleniyorsan beslenme alışkanlığını değiştirmene gerek yok. " +
                    "Ancak günlük enerji ihtiyacını karşılayacak şekilde beslendiğinden emin olmalısın. " +
                    "Ancak biraz kilo almak da senin için faydalı olacaktır. Daha fazla kilo kaybetmemeye dikkat et. " +
                    "Eğer yetersiz besleniyorsan bunun sonucunda çeşitli hastalıklara yakalanma riskini arttırıyorsun. " +
                    "Örneğin osteoporoz bunlardan birisidir. Sürekli olarak kendini hasta, bitkin hissediyorsan doktora danışmalısın.  " +
                    "Ani ya da sebepsiz kilo kaybı, genellikle bir sağlık sorununa işaret eder.");
            }
            else if (BMI <= 24.9)
            {
                AdviceRichTextBox.AppendText("Genel olarak sağlıklı olduğunu söyleyebilirim. " +
                    "Doğru beslenmenin sonucunda kalp krizi, osteoporoz, bazı kanser türleri ve diğer beslenmeye bağlı rahatsızlıklara yakalanma riskin oldukça düşer." +
                    "Beslenmeni çok çeşitli ve dengeli tutarak, fiziksel egzersizler yaparak bu sağlıklı kilonu ömür boyu sürdürebilirsin.");
            }
            else if (BMI <= 29.9)
            {
                AdviceRichTextBox.AppendText("Çok kritik bir sorun olmasa da yalnızca birkaç kilo vermen sağlığın için oldukça faydalı olacaktır. " +
                    "Kesinlikle daha fazla kilo almamaya dikkat et. " +
                    "Fazla kilolar diyabet, yüksek tansiyon, kalp krizi, felç ve çeşitli kanser türlerine davetiye çıkarabilir. " +
                    "Eğer bedensel aktivitelere yeteri kadar zaman ayırmıyorsan artık bir değişiklik yapmanın zamanı gelmiş. " +
                    "Çok ağır olmasa da düzenli olarak orta zorlukta egzersizlere başlamalısın. Kendine uygun, yapmaktan zevk alacağın ve hayatın boyunca sürdürebileceğin bir egzersiz seçmek önemli. " +
                    "Bolca meyve sebze tüketimini artırıp yağlı yiyecekleri azaltmalısın. Tabağına koyduğun porsiyonlara da dikkat et. " +
                    "Tatlandırıcı içeren yiyecek ve içecekleri tüketmeyi derhal bırakmalısın. Çok hızlı kilo vermekten ise kaçın çünkü kilolarının geri gelmemesi için yavaş yavaş vermelisin. " +
                    "İdeal zayıflama hızın haftada yarım kilo olmalıdır.");
            }
            else if (BMI <= 34.9)
            {
                AdviceRichTextBox.AppendText("Bir doktor ya da diyetisyene başvurman senin için faydalı olabilir. " +
                    "Obezite; şeker, tansiyon, kalp krizi, hamilelik problemleri, sırt ağrısı, felç ve kanser gibi sağlık problemlerinin tetikleyicilerinden biridir." +
                    "Kesinlikle daha fazla kilo almamalı ve derhal kilo vermeye başlamalısın. " +
                    "Haftada yarım kilo vermenin en sağlıklı ve kalıcı zayıflama şekli olduğunu unutmadan, sebze meyve ağırlıklı beslenmeye başlamalı, yağlı, tatlandırıcılı besinlerden kaçınmalı ve porsiyonlarını mutlaka gözden geçirmelisin. " +
                    "Egzersiz yapmaya başlamalı ve bunu bir yaşam tarzı şekline getirmelisin.");
            }
            else
            {
                AdviceRichTextBox.AppendText("Durumun gerçekten de kritik. " +
                    "Yüksek sağlık riski taşıyorsun ve bir an önce önlem almalısın. " +
                    "Eğer geçmişte kilo vermeye çalışıp başaramadıysan ya da verdiğin kiloyu tekrar geri aldıysan bu moralini bozmasın. " +
                    "Yeniden kilo vermek için yemek alışkanlığını değiştirmeli ve spora başlamalısın. Gün içinde aldığından daha fazla kalori harcamalısın. " +
                    "Meyve sebze ağırlıklı, az yağlı bir diyete başlamalı, yağlı ve tatlandırıcılı gıdalardan kesinlikle vazgeçmelisin. " +
                    "Mutlaka bir diyetisyene ya da doktora başvurmayı da ihmal etme çünkü senin farkında olmadığın çeşitli sağlık problemlerin de olabilir.");
            }
        }                         

        void TrainDatabase() //training faces from TrainedFaces files
        {
            try
            {
                string dataDirectory = Directory.GetCurrentDirectory() + "\\TrainedFaces";

                string[] files = Directory.GetFiles(dataDirectory, "*.jpg", SearchOption.AllDirectories);
                lbphTrainedImageCounter = 0;
                foreach (var file in files)
                {
                    Image<Bgr, Byte> TrainedImage = new Image<Bgr, Byte>(file);

                    lbphTrainingImages.Add(TrainedImage.Convert<Gray, Byte>());
                    lbphlabels.Add(fileName(file));
                    lbphIntlabels.Add(lbphTrainedImageCounter);
                    lbphTrainedImageCounter++;
                }
                lbphFaceRecognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 400);
                lbphFaceRecognizer.Train(lbphTrainingImages.ToArray(), lbphIntlabels.ToArray());
                lbphFaceRecognizer.Save(dataDirectory + "\\trainedDataLBPH.dat");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        string fileName(string file) //returns file name
        {
            string[] fileArr = file.Split('\\');
            var fileName = fileArr[fileArr.Length - 1].Split('_')[0];
            return fileName;
        }

       

        
    }
}
