namespace ExamCenterTSZ.UI.ExamCenterInstructor
{
    partial class ExamInstructorCtrl
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
            this.re_ViewExamCtrl = new ExamCenterTSZ.UI.ExamCenterInstructor.Re_ViewExamCtrl();
            this.findExam1 = new ExamCenterTSZ.UI.ExamCenterInstructor.FindExam();
            this.SuspendLayout();
            // 
            // re_ViewExamCtrl
            // 
            this.re_ViewExamCtrl.CurrentQuestion = 0;
            this.re_ViewExamCtrl.Location = new System.Drawing.Point(3, 51);
            this.re_ViewExamCtrl.Name = "re_ViewExamCtrl";
            this.re_ViewExamCtrl.Size = new System.Drawing.Size(879, 440);
            this.re_ViewExamCtrl.TabIndex = 1;
            this.re_ViewExamCtrl.Visible = false;
            // 
            // findExam1
            // 
            this.findExam1.Location = new System.Drawing.Point(69, 3);
            this.findExam1.Name = "findExam1";
            this.findExam1.Size = new System.Drawing.Size(338, 42);
            this.findExam1.TabIndex = 2;
            // 
            // ExamInstructorCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.findExam1);
            this.Controls.Add(this.re_ViewExamCtrl);
            this.Name = "ExamInstructorCtrl";
            this.Size = new System.Drawing.Size(882, 494);
            this.ResumeLayout(false);

        }

        #endregion
        public Re_ViewExamCtrl re_ViewExamCtrl;
        private FindExam findExam1;
    }
}
