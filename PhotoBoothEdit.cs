using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoBooth
{
    public partial class PhotoBoothEdit : Form
    {
        private Bitmap takenPicture;
        private FormSelectorController FSC;

        //FrameForm object needs the captured image. =null by default for testing resizing/etc. without a photo.
        public PhotoBoothEdit(Bitmap takenPicture = null)
        {
            this.takenPicture = takenPicture;
            InitializeComponent();
            this.takenPicture = takenPicture;

            //this.FSC = new FormSelectorController(this.takenPicture);
            DisplayBox.Image = takenPicture;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;            
        }

        // Next frame in List.
        private void pcbxRight_Click(object sender, EventArgs e)
        {
            this.DisplayBox.Image = this.FSC.getNextFrame();
        }

        private void btnExitPhotoBooth2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Previous frame in List.
        private void pcbxLeft_Click_1(object sender, EventArgs e)
        {
            this.DisplayBox.Image = this.FSC.getPreviousFrame();
        }

        // Create an Emailer object and send the email.
        private void btnSendEmail_Click(object sender, EventArgs e)
        {

            try
            {
                if (takenPicture != null)
                {

                    string promptValue = Prompt.ShowDialog("Email Address: ", "Enter Email Address");

                    if (promptValue != string.Empty)
                    {
                        Cursor = Cursors.WaitCursor;
                        Emailer emailer = new Emailer(promptValue, DisplayBox.Image);
                        emailer.SendEmail();
                        MessageBox.Show("Your photo has been emailed!", "Success");
                        Cursor = Cursors.Arrow;

                    }
                }
                else
                {
                    MessageBox.Show("You must take a photo to send an email.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error sending the email.\nError: " + ex.Message, "Error");
            }


        }

        //Saves current framed photo to C:\Gallery.
        private void btnSaveToGallery_Click(object sender, EventArgs e)
        {
            try
            {
                if (takenPicture != null)
                {
                    string fileNameRandomizer;
                    string fileName;

                    // Use a randomizer to generate unique filenames. - "PhotoBoothImage" followed by formatted current datetime.
                    fileNameRandomizer = DateTime.Now.ToString();
                    fileName = fileNameRandomizer + ".jpg";
                    fileName = fileName.Replace("/", string.Empty);
                    fileName = fileName.Replace(" ", string.Empty);
                    fileName = fileName.Replace(":", string.Empty);
                    fileName = "C:\\Gallery\\PhotoBoothImage" + fileName;


                    DisplayBox.Image.Save(fileName);
                    MessageBox.Show("Your photo has been added to the photo gallery!", "Success");

                }
                else
                {
                    MessageBox.Show("You must take a picture before saving.", "Fail");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to save to the gallery.\nError: " + ex.Message, "Error");
            }
        }

        // Drawing Feature
        Point lastPoint = Point.Empty;//Point.Empty represents null for a Point object
        bool isDrawEnabled = false;
        bool isMouseDown = new Boolean();

        private void tsbDraw_Click(object sender, EventArgs e)
        {
            if (!isDrawEnabled)
                isDrawEnabled = true;
            else
                isDrawEnabled = false;
        }

        private void DisplayBox_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastPoint = e.Location;
        }

        private void DisplayBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && isDrawEnabled)
                if (lastPoint != null)
                {
                    if (DisplayBox.Image == null)
                    {
                        Bitmap bmp = new Bitmap(DisplayBox.Width, DisplayBox.Height);
                        DisplayBox.Image = bmp;
                    }
                    using (Graphics g = Graphics.FromImage(DisplayBox.Image))
                    {
                        g.DrawLine(new Pen(Color.Black, 2), lastPoint, e.Location);
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                    }
                    DisplayBox.Invalidate();//refreshes the picturebox
                    lastPoint = e.Location;//keep assigning the lastPoint
                }
        }

        private void DisplayBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            lastPoint = Point.Empty;
        }

        private void tsbColor_Click(object sender, EventArgs e)
        {
            // Allow to select color
            // Add brushes 
        }

        private Color SelectColor()
        {
            // Scrap add new custom form
            Color selected = Color.Black;
            ColorDialog colorForm = new ColorDialog();
            if (colorForm.ShowDialog() == DialogResult.OK)
                selected = colorForm.Color;
            return selected;
        }
    }
}
