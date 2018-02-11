namespace ExamCenterTSZ.UI.ExamCenterComponents
{
    partial class EpsConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EpsConfirm));
            this.txtEpsInfo = new System.Windows.Forms.TextBox();
            this.lblSureQst = new System.Windows.Forms.Label();
            this.btnYes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtExamInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEpsInfo
            // 
            this.txtEpsInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEpsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpsInfo.Location = new System.Drawing.Point(-1, 86);
            this.txtEpsInfo.Name = "txtEpsInfo";
            this.txtEpsInfo.ReadOnly = true;
            this.txtEpsInfo.Size = new System.Drawing.Size(552, 19);
            this.txtEpsInfo.TabIndex = 0;
            this.txtEpsInfo.Text = "Will be removed 50ep\'s from your account to begin the exam.";
            this.txtEpsInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSureQst
            // 
            this.lblSureQst.AutoSize = true;
            this.lblSureQst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSureQst.ForeColor = System.Drawing.Color.Red;
            this.lblSureQst.Location = new System.Drawing.Point(173, 117);
            this.lblSureQst.Name = "lblSureQst";
            this.lblSureQst.Size = new System.Drawing.Size(201, 18);
            this.lblSureQst.TabIndex = 1;
            this.lblSureQst.Text = "Are you sure to continue?";
            // 
            // btnYes
            // 
            this.btnYes.ActiveBorderThickness = 1;
            this.btnYes.ActiveCornerRadius = 20;
            this.btnYes.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnYes.ActiveForecolor = System.Drawing.Color.White;
            this.btnYes.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnYes.BackColor = System.Drawing.SystemColors.Control;
            this.btnYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYes.BackgroundImage")));
            this.btnYes.ButtonText = "Yes";
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnYes.IdleBorderThickness = 1;
            this.btnYes.IdleCornerRadius = 20;
            this.btnYes.IdleFillColor = System.Drawing.Color.White;
            this.btnYes.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnYes.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnYes.Location = new System.Drawing.Point(58, 140);
            this.btnYes.Margin = new System.Windows.Forms.Padding(5);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(181, 41);
            this.btnYes.TabIndex = 2;
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.ActiveBorderThickness = 1;
            this.btnNo.ActiveCornerRadius = 20;
            this.btnNo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNo.ActiveForecolor = System.Drawing.Color.White;
            this.btnNo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNo.BackgroundImage")));
            this.btnNo.ButtonText = "No";
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNo.IdleBorderThickness = 1;
            this.btnNo.IdleCornerRadius = 20;
            this.btnNo.IdleFillColor = System.Drawing.Color.White;
            this.btnNo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNo.Location = new System.Drawing.Point(311, 140);
            this.btnNo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(181, 41);
            this.btnNo.TabIndex = 3;
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // txtExamInfo
            // 
            this.txtExamInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExamInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtExamInfo.Location = new System.Drawing.Point(-1, 61);
            this.txtExamInfo.Name = "txtExamInfo";
            this.txtExamInfo.ReadOnly = true;
            this.txtExamInfo.Size = new System.Drawing.Size(552, 19);
            this.txtExamInfo.TabIndex = 4;
            this.txtExamInfo.Text = "This exam has 30 questions and you have 60 minutes to complete it.";
            this.txtExamInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EpsConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtEpsInfo);
            this.Controls.Add(this.txtExamInfo);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblSureQst);
            this.Name = "EpsConfirm";
            this.Size = new System.Drawing.Size(550, 260);
            this.Load += new System.EventHandler(this.EpsConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEpsInfo;
        private System.Windows.Forms.Label lblSureQst;
        private Bunifu.Framework.UI.BunifuThinButton2 btnYes;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNo;
        private System.Windows.Forms.TextBox txtExamInfo;
    }
}
