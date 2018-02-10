namespace ExamCenterTSZ.UI.ExamCenterComponents
{
    partial class ViewMyExamsGridCtrl
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
            this.btnViewExam = new Bunifu.Framework.UI.BunifuTileButton();
            this.gridViewExams = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExams)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewExam
            // 
            this.btnViewExam.BackColor = System.Drawing.Color.Transparent;
            this.btnViewExam.color = System.Drawing.Color.Transparent;
            this.btnViewExam.colorActive = System.Drawing.Color.Transparent;
            this.btnViewExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewExam.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnViewExam.ForeColor = System.Drawing.Color.White;
            this.btnViewExam.Image = global::ExamCenterTSZ.Properties.Resources.search_find_seek_icon;
            this.btnViewExam.ImagePosition = 0;
            this.btnViewExam.ImageZoom = 100;
            this.btnViewExam.LabelPosition = 0;
            this.btnViewExam.LabelText = "";
            this.btnViewExam.Location = new System.Drawing.Point(490, 50);
            this.btnViewExam.Margin = new System.Windows.Forms.Padding(6);
            this.btnViewExam.Name = "btnViewExam";
            this.btnViewExam.Size = new System.Drawing.Size(62, 58);
            this.btnViewExam.TabIndex = 0;
            this.btnViewExam.Tag = "";
            this.btnViewExam.Click += new System.EventHandler(this.btnViewExam_Click);
            // 
            // gridViewExams
            // 
            this.gridViewExams.AllowUserToAddRows = false;
            this.gridViewExams.AllowUserToDeleteRows = false;
            this.gridViewExams.AllowUserToResizeColumns = false;
            this.gridViewExams.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewExams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewExams.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridViewExams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewExams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewExams.DoubleBuffered = true;
            this.gridViewExams.EnableHeadersVisualStyles = false;
            this.gridViewExams.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridViewExams.HeaderBgColor = System.Drawing.Color.White;
            this.gridViewExams.HeaderForeColor = System.Drawing.Color.Blue;
            this.gridViewExams.Location = new System.Drawing.Point(3, 3);
            this.gridViewExams.MultiSelect = false;
            this.gridViewExams.Name = "gridViewExams";
            this.gridViewExams.ReadOnly = true;
            this.gridViewExams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewExams.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridViewExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewExams.Size = new System.Drawing.Size(464, 524);
            this.gridViewExams.TabIndex = 0;
            this.gridViewExams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewExams_CellClick);
            // 
            // ViewMyExamsGridCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewExam);
            this.Controls.Add(this.gridViewExams);
            this.Name = "ViewMyExamsGridCtrl";
            this.Size = new System.Drawing.Size(589, 530);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton btnViewExam;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridViewExams;
    }
}
