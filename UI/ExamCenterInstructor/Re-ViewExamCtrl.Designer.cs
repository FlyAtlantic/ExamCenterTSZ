namespace ExamCenterTSZ.UI.ExamCenterInstructor
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultTxt = new System.Windows.Forms.Label();
            this.lblCountQuestions = new System.Windows.Forms.Label();
            this.lastQuestionCtrl = new ExamCenterTSZ.UI.ExamCenterInstructor.LastQuestionCtrl();
            this.lblPilot = new System.Windows.Forms.Label();
            this.lblPilotText = new System.Windows.Forms.Label();
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
            this.btnFinish.LabelText = "Close";
            this.btnFinish.Location = new System.Drawing.Point(270, 388);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(106, 48);
            this.btnFinish.TabIndex = 116;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
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
            this.btnNext.Click += new System.EventHandler(this.btnNextQuestion_Click);
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
            this.btnPrevious.Visible = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPreviousQuestion_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblResult.Location = new System.Drawing.Point(679, 36);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(56, 16);
            this.lblResult.TabIndex = 113;
            this.lblResult.Text = "Result:";
            // 
            // lblResultTxt
            // 
            this.lblResultTxt.AutoSize = true;
            this.lblResultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResultTxt.ForeColor = System.Drawing.Color.Firebrick;
            this.lblResultTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblResultTxt.Location = new System.Drawing.Point(730, 36);
            this.lblResultTxt.Name = "lblResultTxt";
            this.lblResultTxt.Size = new System.Drawing.Size(45, 16);
            this.lblResultTxt.TabIndex = 112;
            this.lblResultTxt.Text = "100%";
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
            // lastQuestionCtrl
            // 
            this.lastQuestionCtrl.CheckBoxSelected = null;
            this.lastQuestionCtrl.CheckPossibleSelect = null;
            this.lastQuestionCtrl.Location = new System.Drawing.Point(8, 55);
            this.lastQuestionCtrl.Name = "lastQuestionCtrl";
            this.lastQuestionCtrl.Size = new System.Drawing.Size(796, 325);
            this.lastQuestionCtrl.TabIndex = 118;
            // 
            // lblPilot
            // 
            this.lblPilot.AutoSize = true;
            this.lblPilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPilot.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPilot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPilot.Location = new System.Drawing.Point(679, 16);
            this.lblPilot.Name = "lblPilot";
            this.lblPilot.Size = new System.Drawing.Size(43, 16);
            this.lblPilot.TabIndex = 120;
            this.lblPilot.Text = "Pilot:";
            // 
            // lblPilotText
            // 
            this.lblPilotText.AutoSize = true;
            this.lblPilotText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPilotText.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPilotText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPilotText.Location = new System.Drawing.Point(719, 16);
            this.lblPilotText.Name = "lblPilotText";
            this.lblPilotText.Size = new System.Drawing.Size(105, 16);
            this.lblPilotText.TabIndex = 119;
            this.lblPilotText.Text = "Tiago Vicente";
            // 
            // Re_ViewExamCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResultTxt);
            this.Controls.Add(this.lblPilot);
            this.Controls.Add(this.lblPilotText);
            this.Controls.Add(this.lastQuestionCtrl);
            this.Controls.Add(this.pBarProgress);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCountQuestions);
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
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultTxt;
        private System.Windows.Forms.Label lblCountQuestions;
        private ExamCenterComponents.QuestionCtrl qstControl;
        private LastQuestionCtrl lastQuestionCtrl;
        private System.Windows.Forms.Label lblPilot;
        private System.Windows.Forms.Label lblPilotText;
    }
}
