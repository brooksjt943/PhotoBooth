using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoBooth
{
    public partial class PhotoBoothConfirmation : Form
    {
        public PhotoBoothConfirmation()
        {
            InitializeComponent();
        }

        private Bitmap _imageToPreview;
        public PhotoBoothConfirmation(Bitmap imageToPreview)
        {// set the picture box's image source to the image passed from Photo Booth Main Form.
            InitializeComponent();
            _imageToPreview = imageToPreview;
            pbxImagePreviewBox.Image = _imageToPreview;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void btnProceed_Click_1(object sender, EventArgs e)
        {
            PhotoBoothEdit editForm = new PhotoBoothEdit(_imageToPreview);
            editForm.Show();
            this.Close();
            this.Dispose();
        }

        private void btnRetakePhoto_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
