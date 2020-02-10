namespace PhotoBooth
{
    partial class PhotoBoothEdit
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoBoothEdit));
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExitPhotoBooth = new System.Windows.Forms.Button();
            this.btnSaveToGallery = new System.Windows.Forms.Button();
            this.DisplayBox = new System.Windows.Forms.PictureBox();
            this.toolPhotoEditor = new System.Windows.Forms.ToolStrip();
            this.tsbDraw = new System.Windows.Forms.ToolStripButton();
            this.tsbColor = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).BeginInit();
            this.toolPhotoEditor.SuspendLayout();
            this.SuspendLayout();
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
            // btnSendEmail
            // 
            this.btnSendEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSendEmail.BackColor = System.Drawing.Color.Gray;
            this.btnSendEmail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSendEmail.FlatAppearance.BorderSize = 2;
            this.btnSendEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSendEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.White;
            this.btnSendEmail.Location = new System.Drawing.Point(690, 950);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(160, 75);
            this.btnSendEmail.TabIndex = 16;
            this.btnSendEmail.Text = "Email Photo";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
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
            this.label3.TabIndex = 17;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnExitPhotoBooth.Location = new System.Drawing.Point(1054, 950);
            this.btnExitPhotoBooth.Name = "btnExitPhotoBooth";
            this.btnExitPhotoBooth.Size = new System.Drawing.Size(160, 75);
            this.btnExitPhotoBooth.TabIndex = 20;
            this.btnExitPhotoBooth.Text = "Exit PhotoBooth";
            this.btnExitPhotoBooth.UseVisualStyleBackColor = false;
            this.btnExitPhotoBooth.Click += new System.EventHandler(this.btnExitPhotoBooth2_Click);
            // 
            // btnSaveToGallery
            // 
            this.btnSaveToGallery.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveToGallery.BackColor = System.Drawing.Color.Gray;
            this.btnSaveToGallery.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveToGallery.FlatAppearance.BorderSize = 2;
            this.btnSaveToGallery.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveToGallery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSaveToGallery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveToGallery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveToGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToGallery.ForeColor = System.Drawing.Color.White;
            this.btnSaveToGallery.Location = new System.Drawing.Point(874, 950);
            this.btnSaveToGallery.Name = "btnSaveToGallery";
            this.btnSaveToGallery.Size = new System.Drawing.Size(160, 75);
            this.btnSaveToGallery.TabIndex = 19;
            this.btnSaveToGallery.Text = "Save To Gallery";
            this.btnSaveToGallery.UseVisualStyleBackColor = false;
            this.btnSaveToGallery.Click += new System.EventHandler(this.btnSaveToGallery_Click);
            // 
            // DisplayBox
            // 
            this.DisplayBox.BackColor = System.Drawing.Color.Transparent;
            this.DisplayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayBox.InitialImage = null;
            this.DisplayBox.Location = new System.Drawing.Point(0, 137);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(1904, 782);
            this.DisplayBox.TabIndex = 18;
            this.DisplayBox.TabStop = false;
            this.DisplayBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DisplayBox_MouseDown);
            this.DisplayBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DisplayBox_MouseMove);
            this.DisplayBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DisplayBox_MouseUp);
            // 
            // toolPhotoEditor
            // 
            this.toolPhotoEditor.AutoSize = false;
            this.toolPhotoEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDraw,
            this.tsbColor});
            this.toolPhotoEditor.Location = new System.Drawing.Point(0, 72);
            this.toolPhotoEditor.Name = "toolPhotoEditor";
            this.toolPhotoEditor.Size = new System.Drawing.Size(1904, 65);
            this.toolPhotoEditor.TabIndex = 21;
            this.toolPhotoEditor.Text = "toolStrip1";
            // 
            // tsbDraw
            // 
            this.tsbDraw.Image = ((System.Drawing.Image)(resources.GetObject("tsbDraw.Image")));
            this.tsbDraw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDraw.Name = "tsbDraw";
            this.tsbDraw.Size = new System.Drawing.Size(86, 62);
            this.tsbDraw.Text = "Draw - OFF";
            this.tsbDraw.Click += new System.EventHandler(this.tsbDraw_Click);
            // 
            // tsbColor
            // 
            this.tsbColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbColor.Image")));
            this.tsbColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColor.Name = "tsbColor";
            this.tsbColor.Size = new System.Drawing.Size(56, 62);
            this.tsbColor.Text = "Color";
            // 
            // PhotoBoothEdit
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.toolPhotoEditor);
            this.Controls.Add(this.btnExitPhotoBooth);
            this.Controls.Add(this.btnSaveToGallery);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "PhotoBoothEdit";
            this.Text = "PhotoBoothEdit";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).EndInit();
            this.toolPhotoEditor.ResumeLayout(false);
            this.toolPhotoEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExitPhotoBooth;
        private System.Windows.Forms.Button btnSaveToGallery;
        private System.Windows.Forms.PictureBox DisplayBox;
        private System.Windows.Forms.ToolStrip toolPhotoEditor;
        private System.Windows.Forms.ToolStripButton tsbDraw;
        private System.Windows.Forms.ToolStripButton tsbColor;
    }
}