namespace TSZTools
{
    partial class MetarsCtrl
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
            this.lblMetar = new System.Windows.Forms.Label();
            this.lblViewMetar = new System.Windows.Forms.Label();
            this.lblIcao = new System.Windows.Forms.Label();
            this.txtICAO = new System.Windows.Forms.TextBox();
            this.btnViewMetar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMetar
            // 
            this.lblMetar.AutoSize = true;
            this.lblMetar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetar.Location = new System.Drawing.Point(3, 0);
            this.lblMetar.Name = "lblMetar";
            this.lblMetar.Size = new System.Drawing.Size(55, 21);
            this.lblMetar.TabIndex = 0;
            this.lblMetar.Text = "Metar";
            // 
            // lblViewMetar
            // 
            this.lblViewMetar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewMetar.Location = new System.Drawing.Point(3, 21);
            this.lblViewMetar.Name = "lblViewMetar";
            this.lblViewMetar.Size = new System.Drawing.Size(614, 43);
            this.lblViewMetar.TabIndex = 1;
            this.lblViewMetar.Text = "Metar";
            // 
            // lblIcao
            // 
            this.lblIcao.AutoSize = true;
            this.lblIcao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcao.Location = new System.Drawing.Point(3, 64);
            this.lblIcao.Name = "lblIcao";
            this.lblIcao.Size = new System.Drawing.Size(52, 21);
            this.lblIcao.TabIndex = 2;
            this.lblIcao.Text = "ICAO:";
            // 
            // txtICAO
            // 
            this.txtICAO.Location = new System.Drawing.Point(52, 65);
            this.txtICAO.MaxLength = 4;
            this.txtICAO.Name = "txtICAO";
            this.txtICAO.Size = new System.Drawing.Size(100, 20);
            this.txtICAO.TabIndex = 3;
            // 
            // btnViewMetar
            // 
            this.btnViewMetar.Location = new System.Drawing.Point(198, 64);
            this.btnViewMetar.Name = "btnViewMetar";
            this.btnViewMetar.Size = new System.Drawing.Size(75, 23);
            this.btnViewMetar.TabIndex = 4;
            this.btnViewMetar.Text = "View Metar";
            this.btnViewMetar.UseVisualStyleBackColor = true;
            this.btnViewMetar.Click += new System.EventHandler(this.btnViewMetar_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(288, 64);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MetarsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewMetar);
            this.Controls.Add(this.txtICAO);
            this.Controls.Add(this.lblIcao);
            this.Controls.Add(this.lblViewMetar);
            this.Controls.Add(this.lblMetar);
            this.Name = "MetarsCtrl";
            this.Size = new System.Drawing.Size(620, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMetar;
        private System.Windows.Forms.Label lblViewMetar;
        private System.Windows.Forms.Label lblIcao;
        private System.Windows.Forms.TextBox txtICAO;
        private System.Windows.Forms.Button btnViewMetar;
        private System.Windows.Forms.Button btnBack;
    }
}
