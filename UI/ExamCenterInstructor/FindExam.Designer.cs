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
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnAdminPanel = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
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
            // btnAdminPanel
            // 
            this.btnAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminPanel.color = System.Drawing.Color.Transparent;
            this.btnAdminPanel.colorActive = System.Drawing.Color.Transparent;
            this.btnAdminPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminPanel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAdminPanel.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdminPanel.Image = global::ExamCenterTSZ.Properties.Resources.search_find_seek_icon;
            this.btnAdminPanel.ImagePosition = 0;
            this.btnAdminPanel.ImageZoom = 110;
            this.btnAdminPanel.LabelPosition = 0;
            this.btnAdminPanel.LabelText = "";
            this.btnAdminPanel.Location = new System.Drawing.Point(175, 0);
            this.btnAdminPanel.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(42, 42);
            this.btnAdminPanel.TabIndex = 3;
            // 
            // FindExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.bunifuTextbox1);
            this.Name = "FindExam";
            this.Size = new System.Drawing.Size(223, 42);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuTileButton btnAdminPanel;
    }
}
