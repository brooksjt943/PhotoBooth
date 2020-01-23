using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoBooth
{
    public partial class PhotoBoothMainForm : Form
    {
        private Timer _timer1;
        private int _counter = 3;
        public CameraWrapper CamWrapper { get; set; }
        public PhotoBoothMainForm()
        {// timer object and counter for the timer.
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        // EVENTS
        private void BtnTakePhoto_Click(object sender, EventArgs e)
        {// start countdown to photo capture when Take Photo is clicked. 
            StartCountdown();
        }

        private void _timer1_Tick(object sender, EventArgs e)
        {// checks counter value on each tick, takes photo when _counter = 0.
            _counter--;
            if (_counter == 0)
            {
                _timer1.Stop();
                lblCountDown.Text = "OK!";
                // create a Bitmap from the video feed capture.
                Bitmap image = CamWrapper.Capture();
                // open the confirmation form and pass it the image.
                PhotoBoothConfirmation confirmationForm = new PhotoBoothConfirmation(image);
                confirmationForm.Show();
            }
            else
            {
                lblCountDown.Text = _counter.ToString() + "...";
            }
        }

        private void BtnExitPhotoBooth_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // METHODS
        private void StartCountdown()
        {// do the countdown, check counter value with _timer1_Tick event on each tick.
            _counter = 3;
            _timer1 = new Timer();
            _timer1.Tick += new EventHandler(_timer1_Tick);
            _timer1.Interval = 1000; // 1 second
            _timer1.Start();
            lblCountDown.Text = _counter.ToString() + "...";
        }
    }
}
