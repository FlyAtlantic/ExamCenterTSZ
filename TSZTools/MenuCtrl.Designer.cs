namespace TSZTools
{
    partial class MenuCtrl
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
            this.btnOcenicReport = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMetars = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcenicReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMetars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOcenicReport
            // 
            this.btnOcenicReport.BackColor = System.Drawing.Color.Transparent;
            this.btnOcenicReport.Image = global::TSZTools.Properties.Resources.noaa_logo_xparent;
            this.btnOcenicReport.ImageActive = null;
            this.btnOcenicReport.Location = new System.Drawing.Point(108, 12);
            this.btnOcenicReport.Name = "btnOcenicReport";
            this.btnOcenicReport.Size = new System.Drawing.Size(71, 71);
            this.btnOcenicReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOcenicReport.TabIndex = 5;
            this.btnOcenicReport.TabStop = false;
            this.btnOcenicReport.Zoom = 10;
            this.btnOcenicReport.Click += new System.EventHandler(this.btnOcenicReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::TSZTools.Properties.Resources.Exit_delete_close_remove_door_logout_out;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(618, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 71);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMetars
            // 
            this.btnMetars.BackColor = System.Drawing.Color.Transparent;
            this.btnMetars.Image = global::TSZTools.Properties.Resources.ir_appsaz_make_android59fda04766f49_d3c4de77_e675_42fc_94d0_92627ca62479;
            this.btnMetars.ImageActive = null;
            this.btnMetars.Location = new System.Drawing.Point(9, 12);
            this.btnMetars.Name = "btnMetars";
            this.btnMetars.Size = new System.Drawing.Size(71, 71);
            this.btnMetars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMetars.TabIndex = 3;
            this.btnMetars.TabStop = false;
            this.btnMetars.Zoom = 10;
            this.btnMetars.Click += new System.EventHandler(this.btnMetars_Click);
            // 
            // MenuCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOcenicReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMetars);
            this.Name = "MenuCtrl";
            this.Size = new System.Drawing.Size(697, 95);
            ((System.ComponentModel.ISupportInitialize)(this.btnOcenicReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMetars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnOcenicReport;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMetars;
    }
}
