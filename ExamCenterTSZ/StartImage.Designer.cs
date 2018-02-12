namespace ExamCenterTSZ
{
    partial class StartImage
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
            this.imgStartImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgStartImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imgStartImage
            // 
            this.imgStartImage.Image = global::ExamCenterTSZ.Properties.Resources.lg_TSZ;
            this.imgStartImage.Location = new System.Drawing.Point(-1, -2);
            this.imgStartImage.Name = "imgStartImage";
            this.imgStartImage.Size = new System.Drawing.Size(978, 319);
            this.imgStartImage.TabIndex = 0;
            this.imgStartImage.TabStop = false;
            // 
            // StartImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 311);
            this.Controls.Add(this.imgStartImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartImage";
            ((System.ComponentModel.ISupportInitialize)(this.imgStartImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox imgStartImage;
    }
}