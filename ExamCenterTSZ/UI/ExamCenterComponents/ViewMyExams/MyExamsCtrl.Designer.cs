namespace ExamCenterTSZ.UI.ExamCenterComponents.ViewMyExams
{
    partial class MyExamsCtrl
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
            this.viewMyExamsGridCtrl = new ExamCenterTSZ.UI.ExamCenterComponents.ViewMyExamsGridCtrl();
            this.viewMyExamPageCtrl = new ExamCenterTSZ.UI.ExamCenterComponents.ViewMyExams.ViewMyExamPageCtrl();
            this.SuspendLayout();
            // 
            // viewMyExamsGridCtrl
            // 
            this.viewMyExamsGridCtrl.Location = new System.Drawing.Point(15, 19);
            this.viewMyExamsGridCtrl.Name = "viewMyExamsGridCtrl";
            this.viewMyExamsGridCtrl.Size = new System.Drawing.Size(867, 530);
            this.viewMyExamsGridCtrl.TabIndex = 0;
            // 
            // viewMyExamPageCtrl
            // 
            this.viewMyExamPageCtrl.CurrentQuestion = 0;
            this.viewMyExamPageCtrl.Location = new System.Drawing.Point(3, 19);
            this.viewMyExamPageCtrl.Name = "viewMyExamPageCtrl";
            this.viewMyExamPageCtrl.Size = new System.Drawing.Size(879, 443);
            this.viewMyExamPageCtrl.TabIndex = 1;
            this.viewMyExamPageCtrl.Visible = false;
            // 
            // MyExamsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewMyExamPageCtrl);
            this.Controls.Add(this.viewMyExamsGridCtrl);
            this.Name = "MyExamsCtrl";
            this.Size = new System.Drawing.Size(930, 553);
            this.ResumeLayout(false);

        }

        #endregion
        public ViewMyExamPageCtrl viewMyExamPageCtrl;
        public ViewMyExamsGridCtrl viewMyExamsGridCtrl;
    }
}
