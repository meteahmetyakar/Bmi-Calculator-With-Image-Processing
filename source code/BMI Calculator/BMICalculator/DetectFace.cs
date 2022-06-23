using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.GPU;

namespace FaceDetection
{
   public static class DetectFace
   {
       public static void Detect(Image<Bgr, Byte> image, String faceFileName, String eyeFileName, List<Rectangle> faces, List<Rectangle> eyes, out long detectionTime)
       {
           Stopwatch watch;
           
           using (CascadeClassifier face = new CascadeClassifier(faceFileName))
           using (CascadeClassifier eye = new CascadeClassifier(eyeFileName))
           {
               watch = Stopwatch.StartNew();
               using (Image<Gray, Byte> gray = image.Convert<Gray, Byte>()) 
               {
                   
                   gray._EqualizeHist();

                   Rectangle[] facesDetected = face.DetectMultiScale(
                       gray,
                       1.1,
                       10,
                       new Size(20, 20),
                       Size.Empty);
                   faces.AddRange(facesDetected);

                   foreach (Rectangle f in facesDetected)
                   {
                       gray.ROI = f;
                       Rectangle[] eyesDetected = eye.DetectMultiScale(
                       gray,
                       1.1,
                       10,
                       new Size(20, 20),
                       Size.Empty);
                       gray.ROI = Rectangle.Empty;

                       foreach (Rectangle e in eyesDetected)
                       {
                           Rectangle eyeRect = e;
                           eyeRect.Offset(f.X, f.Y);
                           eyes.Add(eyeRect);
                       }
                   }
               }
               watch.Stop();
               detectionTime = watch.ElapsedMilliseconds;
           }

       }


   }
}
