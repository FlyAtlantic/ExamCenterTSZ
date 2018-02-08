namespace ExamCenterTSZ.UI.ExamCenterComponents
{
    partial class ProcessExam
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
            this.btnCntFinish = new System.Windows.Forms.Button();
            this.lblFinishApproved = new System.Windows.Forms.Label();
            this.lblFinishRejected = new System.Windows.Forms.Label();
            this.txtLoadingStandby = new System.Windows.Forms.TextBox();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.Loading = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCntFinish
            // 
            this.btnCntFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCntFinish.Location = new System.Drawing.Point(204, 163);
            this.btnCntFinish.Name = "btnCntFinish";
            this.btnCntFinish.Size = new System.Drawing.Size(130, 28);
            this.btnCntFinish.TabIndex = 31;
            this.btnCntFinish.Text = "Continue";
            this.btnCntFinish.UseVisualStyleBackColor = true;
            this.btnCntFinish.Visible = false;
            this.btnCntFinish.Click += new System.EventHandler(this.btnCntFinish_Click);
            // 
            // lblFinishApproved
            // 
            this.lblFinishApproved.AutoSize = true;
            this.lblFinishApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinishApproved.ForeColor = System.Drawing.Color.Green;
            this.lblFinishApproved.Location = new System.Drawing.Point(178, 77);
            this.lblFinishApproved.Name = "lblFinishApproved";
            this.lblFinishApproved.Size = new System.Drawing.Size(182, 20);
            this.lblFinishApproved.TabIndex = 30;
            this.lblFinishApproved.Text = "Approved with 100% !";
            this.lblFinishApproved.Visible = false;
            // 
            // lblFinishRejected
            // 
            this.lblFinishRejected.AutoSize = true;
            this.lblFinishRejected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinishRejected.ForeColor = System.Drawing.Color.Red;
            this.lblFinishRejected.Location = new System.Drawing.Point(185, 80);
            this.lblFinishRejected.Name = "lblFinishRejected";
            this.lblFinishRejected.Size = new System.Drawing.Size(168, 20);
            this.lblFinishRejected.TabIndex = 29;
            this.lblFinishRejected.Text = "Rejected with 50% !";
            this.lblFinishRejected.Visible = false;
            // 
            // txtLoadingStandby
            // 
            this.txtLoadingStandby.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoadingStandby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtLoadingStandby.ForeColor = System.Drawing.Color.Green;
            this.txtLoadingStandby.Location = new System.Drawing.Point(3, 74);
            this.txtLoadingStandby.Name = "txtLoadingStandby";
            this.txtLoadingStandby.ReadOnly = true;
            this.txtLoadingStandby.Size = new System.Drawing.Size(532, 19);
            this.txtLoadingStandby.TabIndex = 28;
            this.txtLoadingStandby.Text = "Your exam is being reviewed";
            this.txtLoadingStandby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadingBar
            // 
            this.LoadingBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingBar.Location = new System.Drawing.Point(80, 119);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(381, 25);
            this.LoadingBar.TabIndex = 33;
            // 
            // Loading
            // 
            this.Loading.Interval = 50;
            this.Loading.Tick += new System.EventHandler(this.Loading_Tick);
            // 
            // ProcessExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.btnCntFinish);
            this.Controls.Add(this.lblFinishApproved);
            this.Controls.Add(this.lblFinishRejected);
            this.Controls.Add(this.txtLoadingStandby);
            this.Name = "ProcessExam";
            this.Size = new System.Drawing.Size(541, 262);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCntFinish;
        private System.Windows.Forms.Label lblFinishApproved;
        private System.Windows.Forms.Label lblFinishRejected;
        private System.Windows.Forms.TextBox txtLoadingStandby;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Timer Loading;
    }
}
