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
            this.btnAddQuestion = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // cboxExams
            // 
            this.cboxExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxExams.FormattingEnabled = true;
            this.cboxExams.Location = new System.Drawing.Point(12, 14);
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
            this.lblNumQuestions.Location = new System.Drawing.Point(168, 17);
            this.lblNumQuestions.Name = "lblNumQuestions";
            this.lblNumQuestions.Size = new System.Drawing.Size(51, 16);
            this.lblNumQuestions.TabIndex = 4;
            this.lblNumQuestions.Text = "label1";
            // 
            // adminQuestionsGridCtrl
            // 
            this.adminQuestionsGridCtrl.Location = new System.Drawing.Point(13, 54);
            this.adminQuestionsGridCtrl.Name = "adminQuestionsGridCtrl";
            this.adminQuestionsGridCtrl.Size = new System.Drawing.Size(888, 471);
            this.adminQuestionsGridCtrl.TabIndex = 5;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btnAddQuestion.color = System.Drawing.Color.Transparent;
            this.btnAddQuestion.colorActive = System.Drawing.Color.Transparent;
            this.btnAddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuestion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAddQuestion.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddQuestion.Image = global::ExamCenterTSZ.Properties.Resources.Files_New_File_icon;
            this.btnAddQuestion.ImagePosition = 0;
            this.btnAddQuestion.ImageZoom = 100;
            this.btnAddQuestion.LabelPosition = 0;
            this.btnAddQuestion.LabelText = "";
            this.btnAddQuestion.Location = new System.Drawing.Point(499, 3);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(42, 42);
            this.btnAddQuestion.TabIndex = 8;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // AdminExamCenterCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddQuestion);
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
        public Bunifu.Framework.UI.BunifuTileButton btnAddQuestion;
    }
}
