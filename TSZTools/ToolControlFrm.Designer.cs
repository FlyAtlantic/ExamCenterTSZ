namespace TSZTools
{
    partial class ToolControlFrm
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
            this.metarsCtrl = new TSZTools.MetarsCtrl();
            this.btnOcenicReport = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMetars = new Bunifu.Framework.UI.BunifuImageButton();
            this.oceanicReportCtrl = new TSZTools.OceanicReportCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcenicReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMetars)).BeginInit();
            this.SuspendLayout();
            // 
            // metarsCtrl
            // 
            this.metarsCtrl.Location = new System.Drawing.Point(2, 2);
            this.metarsCtrl.Name = "metarsCtrl";
            this.metarsCtrl.Size = new System.Drawing.Size(699, 90);
            this.metarsCtrl.TabIndex = 3;
            this.metarsCtrl.Visible = false;
            // 
            // btnOcenicReport
            // 
            this.btnOcenicReport.BackColor = System.Drawing.Color.Transparent;
            this.btnOcenicReport.Image = global::TSZTools.Properties.Resources.noaa_logo_xparent;
            this.btnOcenicReport.ImageActive = null;
            this.btnOcenicReport.Location = new System.Drawing.Point(111, 12);
            this.btnOcenicReport.Name = "btnOcenicReport";
            this.btnOcenicReport.Size = new System.Drawing.Size(71, 71);
            this.btnOcenicReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOcenicReport.TabIndex = 2;
            this.btnOcenicReport.TabStop = false;
            this.btnOcenicReport.Zoom = 10;
            this.btnOcenicReport.Click += new System.EventHandler(this.btnOcenicReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::TSZTools.Properties.Resources.Exit_delete_close_remove_door_logout_out;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(621, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 71);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMetars
            // 
            this.btnMetars.BackColor = System.Drawing.Color.Transparent;
            this.btnMetars.Image = global::TSZTools.Properties.Resources.ir_appsaz_make_android59fda04766f49_d3c4de77_e675_42fc_94d0_92627ca62479;
            this.btnMetars.ImageActive = null;
            this.btnMetars.Location = new System.Drawing.Point(12, 12);
            this.btnMetars.Name = "btnMetars";
            this.btnMetars.Size = new System.Drawing.Size(71, 71);
            this.btnMetars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMetars.TabIndex = 0;
            this.btnMetars.TabStop = false;
            this.btnMetars.Zoom = 10;
            this.btnMetars.Click += new System.EventHandler(this.btnMetars_Click);
            // 
            // oceanicReportCtrl
            // 
            this.oceanicReportCtrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oceanicReportCtrl.Location = new System.Drawing.Point(2, 2);
            this.oceanicReportCtrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oceanicReportCtrl.Name = "oceanicReportCtrl";
            this.oceanicReportCtrl.Size = new System.Drawing.Size(692, 460);
            this.oceanicReportCtrl.TabIndex = 4;
            this.oceanicReportCtrl.Visible = false;
            // 
            // ToolControlFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 473);
            this.Controls.Add(this.oceanicReportCtrl);
            this.Controls.Add(this.metarsCtrl);
            this.Controls.Add(this.btnOcenicReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMetars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolControlFrm";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.btnOcenicReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMetars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnMetars;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnOcenicReport;
        private MetarsCtrl metarsCtrl;
        private OceanicReportCtrl oceanicReportCtrl;
    }
}

