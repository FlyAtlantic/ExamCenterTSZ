namespace ExamCenterTSZ.UI.AdminPanel.ExamCenter
{
    partial class AdminEditAnswer
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
            this.txtEditAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboxAnswer
            // 
            this.cboxAnswer.AutoSize = true;
            this.cboxAnswer.Enabled = false;
            this.cboxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cboxAnswer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboxAnswer.Location = new System.Drawing.Point(3, 3);
            this.cboxAnswer.Name = "cboxAnswer";
            this.cboxAnswer.Size = new System.Drawing.Size(84, 19);
            this.cboxAnswer.TabIndex = 18;
            this.cboxAnswer.Text = "Awnser 1";
            this.cboxAnswer.UseVisualStyleBackColor = true;
            this.cboxAnswer.Click += new System.EventHandler(this.cboxAnswer_Click);
            // 
            // txtEditAnswer
            // 
            this.txtEditAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditAnswer.Location = new System.Drawing.Point(21, 1);
            this.txtEditAnswer.Multiline = true;
            this.txtEditAnswer.Name = "txtEditAnswer";
            this.txtEditAnswer.Size = new System.Drawing.Size(636, 37);
            this.txtEditAnswer.TabIndex = 19;
            // 
            // AdminEditAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEditAnswer);
            this.Controls.Add(this.cboxAnswer);
            this.Name = "AdminEditAnswer";
            this.Size = new System.Drawing.Size(660, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox cboxAnswer;
        public System.Windows.Forms.TextBox txtEditAnswer;
    }
}
