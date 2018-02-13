namespace TSZTools
{
    partial class ToolControlFrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metarsCtrl = new TSZTools.MetarsCtrl();
            this.oceanicReportCtrl = new TSZTools.OceanicReportCtrl();
            this.menuCtrl = new TSZTools.MenuCtrl();
            this.SuspendLayout();
            // 
            // metarsCtrl
            // 
            this.metarsCtrl.Location = new System.Drawing.Point(2, 3);
            this.metarsCtrl.Name = "metarsCtrl";
            this.metarsCtrl.Size = new System.Drawing.Size(699, 90);
            this.metarsCtrl.TabIndex = 3;
            this.metarsCtrl.Visible = false;
            // 
            // oceanicReportCtrl
            // 
            this.oceanicReportCtrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oceanicReportCtrl.Location = new System.Drawing.Point(2, 3);
            this.oceanicReportCtrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oceanicReportCtrl.Name = "oceanicReportCtrl";
            this.oceanicReportCtrl.Size = new System.Drawing.Size(692, 464);
            this.oceanicReportCtrl.TabIndex = 4;
            this.oceanicReportCtrl.Visible = false;
            // 
            // menuCtrl
            // 
            this.menuCtrl.Location = new System.Drawing.Point(2, 3);
            this.menuCtrl.Name = "menuCtrl";
            this.menuCtrl.Size = new System.Drawing.Size(692, 99);
            this.menuCtrl.TabIndex = 5;
            // 
            // ToolControlFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 473);
            this.Controls.Add(this.oceanicReportCtrl);
            this.Controls.Add(this.metarsCtrl);
            this.Controls.Add(this.menuCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolControlFrm";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        public MenuCtrl menuCtrl;
        public MetarsCtrl metarsCtrl;
        public OceanicReportCtrl oceanicReportCtrl;
    }
}

