namespace ExamCenterTSZ.UI.ExamCenterInstructor
{
    partial class FindExam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindExam));
            this.btnFindExam = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.SuspendLayout();
            // 
            // btnFindExam
            // 
            this.btnFindExam.BackColor = System.Drawing.Color.Transparent;
            this.btnFindExam.color = System.Drawing.Color.Transparent;
            this.btnFindExam.colorActive = System.Drawing.Color.Transparent;
            this.btnFindExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindExam.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnFindExam.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindExam.Image = global::ExamCenterTSZ.Properties.Resources.search_find_seek_icon;
            this.btnFindExam.ImagePosition = 0;
            this.btnFindExam.ImageZoom = 110;
            this.btnFindExam.LabelPosition = 0;
            this.btnFindExam.LabelText = "";
            this.btnFindExam.Location = new System.Drawing.Point(175, 0);
            this.btnFindExam.Margin = new System.Windows.Forms.Padding(6);
            this.btnFindExam.Name = "btnFindExam";
            this.btnFindExam.Size = new System.Drawing.Size(42, 42);
            this.btnFindExam.TabIndex = 3;
            this.btnFindExam.Click += new System.EventHandler(this.btnFindExam_Click);
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(166, 42);
            this.bunifuTextbox1.TabIndex = 0;
            this.bunifuTextbox1.text = "Bunifu TextBox";
            // 
            // FindExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindExam);
            this.Controls.Add(this.bunifuTextbox1);
            this.Name = "FindExam";
            this.Size = new System.Drawing.Size(223, 42);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuTileButton btnFindExam;
    }
}
