using System;
using System.Windows.Forms;

namespace Slideshow
{
    public partial class Form1 : Form
    {
        private Timer timer2;
        private int currentImageIndex = 0;

        public Form1()
        {
            InitializeComponent();
            timer2 = new Timer();
            timer2.Interval = 2000;
            timer2.Tick += timer1_Tick;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            btn_Stop.Enabled = true;
            btn_Start.Enabled = false;

            // Reset the timer and current image index
            timer2.Stop(); // Stop the timer if it was running
            currentImageIndex = 0; // Reset the image index
            timer2.Start(); // Start the timer again.

            timer1_Tick(sender, e); // Show first image immediately
            pictureBox1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 0)
            {
                pictureBox1.Image = imageList1.Images[currentImageIndex];
                pictureBox1.Refresh();

                currentImageIndex++;

                if (currentImageIndex >= imageList1.Images.Count)
                {
                    currentImageIndex = 0; // Loop
                }
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            btn_Stop.Enabled = false;
            btn_Start.Enabled = true;
            timer2.Stop(); // Stop the timer
            pictureBox1.Visible = false;
        }
    }
}