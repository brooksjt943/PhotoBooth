namespace PhotoBooth
{
    partial class PhotoBoothMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPhotoCapture = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitPhotoBooth = new System.Windows.Forms.Button();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelPhotoCapture
            // 
            this.panelPhotoCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPhotoCapture.BackColor = System.Drawing.Color.Transparent;
            this.panelPhotoCapture.Location = new System.Drawing.Point(0, 73);
            this.panelPhotoCapture.Name = "panelPhotoCapture";
            this.panelPhotoCapture.Size = new System.Drawing.Size(1904, 843);
            this.panelPhotoCapture.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1904, 72);
            this.label2.TabIndex = 13;
            this.label2.Text = "PhotoBooth";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Firebrick;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 919);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1904, 122);
            this.label3.TabIndex = 14;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountDown
            // 
            this.lblCountDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCountDown.BackColor = System.Drawing.Color.White;
            this.lblCountDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.Black;
            this.lblCountDown.Location = new System.Drawing.Point(834, 957);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(160, 75);
            this.lblCountDown.TabIndex = 18;
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(817, 933);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Photo Countdown";
            // 
            // btnExitPhotoBooth
            // 
            this.btnExitPhotoBooth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExitPhotoBooth.BackColor = System.Drawing.Color.Gray;
            this.btnExitPhotoBooth.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExitPhotoBooth.FlatAppearance.BorderSize = 2;
            this.btnExitPhotoBooth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExitPhotoBooth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExitPhotoBooth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitPhotoBooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPhotoBooth.ForeColor = System.Drawing.Color.White;
            this.btnExitPhotoBooth.Location = new System.Drawing.Point(1075, 957);
            this.btnExitPhotoBooth.Name = "btnExitPhotoBooth";
            this.btnExitPhotoBooth.Size = new System.Drawing.Size(160, 75);
            this.btnExitPhotoBooth.TabIndex = 16;
            this.btnExitPhotoBooth.Text = "Exit Photo Booth";
            this.btnExitPhotoBooth.UseVisualStyleBackColor = false;
            this.btnExitPhotoBooth.Click += new System.EventHandler(this.BtnExitPhotoBooth_Click);
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTakePhoto.BackColor = System.Drawing.Color.Gray;
            this.btnTakePhoto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTakePhoto.FlatAppearance.BorderSize = 2;
            this.btnTakePhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTakePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTakePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhoto.ForeColor = System.Drawing.Color.White;
            this.btnTakePhoto.Location = new System.Drawing.Point(586, 954);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(160, 75);
            this.btnTakePhoto.TabIndex = 15;
            this.btnTakePhoto.Text = "Take Photo!";
            this.btnTakePhoto.UseVisualStyleBackColor = false;
            this.btnTakePhoto.Click += new System.EventHandler(this.BtnTakePhoto_Click);
            // 
            // PhotoBoothMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitPhotoBooth);
            this.Controls.Add(this.btnTakePhoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelPhotoCapture);
            this.Name = "PhotoBoothMainForm";
            this.Text = "Photo Booth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelPhotoCapture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitPhotoBooth;
        private System.Windows.Forms.Button btnTakePhoto;
    }
}

