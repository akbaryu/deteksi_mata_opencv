using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using OpenCvSharp;

namespace KC_DeteksiMata
{
    public partial class MainForm : Form
    {
        private Thread _cameraThread;

        public MainForm()
        {
            InitializeComponent();
        }

        //thread kamera
        #region Thread Camera
        private void CaptureCamera()
        {
            _cameraThread = new Thread(new ThreadStart(CaptureCameraCallback));
            _cameraThread.Start();
        }

        private void CaptureCameraCallback()
        {
            const double ScaleFactor = 2.5;
            const int MinNeighbors = 1;
            CvSize MinSize = new CvSize(30, 30);

            //mengambil data dari kamera langsung
            CvCapture cap = CvCapture.FromCamera(2);
            //menggunakan cascade classifier
            CvHaarClassifierCascade cascade = CvHaarClassifierCascade.FromFile("haarcascade_eye.xml");
            
            //deteksi mata
            while (true)
            {
                IplImage img = cap.QueryFrame();
                CvSeq<CvAvgComp> eyes = Cv.HaarDetectObjects(img, cascade, Cv.CreateMemStorage(), ScaleFactor, MinNeighbors, HaarDetectionType.DoCannyPruning, MinSize);

                foreach (CvAvgComp mata in eyes.AsParallel())
                {
                    img.DrawRect(mata.Rect, CvColor.Red);

                    if (mata.Rect.Left > pctCvWindow.Width / 2)
                    {
                        try
                        {
                            IplImage MataImg1 = img.Clone();
                            Cv.SetImageROI(MataImg1, mata.Rect);
                            IplImage MataImg2 = Cv.CreateImage(mata.Rect.Size, MataImg1.Depth, MataImg1.NChannels);
                            Cv.Copy(MataImg1, MataImg2, null);
                            Cv.ResetImageROI(MataImg1);
                            Bitmap MataBitmap = BitmapConverter.ToBitmap(MataImg2);
                            Console.WriteLine("Mata terdeteksi, HIDUPKAN vibrator!!!");

                        }
                        catch { }
                    }

                }
                //keluar (while) , mata tidak terdeteksi.
                Bitmap bm = BitmapConverter.ToBitmap(img);
                bm.SetResolution(pctCvWindow.Width, pctCvWindow.Height);
                pctCvWindow.Image = bm;

                img = null;
                bm = null;
                Console.WriteLine("Mata TIDAK terdeteksi, MATIKAN vibrator!!!");
            }
        }
        #endregion

        //method Handler form
        #region Form Handlers
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cameraThread != null && _cameraThread.IsAlive)
            {
                _cameraThread.Abort();
            }
        }
        #endregion

        //method Tombol
        #region Button Handlers
        private void btnDeteksi_Click(object sender, EventArgs e)
        {
            if (btnDeteksi.Text.Equals("Deteksi Mata"))
            {
                CaptureCamera();
                btnDeteksi.Text = "Stop";
            }
            else
            {
                _cameraThread.Abort();
                btnDeteksi.Text = "Deteksi Mata";
            }
        }

        #endregion
    }
}
