namespace PhotoBooth
{
    partial class PhotoBoothConfirmation
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
            this.btnRetakePhoto = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.pbxImagePreviewBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagePreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetakePhoto
            // 
            this.btnRetakePhoto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRetakePhoto.BackColor = System.Drawing.Color.Gray;
            this.btnRetakePhoto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetakePhoto.FlatAppearance.BorderSize = 2;
            this.btnRetakePhoto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnRetakePhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRetakePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRetakePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetakePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetakePhoto.ForeColor = System.Drawing.Color.White;
            this.btnRetakePhoto.Location = new System.Drawing.Point(1073, 950);
            this.btnRetakePhoto.Name = "btnRetakePhoto";
            this.btnRetakePhoto.Size = new System.Drawing.Size(160, 75);
            this.btnRetakePhoto.TabIndex = 13;
            this.btnRetakePhoto.Text = "Retake Photo";
            this.btnRetakePhoto.UseVisualStyleBackColor = false;
            this.btnRetakePhoto.Click += new System.EventHandler(this.btnRetakePhoto_Click_1);
            // 
            // btnProceed
            // 
            this.btnProceed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProceed.BackColor = System.Drawing.Color.Gray;
            this.btnProceed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProceed.FlatAppearance.BorderSize = 2;
            this.btnProceed.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnProceed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(671, 950);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(160, 75);
            this.btnProceed.TabIndex = 12;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click_1);
            // 
            // pbxImagePreviewBox
            // 
            this.pbxImagePreviewBox.Location = new System.Drawing.Point(0, 72);
            this.pbxImagePreviewBox.Name = "pbxImagePreviewBox";
            this.pbxImagePreviewBox.Size = new System.Drawing.Size(1904, 859);
            this.pbxImagePreviewBox.TabIndex = 11;
            this.pbxImagePreviewBox.TabStop = false;
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
            this.label2.TabIndex = 14;
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
            this.label3.TabIndex = 15;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhotoBoothConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRetakePhoto);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.pbxImagePreviewBox);
            this.Controls.Add(this.label3);
            this.Name = "PhotoBoothConfirmation";
            this.Text = "PhotoBoothConfirmation";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagePreviewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRetakePhoto;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.PictureBox pbxImagePreviewBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}