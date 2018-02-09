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
            this.findExam1 = new ExamCenterTSZ.UI.ExamCenterInstructor.FindExam();
            this.SuspendLayout();
            // 
            // findExam1
            // 
            this.findExam1.Location = new System.Drawing.Point(109, 3);
            this.findExam1.Name = "findExam1";
            this.findExam1.Size = new System.Drawing.Size(223, 42);
            this.findExam1.TabIndex = 0;
            // 
            // ExamInstructorCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.findExam1);
            this.Name = "ExamInstructorCtrl";
            this.Size = new System.Drawing.Size(882, 460);
            this.ResumeLayout(false);

        }

        #endregion

        private FindExam findExam1;
    }
}
