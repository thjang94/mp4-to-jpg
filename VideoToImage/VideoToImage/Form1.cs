using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;

namespace VideoToImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoCapture video = new VideoCapture(this.pathTextBox.Text);
            Mat frame = new Mat();
            int i = 0;

            totalFram.Text = video.FrameCount.ToString();

            start();
        }

        private async void start()
        {
            // 인터넷 리소스 권한 요청 후 응답 받아온다.
            var task = Task.Run(() =>
            {
                VideoCapture video = new VideoCapture(this.pathTextBox.Text);
                Mat frame = new Mat();
                int i = 0;

                totalFram.Text = video.FrameCount.ToString();
                while (video.PosFrames != video.FrameCount)
                {

                    video.Read(frame);
                    // this.pic_MainImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);

                    frame.ImWrite(this.savePathTextBox.Text + "\\" + i.ToString() + ".jpg");
                    i++;
                    setLabel1TextSafe(i.ToString());
                }

                frame.Dispose();
                video.Release();
            });
            await task;
        }

        private void setLabel1TextSafe(string txt)
        {
            if (nowFram.InvokeRequired)
                nowFram.Invoke(new Action(() => nowFram.Text = txt));
            else
                nowFram.Text = txt;
        }
    }
}
