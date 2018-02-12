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
            this.btnAddQuestionMain = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBackAddQst = new Bunifu.Framework.UI.BunifuTileButton();
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
            // btnAddQuestionMain
            // 
            this.btnAddQuestionMain.BackColor = System.Drawing.Color.Transparent;
            this.btnAddQuestionMain.color = System.Drawing.Color.Transparent;
            this.btnAddQuestionMain.colorActive = System.Drawing.Color.Transparent;
            this.btnAddQuestionMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuestionMain.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAddQuestionMain.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddQuestionMain.Image = global::ExamCenterTSZ.Properties.Resources.Files_New_File_icon;
            this.btnAddQuestionMain.ImagePosition = 0;
            this.btnAddQuestionMain.ImageZoom = 100;
            this.btnAddQuestionMain.LabelPosition = 0;
            this.btnAddQuestionMain.LabelText = "";
            this.btnAddQuestionMain.Location = new System.Drawing.Point(499, 3);
            this.btnAddQuestionMain.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddQuestionMain.Name = "btnAddQuestionMain";
            this.btnAddQuestionMain.Size = new System.Drawing.Size(42, 42);
            this.btnAddQuestionMain.TabIndex = 8;
            this.btnAddQuestionMain.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnBackAddQst
            // 
            this.btnBackAddQst.BackColor = System.Drawing.Color.Transparent;
            this.btnBackAddQst.color = System.Drawing.Color.Transparent;
            this.btnBackAddQst.colorActive = System.Drawing.Color.Transparent;
            this.btnBackAddQst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackAddQst.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBackAddQst.ForeColor = System.Drawing.Color.Transparent;
            this.btnBackAddQst.Image = global::ExamCenterTSZ.Properties.Resources.Torchlight_back;
            this.btnBackAddQst.ImagePosition = 0;
            this.btnBackAddQst.ImageZoom = 100;
            this.btnBackAddQst.LabelPosition = 0;
            this.btnBackAddQst.LabelText = "";
            this.btnBackAddQst.Location = new System.Drawing.Point(499, 3);
            this.btnBackAddQst.Margin = new System.Windows.Forms.Padding(6);
            this.btnBackAddQst.Name = "btnBackAddQst";
            this.btnBackAddQst.Size = new System.Drawing.Size(42, 42);
            this.btnBackAddQst.TabIndex = 9;
            this.btnBackAddQst.Visible = false;
            this.btnBackAddQst.Click += new System.EventHandler(this.btnBackAddQst_Click);
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
            this.btnAddQuestion.Location = new System.Drawing.Point(445, 3);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(42, 42);
            this.btnAddQuestion.TabIndex = 11;
            this.btnAddQuestion.Visible = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click_1);
            // 
            // AdminExamCenterCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnBackAddQst);
            this.Controls.Add(this.btnAddQuestionMain);
            this.Controls.Add(this.adminQuestionsGridCtrl);
            this.Controls.Add(this.lblNumQuestions);
            this.Controls.Add(this.cboxExams);
            this.Name = "AdminExamCenterCtrl";
            this.Size = new System.Drawing.Size(986, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblNumQuestions;
        private ExamCenter.AdminQuestionsGridCtrl adminQuestionsGridCtrl;
        public Bunifu.Framework.UI.BunifuTileButton btnAddQuestionMain;
        public System.Windows.Forms.ComboBox cboxExams;
        public Bunifu.Framework.UI.BunifuTileButton btnBackAddQst;
        public Bunifu.Framework.UI.BunifuTileButton btnAddQuestion;
    }
}
