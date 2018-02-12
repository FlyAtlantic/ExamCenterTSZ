namespace ExamCenterTSZ.UI.ExamCenterComponents.ViewMyExams
{
    partial class MyQuestionCtrl
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
            this.fpImgQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.fpAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fpImgQuestions
            // 
            this.fpImgQuestions.Location = new System.Drawing.Point(509, 7);
            this.fpImgQuestions.Name = "fpImgQuestions";
            this.fpImgQuestions.Size = new System.Drawing.Size(288, 175);
            this.fpImgQuestions.TabIndex = 29;
            // 
            // fpAnswers
            // 
            this.fpAnswers.Location = new System.Drawing.Point(27, 186);
            this.fpAnswers.Name = "fpAnswers";
            this.fpAnswers.Size = new System.Drawing.Size(770, 139);
            this.fpAnswers.TabIndex = 28;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(27, 7);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(476, 91);
            this.txtQuestion.TabIndex = 27;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblQuestion.Location = new System.Drawing.Point(3, 5);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(27, 20);
            this.lblQuestion.TabIndex = 26;
            this.lblQuestion.Text = "Q:";
            // 
            // MyQuestionCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpImgQuestions);
            this.Controls.Add(this.fpAnswers);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Name = "MyQuestionCtrl";
            this.Size = new System.Drawing.Size(800, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpImgQuestions;
        private System.Windows.Forms.FlowLayoutPanel fpAnswers;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblQuestion;
    }
}
