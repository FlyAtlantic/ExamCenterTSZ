namespace ExamCenterTSZ.UI.ExamCenterComponents
{
    partial class FinishExam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishExam));
            this.lblFinishApproved = new System.Windows.Forms.Label();
            this.lblFinishRejected = new System.Windows.Forms.Label();
            this.txtLoadingStandby = new System.Windows.Forms.TextBox();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.btnCntFinishExam = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Loading = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblFinishApproved
            // 
            this.lblFinishApproved.AutoSize = true;
            this.lblFinishApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinishApproved.ForeColor = System.Drawing.Color.Green;
            this.lblFinishApproved.Location = new System.Drawing.Point(207, 70);
            this.lblFinishApproved.Name = "lblFinishApproved";
            this.lblFinishApproved.Size = new System.Drawing.Size(90, 20);
            this.lblFinishApproved.TabIndex = 14;
            this.lblFinishApproved.Text = "Approved!";
            this.lblFinishApproved.Visible = false;
            // 
            // lblFinishRejected
            // 
            this.lblFinishRejected.AutoSize = true;
            this.lblFinishRejected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinishRejected.ForeColor = System.Drawing.Color.Red;
            this.lblFinishRejected.Location = new System.Drawing.Point(209, 73);
            this.lblFinishRejected.Name = "lblFinishRejected";
            this.lblFinishRejected.Size = new System.Drawing.Size(86, 20);
            this.lblFinishRejected.TabIndex = 13;
            this.lblFinishRejected.Text = "Rejected!";
            this.lblFinishRejected.Visible = false;
            // 
            // txtLoadingStandby
            // 
            this.txtLoadingStandby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtLoadingStandby.ForeColor = System.Drawing.Color.Green;
            this.txtLoadingStandby.Location = new System.Drawing.Point(-24, 67);
            this.txtLoadingStandby.Name = "txtLoadingStandby";
            this.txtLoadingStandby.ReadOnly = true;
            this.txtLoadingStandby.Size = new System.Drawing.Size(532, 26);
            this.txtLoadingStandby.TabIndex = 12;
            this.txtLoadingStandby.Text = "Your exam is being reviewed";
            this.txtLoadingStandby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadingBar
            // 
            this.LoadingBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingBar.Location = new System.Drawing.Point(53, 113);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(378, 23);
            this.LoadingBar.TabIndex = 10;
            // 
            // btnCntFinishExam
            // 
            this.btnCntFinishExam.ActiveBorderThickness = 1;
            this.btnCntFinishExam.ActiveCornerRadius = 20;
            this.btnCntFinishExam.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCntFinishExam.ActiveForecolor = System.Drawing.Color.White;
            this.btnCntFinishExam.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCntFinishExam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCntFinishExam.BackColor = System.Drawing.SystemColors.Control;
            this.btnCntFinishExam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCntFinishExam.BackgroundImage")));
            this.btnCntFinishExam.ButtonText = "Continue";
            this.btnCntFinishExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCntFinishExam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCntFinishExam.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCntFinishExam.IdleBorderThickness = 1;
            this.btnCntFinishExam.IdleCornerRadius = 20;
            this.btnCntFinishExam.IdleFillColor = System.Drawing.Color.White;
            this.btnCntFinishExam.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCntFinishExam.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCntFinishExam.Location = new System.Drawing.Point(152, 153);
            this.btnCntFinishExam.Margin = new System.Windows.Forms.Padding(5);
            this.btnCntFinishExam.Name = "btnCntFinishExam";
            this.btnCntFinishExam.Size = new System.Drawing.Size(181, 41);
            this.btnCntFinishExam.TabIndex = 11;
            this.btnCntFinishExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCntFinishExam.Visible = false;
            // 
            // Loading
            // 
            this.Loading.Interval = 50;
            this.Loading.Tick += new System.EventHandler(this.Loading_Tick);
            // 
            // FinishExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFinishApproved);
            this.Controls.Add(this.lblFinishRejected);
            this.Controls.Add(this.txtLoadingStandby);
            this.Controls.Add(this.btnCntFinishExam);
            this.Controls.Add(this.LoadingBar);
            this.Name = "FinishExam";
            this.Size = new System.Drawing.Size(485, 261);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinishApproved;
        private System.Windows.Forms.Label lblFinishRejected;
        private System.Windows.Forms.TextBox txtLoadingStandby;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCntFinishExam;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Timer Loading;
    }
}
