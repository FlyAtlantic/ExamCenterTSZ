namespace ExamCenterTSZ.UI.ExamCenterInstructor
{
    partial class FindExam
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
            this.btnFindExam = new Bunifu.Framework.UI.BunifuTileButton();
            this.txtFindAssign = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindExam
            // 
            this.btnFindExam.BackColor = System.Drawing.Color.Transparent;
            this.btnFindExam.color = System.Drawing.Color.Transparent;
            this.btnFindExam.colorActive = System.Drawing.Color.Transparent;
            this.btnFindExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindExam.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnFindExam.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindExam.Image = global::ExamCenterTSZ.Properties.Resources.search_find_seek_icon;
            this.btnFindExam.ImagePosition = 0;
            this.btnFindExam.ImageZoom = 110;
            this.btnFindExam.LabelPosition = 0;
            this.btnFindExam.LabelText = "";
            this.btnFindExam.Location = new System.Drawing.Point(209, 0);
            this.btnFindExam.Margin = new System.Windows.Forms.Padding(6);
            this.btnFindExam.Name = "btnFindExam";
            this.btnFindExam.Size = new System.Drawing.Size(42, 42);
            this.btnFindExam.TabIndex = 3;
            this.btnFindExam.Click += new System.EventHandler(this.btnFindExam_Click);
            // 
            // txtFindAssign
            // 
            this.txtFindAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindAssign.Location = new System.Drawing.Point(100, 7);
            this.txtFindAssign.MaxLength = 7;
            this.txtFindAssign.Name = "txtFindAssign";
            this.txtFindAssign.Size = new System.Drawing.Size(100, 29);
            this.txtFindAssign.TabIndex = 4;
            this.txtFindAssign.Enter += new System.EventHandler(this.txtFindAssign_Enter);
            this.txtFindAssign.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindAssign_KeyPress);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.Location = new System.Drawing.Point(6, 10);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(88, 24);
            this.lblFind.TabIndex = 6;
            this.lblFind.Text = "Exam ID";
            // 
            // FindExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.txtFindAssign);
            this.Controls.Add(this.btnFindExam);
            this.Name = "FindExam";
            this.Size = new System.Drawing.Size(264, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton btnFindExam;
        private System.Windows.Forms.TextBox txtFindAssign;
        private System.Windows.Forms.Label lblFind;
    }
}
