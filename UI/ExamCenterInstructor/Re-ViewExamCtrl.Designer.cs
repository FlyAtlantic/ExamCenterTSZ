﻿namespace ExamCenterTSZ.UI.ExamCenterInstructor
{
    partial class Re_ViewExamCtrl
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
            this.pBarProgress = new Bunifu.Framework.UI.BunifuProgressBar();
            this.btnFinish = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnNext = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblClockText = new System.Windows.Forms.Label();
            this.lblCountTime = new System.Windows.Forms.Label();
            this.lblCountQuestions = new System.Windows.Forms.Label();
            this.qstControl = new ExamCenterTSZ.UI.ExamCenterComponents.QuestionCtrl();
            this.SuspendLayout();
            // 
            // pBarProgress
            // 
            this.pBarProgress.BackColor = System.Drawing.Color.Silver;
            this.pBarProgress.BorderRadius = 5;
            this.pBarProgress.Location = new System.Drawing.Point(195, 16);
            this.pBarProgress.MaximumValue = 100;
            this.pBarProgress.Name = "pBarProgress";
            this.pBarProgress.ProgressColor = System.Drawing.Color.Teal;
            this.pBarProgress.Size = new System.Drawing.Size(450, 18);
            this.pBarProgress.TabIndex = 117;
            this.pBarProgress.Value = 0;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Firebrick;
            this.btnFinish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnFinish.color = System.Drawing.Color.Firebrick;
            this.btnFinish.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFinish.Image = null;
            this.btnFinish.ImagePosition = 16;
            this.btnFinish.ImageZoom = 50;
            this.btnFinish.LabelPosition = 33;
            this.btnFinish.LabelText = "Send";
            this.btnFinish.Location = new System.Drawing.Point(270, 388);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(106, 48);
            this.btnFinish.TabIndex = 116;
            this.btnFinish.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnNext.color = System.Drawing.Color.SeaGreen;
            this.btnNext.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = null;
            this.btnNext.ImagePosition = 18;
            this.btnNext.ImageZoom = 50;
            this.btnNext.LabelPosition = 36;
            this.btnNext.LabelText = "Next >>";
            this.btnNext.Location = new System.Drawing.Point(154, 388);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 48);
            this.btnNext.TabIndex = 115;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrevious.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnPrevious.color = System.Drawing.Color.SeaGreen;
            this.btnPrevious.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.Image = null;
            this.btnPrevious.ImagePosition = 18;
            this.btnPrevious.ImageZoom = 50;
            this.btnPrevious.LabelPosition = 36;
            this.btnPrevious.LabelText = "<< Previous";
            this.btnPrevious.Location = new System.Drawing.Point(37, 388);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(107, 48);
            this.btnPrevious.TabIndex = 114;
            // 
            // lblClockText
            // 
            this.lblClockText.AutoSize = true;
            this.lblClockText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblClockText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblClockText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblClockText.Location = new System.Drawing.Point(704, 18);
            this.lblClockText.Name = "lblClockText";
            this.lblClockText.Size = new System.Drawing.Size(104, 16);
            this.lblClockText.TabIndex = 113;
            this.lblClockText.Text = "Time to finish:";
            // 
            // lblCountTime
            // 
            this.lblCountTime.AutoSize = true;
            this.lblCountTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCountTime.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCountTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCountTime.Location = new System.Drawing.Point(804, 18);
            this.lblCountTime.Name = "lblCountTime";
            this.lblCountTime.Size = new System.Drawing.Size(64, 16);
            this.lblCountTime.TabIndex = 112;
            this.lblCountTime.Text = "00:00:00";
            // 
            // lblCountQuestions
            // 
            this.lblCountQuestions.AutoSize = true;
            this.lblCountQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountQuestions.Location = new System.Drawing.Point(5, 16);
            this.lblCountQuestions.Name = "lblCountQuestions";
            this.lblCountQuestions.Size = new System.Drawing.Size(142, 18);
            this.lblCountQuestions.TabIndex = 111;
            this.lblCountQuestions.Text = "Question 20 of 20";
            // 
            // qstControl
            // 
            this.qstControl.CheckBoxSelected = null;
            this.qstControl.CheckPossibleSelect = null;
            this.qstControl.Location = new System.Drawing.Point(3, 50);
            this.qstControl.Name = "qstControl";
            this.qstControl.Size = new System.Drawing.Size(800, 330);
            this.qstControl.TabIndex = 110;
            // 
            // Re_ViewExamCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pBarProgress);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblClockText);
            this.Controls.Add(this.lblCountTime);
            this.Controls.Add(this.lblCountQuestions);
            this.Controls.Add(this.qstControl);
            this.Name = "Re_ViewExamCtrl";
            this.Size = new System.Drawing.Size(879, 443);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar pBarProgress;
        private Bunifu.Framework.UI.BunifuTileButton btnFinish;
        private Bunifu.Framework.UI.BunifuTileButton btnNext;
        private Bunifu.Framework.UI.BunifuTileButton btnPrevious;
        private System.Windows.Forms.Label lblClockText;
        private System.Windows.Forms.Label lblCountTime;
        private System.Windows.Forms.Label lblCountQuestions;
        private ExamCenterComponents.QuestionCtrl qstControl;
    }
}