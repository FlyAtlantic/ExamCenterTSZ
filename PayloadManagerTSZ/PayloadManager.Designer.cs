namespace PayloadManagerTSZ
{
    partial class PayloadManager
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
            this.components = new System.ComponentModel.Container();
            this.lblZFW = new System.Windows.Forms.Label();
            this.lblGW = new System.Windows.Forms.Label();
            this.Telemetry = new System.Windows.Forms.Timer(this.components);
            this.txtFW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblZFW
            // 
            this.lblZFW.AutoSize = true;
            this.lblZFW.Location = new System.Drawing.Point(63, 9);
            this.lblZFW.Name = "lblZFW";
            this.lblZFW.Size = new System.Drawing.Size(31, 13);
            this.lblZFW.TabIndex = 0;
            this.lblZFW.Text = "ZFW";
            // 
            // lblGW
            // 
            this.lblGW.AutoSize = true;
            this.lblGW.Location = new System.Drawing.Point(63, 37);
            this.lblGW.Name = "lblGW";
            this.lblGW.Size = new System.Drawing.Size(26, 13);
            this.lblGW.TabIndex = 1;
            this.lblGW.Text = "GW";
            // 
            // Telemetry
            // 
            this.Telemetry.Interval = 10;
            this.Telemetry.Tick += new System.EventHandler(this.Telemetry_Tick);
            // 
            // txtFW
            // 
            this.txtFW.Location = new System.Drawing.Point(138, 30);
            this.txtFW.Name = "txtFW";
            this.txtFW.Size = new System.Drawing.Size(100, 20);
            this.txtFW.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "GW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ZFW";
            // 
            // btnEnter
            // 
            this.btnEnter.AutoSize = true;
            this.btnEnter.Location = new System.Drawing.Point(154, 70);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(84, 23);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "Insert Payload";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "FW";
            // 
            // lblFW
            // 
            this.lblFW.AutoSize = true;
            this.lblFW.Location = new System.Drawing.Point(63, 75);
            this.lblFW.Name = "lblFW";
            this.lblFW.Size = new System.Drawing.Size(24, 13);
            this.lblFW.TabIndex = 7;
            this.lblFW.Text = "FW";
            // 
            // PayloadManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 113);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFW);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFW);
            this.Controls.Add(this.lblGW);
            this.Controls.Add(this.lblZFW);
            this.Name = "PayloadManager";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZFW;
        private System.Windows.Forms.Label lblGW;
        private System.Windows.Forms.Timer Telemetry;
        private System.Windows.Forms.TextBox txtFW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFW;
    }
}

