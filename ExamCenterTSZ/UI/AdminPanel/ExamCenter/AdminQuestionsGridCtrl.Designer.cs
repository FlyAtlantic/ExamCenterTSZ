namespace ExamCenterTSZ.UI.AdminPanel.ExamCenter
{
    partial class AdminQuestionsGridCtrl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewQuestions = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.adminManageQuestions = new ExamCenterTSZ.UI.AdminPanel.ExamCenter.AdminManageQuestions();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewQuestions
            // 
            this.gridViewQuestions.AllowUserToAddRows = false;
            this.gridViewQuestions.AllowUserToDeleteRows = false;
            this.gridViewQuestions.AllowUserToResizeColumns = false;
            this.gridViewQuestions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewQuestions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewQuestions.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridViewQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewQuestions.DoubleBuffered = true;
            this.gridViewQuestions.EnableHeadersVisualStyles = false;
            this.gridViewQuestions.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridViewQuestions.HeaderBgColor = System.Drawing.Color.White;
            this.gridViewQuestions.HeaderForeColor = System.Drawing.Color.Blue;
            this.gridViewQuestions.Location = new System.Drawing.Point(3, 3);
            this.gridViewQuestions.MultiSelect = false;
            this.gridViewQuestions.Name = "gridViewQuestions";
            this.gridViewQuestions.ReadOnly = true;
            this.gridViewQuestions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewQuestions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridViewQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewQuestions.Size = new System.Drawing.Size(879, 466);
            this.gridViewQuestions.TabIndex = 1;
            this.gridViewQuestions.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewQuestions_CellMouseDoubleClick);
            // 
            // adminManageQuestions
            // 
            this.adminManageQuestions.Location = new System.Drawing.Point(0, 0);
            this.adminManageQuestions.Name = "adminManageQuestions";
            this.adminManageQuestions.Size = new System.Drawing.Size(859, 484);
            this.adminManageQuestions.TabIndex = 2;
            this.adminManageQuestions.Visible = false;
            // 
            // AdminQuestionsGridCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminManageQuestions);
            this.Controls.Add(this.gridViewQuestions);
            this.Name = "AdminQuestionsGridCtrl";
            this.Size = new System.Drawing.Size(903, 497);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.Framework.UI.BunifuCustomDataGrid gridViewQuestions;
        public AdminManageQuestions adminManageQuestions;
    }
}
