namespace ExamCenterTSZ.UI.ExamCenterComponents
{
    partial class AnswerCtrl
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
            this.cboxAnswer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cboxAnswer
            // 
            this.cboxAnswer.AutoSize = true;
            this.cboxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cboxAnswer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboxAnswer.Location = new System.Drawing.Point(3, 3);
            this.cboxAnswer.Name = "cboxAnswer";
            this.cboxAnswer.Size = new System.Drawing.Size(84, 19);
            this.cboxAnswer.TabIndex = 15;
            this.cboxAnswer.Text = "Awnser 1";
            this.cboxAnswer.UseVisualStyleBackColor = true;
            this.cboxAnswer.CheckedChanged += new System.EventHandler(this.cboxAnswer_CheckedChanged);
            // 
            // AnswerCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboxAnswer);
            this.Name = "AnswerCtrl";
            this.Size = new System.Drawing.Size(660, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox cboxAnswer;
    }
}
