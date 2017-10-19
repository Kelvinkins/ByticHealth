using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ByticHealth.UserControls;

namespace ByticHealth.Forms
{
    public partial class Main : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in videoDevices)
            {
                cmbDevices.Items.Add(device.Name);
            }
            cmbDevices.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if(videoSource.IsRunning)
            {
                videoSource.Stop();
                //pictureBox1.Image = null;
                //pictureBox1.Invalidate();
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[cmbDevices.SelectedIndex].MonikerString);

                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = image;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoSource.IsRunning)
            videoSource.Stop();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            uscPatientRegistration.picPassport.Image = pictureBox1.Image;
            this.Close();
        }
    }
}
