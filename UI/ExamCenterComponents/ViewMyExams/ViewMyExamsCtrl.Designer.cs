namespace ExamCenterTSZ.UI.ExamCenterComponents
{
    partial class ViewMyExamsCtrl
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
            this.SuspendLayout();
            // 
            // viewMyExamsGridCtrl
            // 
            this.viewMyExamsGridCtrl.Location = new System.Drawing.Point(0, 0);
            this.viewMyExamsGridCtrl.Name = "viewMyExamsGridCtrl";
            this.viewMyExamsGridCtrl.Size = new System.Drawing.Size(717, 530);
            this.viewMyExamsGridCtrl.TabIndex = 0;
            // 
            // ViewMyExamsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewMyExamsGridCtrl);
            this.Name = "ViewMyExamsCtrl";
            this.Size = new System.Drawing.Size(720, 535);
            this.ResumeLayout(false);

        }

        #endregion

        private ViewMyExamsGridCtrl viewMyExamsGridCtrl1;
        private ViewMyExamsGridCtrl viewMyExamsGridCtrl;
    }
}
