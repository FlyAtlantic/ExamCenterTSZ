namespace ExamCenterTSZ.UI.AdminPanel.ExamCenter
{
    partial class AdminManageQuestions
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
            this.adminQuestionCtrl = new ExamCenterTSZ.UI.AdminPanel.ExamCenter.AdminQuestionCtrl();
            this.btnBackEdit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEditQuestion = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // adminQuestionCtrl
            // 
            this.adminQuestionCtrl.Location = new System.Drawing.Point(0, 3);
            this.adminQuestionCtrl.Name = "adminQuestionCtrl";
            this.adminQuestionCtrl.Size = new System.Drawing.Size(796, 404);
            this.adminQuestionCtrl.TabIndex = 0;
            // 
            // btnBackEdit
            // 
            this.btnBackEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnBackEdit.color = System.Drawing.Color.Transparent;
            this.btnBackEdit.colorActive = System.Drawing.Color.Transparent;
            this.btnBackEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBackEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnBackEdit.Image = global::ExamCenterTSZ.Properties.Resources.Torchlight_back;
            this.btnBackEdit.ImagePosition = 0;
            this.btnBackEdit.ImageZoom = 100;
            this.btnBackEdit.LabelPosition = 0;
            this.btnBackEdit.LabelText = "";
            this.btnBackEdit.Location = new System.Drawing.Point(25, 416);
            this.btnBackEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnBackEdit.Name = "btnBackEdit";
            this.btnBackEdit.Size = new System.Drawing.Size(42, 42);
            this.btnBackEdit.TabIndex = 5;
            this.btnBackEdit.Visible = false;
            this.btnBackEdit.Click += new System.EventHandler(this.btnBackEdit_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btnEditQuestion.color = System.Drawing.Color.Transparent;
            this.btnEditQuestion.colorActive = System.Drawing.Color.Transparent;
            this.btnEditQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditQuestion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnEditQuestion.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditQuestion.Image = global::ExamCenterTSZ.Properties.Resources.document_edit;
            this.btnEditQuestion.ImagePosition = 0;
            this.btnEditQuestion.ImageZoom = 110;
            this.btnEditQuestion.LabelPosition = 0;
            this.btnEditQuestion.LabelText = "";
            this.btnEditQuestion.Location = new System.Drawing.Point(25, 416);
            this.btnEditQuestion.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(42, 42);
            this.btnEditQuestion.TabIndex = 4;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // AdminManageQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBackEdit);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.adminQuestionCtrl);
            this.Name = "AdminManageQuestions";
            this.Size = new System.Drawing.Size(859, 467);
            this.ResumeLayout(false);

        }

        #endregion
        public AdminQuestionCtrl adminQuestionCtrl;
        public Bunifu.Framework.UI.BunifuTileButton btnEditQuestion;
        public Bunifu.Framework.UI.BunifuTileButton btnBackEdit;
    }
}
