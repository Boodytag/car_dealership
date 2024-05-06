using System;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;

namespace QRCodeScannerApp
{
    public partial class QrScanner : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private PictureBox pictureBox1; 

        public QrScanner()
        {
            InitializeComponent();
            InitializeCamera();
        }

        private void InitializeCamera()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video devices found.");
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame;
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox1.Image = (System.Drawing.Image)eventArgs.Frame.Clone();

                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((System.Drawing.Bitmap)eventArgs.Frame.Clone());

                if (result != null)
                {
                    MessageBox.Show($"Scanned QR Code Data: {result.Text}");
                    videoSource.SignalToStop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox(); 
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480); // Adjust size as needed
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // QrScanner
            // 
            this.ClientSize = new System.Drawing.Size(664, 504); 
            this.Controls.Add(this.pictureBox1); 
            this.Name = "QrScanner";
            this.Load += new System.EventHandler(this.QrScanner_Load);
            this.ResumeLayout(false);
        }

        private void QrScanner_Load(object sender, EventArgs e)
        {

        }
    }
}
