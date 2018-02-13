namespace TSZTools
{
    partial class OceanicReportCtrl
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
            this.lblCallsign = new System.Windows.Forms.Label();
            this.txtCallsign = new System.Windows.Forms.TextBox();
            this.lblTSZ = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtNextPosition = new System.Windows.Forms.TextBox();
            this.lblNextPosition = new System.Windows.Forms.Label();
            this.txtThen = new System.Windows.Forms.TextBox();
            this.lblThen = new System.Windows.Forms.Label();
            this.lblTimeAtPosition = new System.Windows.Forms.Label();
            this.cboxMinutesPosition = new System.Windows.Forms.ComboBox();
            this.cboxHourPosition = new System.Windows.Forms.ComboBox();
            this.cboxFlightLevel = new System.Windows.Forms.ComboBox();
            this.lblFlightLevel = new System.Windows.Forms.Label();
            this.cboxHoursNextETA = new System.Windows.Forms.ComboBox();
            this.cboxMinutesNextETA = new System.Windows.Forms.ComboBox();
            this.lblNextPositionETA = new System.Windows.Forms.Label();
            this.cboxMach = new System.Windows.Forms.ComboBox();
            this.lblMach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCallsign
            // 
            this.lblCallsign.AutoSize = true;
            this.lblCallsign.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallsign.Location = new System.Drawing.Point(68, 22);
            this.lblCallsign.Name = "lblCallsign";
            this.lblCallsign.Size = new System.Drawing.Size(61, 17);
            this.lblCallsign.TabIndex = 0;
            this.lblCallsign.Text = "Callsign:";
            // 
            // txtCallsign
            // 
            this.txtCallsign.Location = new System.Drawing.Point(156, 19);
            this.txtCallsign.MaxLength = 5;
            this.txtCallsign.Name = "txtCallsign";
            this.txtCallsign.Size = new System.Drawing.Size(71, 25);
            this.txtCallsign.TabIndex = 1;
            // 
            // lblTSZ
            // 
            this.lblTSZ.AutoSize = true;
            this.lblTSZ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSZ.Location = new System.Drawing.Point(128, 22);
            this.lblTSZ.Name = "lblTSZ";
            this.lblTSZ.Size = new System.Drawing.Size(31, 17);
            this.lblTSZ.TabIndex = 2;
            this.lblTSZ.Text = "TSZ";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(66, 62);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(63, 17);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Position:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(131, 59);
            this.txtPosition.MaxLength = 5;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(96, 25);
            this.txtPosition.TabIndex = 2;
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNextPosition
            // 
            this.txtNextPosition.Location = new System.Drawing.Point(131, 172);
            this.txtNextPosition.MaxLength = 5;
            this.txtNextPosition.Name = "txtNextPosition";
            this.txtNextPosition.Size = new System.Drawing.Size(96, 25);
            this.txtNextPosition.TabIndex = 6;
            this.txtNextPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNextPosition
            // 
            this.lblNextPosition.AutoSize = true;
            this.lblNextPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPosition.Location = new System.Drawing.Point(37, 175);
            this.lblNextPosition.Name = "lblNextPosition";
            this.lblNextPosition.Size = new System.Drawing.Size(92, 17);
            this.lblNextPosition.TabIndex = 5;
            this.lblNextPosition.Text = "NextPosition:";
            // 
            // txtThen
            // 
            this.txtThen.Location = new System.Drawing.Point(131, 249);
            this.txtThen.MaxLength = 5;
            this.txtThen.Name = "txtThen";
            this.txtThen.Size = new System.Drawing.Size(96, 25);
            this.txtThen.TabIndex = 9;
            this.txtThen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblThen
            // 
            this.lblThen.AutoSize = true;
            this.lblThen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThen.Location = new System.Drawing.Point(86, 252);
            this.lblThen.Name = "lblThen";
            this.lblThen.Size = new System.Drawing.Size(43, 17);
            this.lblThen.TabIndex = 7;
            this.lblThen.Text = "Then:";
            // 
            // lblTimeAtPosition
            // 
            this.lblTimeAtPosition.AutoSize = true;
            this.lblTimeAtPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAtPosition.Location = new System.Drawing.Point(15, 98);
            this.lblTimeAtPosition.Name = "lblTimeAtPosition";
            this.lblTimeAtPosition.Size = new System.Drawing.Size(114, 17);
            this.lblTimeAtPosition.TabIndex = 9;
            this.lblTimeAtPosition.Text = "Time at Position:";
            // 
            // cboxMinutesPosition
            // 
            this.cboxMinutesPosition.FormattingEnabled = true;
            this.cboxMinutesPosition.Location = new System.Drawing.Point(181, 95);
            this.cboxMinutesPosition.Name = "cboxMinutesPosition";
            this.cboxMinutesPosition.Size = new System.Drawing.Size(46, 25);
            this.cboxMinutesPosition.TabIndex = 4;
            // 
            // cboxHourPosition
            // 
            this.cboxHourPosition.FormattingEnabled = true;
            this.cboxHourPosition.Location = new System.Drawing.Point(131, 95);
            this.cboxHourPosition.Name = "cboxHourPosition";
            this.cboxHourPosition.Size = new System.Drawing.Size(44, 25);
            this.cboxHourPosition.TabIndex = 3;
            // 
            // cboxFlightLevel
            // 
            this.cboxFlightLevel.FormattingEnabled = true;
            this.cboxFlightLevel.Location = new System.Drawing.Point(131, 133);
            this.cboxFlightLevel.Name = "cboxFlightLevel";
            this.cboxFlightLevel.Size = new System.Drawing.Size(96, 25);
            this.cboxFlightLevel.TabIndex = 5;
            // 
            // lblFlightLevel
            // 
            this.lblFlightLevel.AutoSize = true;
            this.lblFlightLevel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightLevel.Location = new System.Drawing.Point(45, 136);
            this.lblFlightLevel.Name = "lblFlightLevel";
            this.lblFlightLevel.Size = new System.Drawing.Size(84, 17);
            this.lblFlightLevel.TabIndex = 13;
            this.lblFlightLevel.Text = "Flight Level:";
            // 
            // cboxHoursNextETA
            // 
            this.cboxHoursNextETA.FormattingEnabled = true;
            this.cboxHoursNextETA.Location = new System.Drawing.Point(131, 211);
            this.cboxHoursNextETA.Name = "cboxHoursNextETA";
            this.cboxHoursNextETA.Size = new System.Drawing.Size(44, 25);
            this.cboxHoursNextETA.TabIndex = 7;
            // 
            // cboxMinutesNextETA
            // 
            this.cboxMinutesNextETA.FormattingEnabled = true;
            this.cboxMinutesNextETA.Location = new System.Drawing.Point(181, 211);
            this.cboxMinutesNextETA.Name = "cboxMinutesNextETA";
            this.cboxMinutesNextETA.Size = new System.Drawing.Size(46, 25);
            this.cboxMinutesNextETA.TabIndex = 8;
            // 
            // lblNextPositionETA
            // 
            this.lblNextPositionETA.AutoSize = true;
            this.lblNextPositionETA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPositionETA.Location = new System.Drawing.Point(5, 214);
            this.lblNextPositionETA.Name = "lblNextPositionETA";
            this.lblNextPositionETA.Size = new System.Drawing.Size(124, 17);
            this.lblNextPositionETA.TabIndex = 16;
            this.lblNextPositionETA.Text = "Next Position ETA:";
            // 
            // cboxMach
            // 
            this.cboxMach.FormattingEnabled = true;
            this.cboxMach.Location = new System.Drawing.Point(131, 284);
            this.cboxMach.Name = "cboxMach";
            this.cboxMach.Size = new System.Drawing.Size(96, 25);
            this.cboxMach.TabIndex = 10;
            // 
            // lblMach
            // 
            this.lblMach.AutoSize = true;
            this.lblMach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMach.Location = new System.Drawing.Point(80, 287);
            this.lblMach.Name = "lblMach";
            this.lblMach.Size = new System.Drawing.Size(45, 17);
            this.lblMach.TabIndex = 19;
            this.lblMach.Text = "Mach:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Your callsign";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "The position you\'re reporting at.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "The time of your position report. Hours and minutes in UTC.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Your current flight level.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "The position you are heading to next.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(369, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Your estimated arrival time at the next position, hhmm in UTC.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(395, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "The position you are planning to head to after your next waypoint.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(428, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Your current Mach Speed. M0.80 would be read as \"decimal eight zero\"";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(89, 332);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(96, 23);
            this.btnGenerate.TabIndex = 29;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtReport
            // 
            this.txtReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReport.Location = new System.Drawing.Point(89, 376);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.ReadOnly = true;
            this.txtReport.Size = new System.Drawing.Size(515, 61);
            this.txtReport.TabIndex = 30;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(513, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 23);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // OceanicReportCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxMach);
            this.Controls.Add(this.lblMach);
            this.Controls.Add(this.cboxHoursNextETA);
            this.Controls.Add(this.cboxMinutesNextETA);
            this.Controls.Add(this.lblNextPositionETA);
            this.Controls.Add(this.cboxFlightLevel);
            this.Controls.Add(this.lblFlightLevel);
            this.Controls.Add(this.cboxHourPosition);
            this.Controls.Add(this.cboxMinutesPosition);
            this.Controls.Add(this.lblTimeAtPosition);
            this.Controls.Add(this.txtThen);
            this.Controls.Add(this.lblThen);
            this.Controls.Add(this.txtNextPosition);
            this.Controls.Add(this.lblNextPosition);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblTSZ);
            this.Controls.Add(this.txtCallsign);
            this.Controls.Add(this.lblCallsign);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OceanicReportCtrl";
            this.Size = new System.Drawing.Size(692, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCallsign;
        private System.Windows.Forms.TextBox txtCallsign;
        private System.Windows.Forms.Label lblTSZ;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtNextPosition;
        private System.Windows.Forms.Label lblNextPosition;
        private System.Windows.Forms.TextBox txtThen;
        private System.Windows.Forms.Label lblThen;
        private System.Windows.Forms.Label lblTimeAtPosition;
        private System.Windows.Forms.ComboBox cboxMinutesPosition;
        private System.Windows.Forms.ComboBox cboxHourPosition;
        private System.Windows.Forms.ComboBox cboxFlightLevel;
        private System.Windows.Forms.Label lblFlightLevel;
        private System.Windows.Forms.ComboBox cboxHoursNextETA;
        private System.Windows.Forms.ComboBox cboxMinutesNextETA;
        private System.Windows.Forms.Label lblNextPositionETA;
        private System.Windows.Forms.ComboBox cboxMach;
        private System.Windows.Forms.Label lblMach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.Button btnBack;
    }
}
