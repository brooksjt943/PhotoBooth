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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitPhotoBooth = new System.Windows.Forms.Button();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Location = new System.Drawing.Point(146, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 747);
            this.panel1.TabIndex = 5;
            // 
            // btnExitPhotoBooth
            // 
            this.btnExitPhotoBooth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExitPhotoBooth.BackColor = System.Drawing.Color.White;
            this.btnExitPhotoBooth.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExitPhotoBooth.FlatAppearance.BorderSize = 2;
            this.btnExitPhotoBooth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExitPhotoBooth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExitPhotoBooth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitPhotoBooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPhotoBooth.ForeColor = System.Drawing.Color.LightCoral;
            this.btnExitPhotoBooth.Location = new System.Drawing.Point(925, 893);
            this.btnExitPhotoBooth.Name = "btnExitPhotoBooth";
            this.btnExitPhotoBooth.Size = new System.Drawing.Size(160, 75);
            this.btnExitPhotoBooth.TabIndex = 10;
            this.btnExitPhotoBooth.Text = "Exit Photo Booth";
            this.btnExitPhotoBooth.UseVisualStyleBackColor = false;
            this.btnExitPhotoBooth.Click += new System.EventHandler(this.BtnExitPhotoBooth_Click);
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTakePhoto.BackColor = System.Drawing.Color.White;
            this.btnTakePhoto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTakePhoto.FlatAppearance.BorderSize = 2;
            this.btnTakePhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTakePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTakePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhoto.ForeColor = System.Drawing.Color.LightCoral;
            this.btnTakePhoto.Location = new System.Drawing.Point(429, 893);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(160, 75);
            this.btnTakePhoto.TabIndex = 9;
            this.btnTakePhoto.Text = "Take Photo!";
            this.btnTakePhoto.UseVisualStyleBackColor = false;
            this.btnTakePhoto.Click += new System.EventHandler(this.BtnTakePhoto_Click);
            // 
            // lblCountDown
            // 
            this.lblCountDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCountDown.BackColor = System.Drawing.Color.White;
            this.lblCountDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.LightCoral;
            this.lblCountDown.Location = new System.Drawing.Point(684, 893);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(160, 75);
            this.lblCountDown.TabIndex = 12;
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(667, 869);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Photo Countdown";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(501, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 72);
            this.label2.TabIndex = 13;
            this.label2.Text = "Photo  Booth";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhotoBoothMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitPhotoBooth);
            this.Controls.Add(this.btnTakePhoto);
            this.Controls.Add(this.panel1);
            this.Name = "PhotoBoothMainForm";
            this.Text = "Photo Booth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExitPhotoBooth;
        private System.Windows.Forms.Button btnTakePhoto;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

