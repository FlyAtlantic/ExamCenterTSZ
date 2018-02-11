namespace ExamCenterTSZ.UI.AdminPanel
{
    partial class AdminExamCenterCtrl
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
            this.cboxExams = new System.Windows.Forms.ComboBox();
            this.lblNumQuestions = new System.Windows.Forms.Label();
            this.adminQuestionsGridCtrl = new ExamCenterTSZ.UI.AdminPanel.ExamCenter.AdminQuestionsGridCtrl();
            this.SuspendLayout();
            // 
            // cboxExams
            // 
            this.cboxExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxExams.FormattingEnabled = true;
            this.cboxExams.Location = new System.Drawing.Point(13, 3);
            this.cboxExams.Name = "cboxExams";
            this.cboxExams.Size = new System.Drawing.Size(121, 24);
            this.cboxExams.TabIndex = 3;
            this.cboxExams.SelectedIndexChanged += new System.EventHandler(this.cboxExams_SelectedIndexChanged);
            // 
            // lblNumQuestions
            // 
            this.lblNumQuestions.AutoSize = true;
            this.lblNumQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumQuestions.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumQuestions.Location = new System.Drawing.Point(169, 6);
            this.lblNumQuestions.Name = "lblNumQuestions";
            this.lblNumQuestions.Size = new System.Drawing.Size(51, 16);
            this.lblNumQuestions.TabIndex = 4;
            this.lblNumQuestions.Text = "label1";
            // 
            // adminQuestionsGridCtrl
            // 
            this.adminQuestionsGridCtrl.Location = new System.Drawing.Point(13, 33);
            this.adminQuestionsGridCtrl.Name = "adminQuestionsGridCtrl";
            this.adminQuestionsGridCtrl.Size = new System.Drawing.Size(903, 492);
            this.adminQuestionsGridCtrl.TabIndex = 5;
            // 
            // AdminExamCenterCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminQuestionsGridCtrl);
            this.Controls.Add(this.lblNumQuestions);
            this.Controls.Add(this.cboxExams);
            this.Name = "AdminExamCenterCtrl";
            this.Size = new System.Drawing.Size(986, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxExams;
        public System.Windows.Forms.Label lblNumQuestions;
        private ExamCenter.AdminQuestionsGridCtrl adminQuestionsGridCtrl;
    }
}
