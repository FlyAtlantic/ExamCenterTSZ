namespace ExamCenterTSZ.UI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pMenuBar = new System.Windows.Forms.Panel();
            this.btnMenuHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ChronomiterTimer = new System.Windows.Forms.Timer(this.components);
            this.Loading = new System.Windows.Forms.Timer(this.components);
            this.epsConfirm = new ExamCenterTSZ.UI.ExamCenterComponents.EpsConfirm();
            this.examPage = new ExamCenterTSZ.UI.ExamCenterComponents.ExamPage();
            this.processExam = new ExamCenterTSZ.UI.ExamCenterComponents.ProcessExam();
            this.examCenterCtrl = new ExamCenterTSZ.UI.ExamCenterComponents.ExamCenterCtrl();
            this.panel1.SuspendLayout();
            this.pMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(241, 92);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(73, 17);
            this.lblWelcome.TabIndex = 93;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblClock.Location = new System.Drawing.Point(981, 89);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(176, 20);
            this.lblClock.TabIndex = 90;
            this.lblClock.Text = "2011-01-07 14:04:25";
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 77);
            this.panel1.TabIndex = 95;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(19, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "FlyAtlantic Examination Center";
            // 
            // pMenuBar
            // 
            this.pMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pMenuBar.Controls.Add(this.btnMenuHome);
            this.pMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuBar.Location = new System.Drawing.Point(0, 77);
            this.pMenuBar.Name = "pMenuBar";
            this.pMenuBar.Size = new System.Drawing.Size(220, 617);
            this.pMenuBar.TabIndex = 96;
            // 
            // btnMenuHome
            // 
            this.btnMenuHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMenuHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMenuHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuHome.BorderRadius = 0;
            this.btnMenuHome.ButtonText = "Take Your Exams";
            this.btnMenuHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuHome.Iconimage")));
            this.btnMenuHome.Iconimage_right = null;
            this.btnMenuHome.Iconimage_right_Selected = null;
            this.btnMenuHome.Iconimage_Selected = null;
            this.btnMenuHome.IconMarginLeft = 0;
            this.btnMenuHome.IconMarginRight = 0;
            this.btnMenuHome.IconRightVisible = true;
            this.btnMenuHome.IconRightZoom = 0D;
            this.btnMenuHome.IconVisible = true;
            this.btnMenuHome.IconZoom = 90D;
            this.btnMenuHome.IsTab = false;
            this.btnMenuHome.Location = new System.Drawing.Point(3, 12);
            this.btnMenuHome.Name = "btnMenuHome";
            this.btnMenuHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMenuHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMenuHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuHome.selected = false;
            this.btnMenuHome.Size = new System.Drawing.Size(238, 48);
            this.btnMenuHome.TabIndex = 0;
            this.btnMenuHome.Text = "Take Your Exams";
            this.btnMenuHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuHome.Textcolor = System.Drawing.Color.White;
            this.btnMenuHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuHome.Click += new System.EventHandler(this.btnMenuHome_Click);
            // 
            // ChronomiterTimer
            // 
            this.ChronomiterTimer.Interval = 1000;
            // 
            // Loading
            // 
            this.Loading.Interval = 50;
            // 
            // epsConfirm
            // 
            this.epsConfirm.Location = new System.Drawing.Point(801, 92);
            this.epsConfirm.Name = "epsConfirm";
            this.epsConfirm.Size = new System.Drawing.Size(150, 150);
            this.epsConfirm.TabIndex = 102;
            // 
            // examPage
            // 
            this.examPage.CurrentQuestion = 0;
            this.examPage.Location = new System.Drawing.Point(244, 153);
            this.examPage.Name = "examPage";
            this.examPage.Size = new System.Drawing.Size(882, 441);
            this.examPage.TabIndex = 104;
            this.examPage.Visible = false;
            // 
            // processExam
            // 
            this.processExam.Location = new System.Drawing.Point(410, 220);
            this.processExam.Name = "processExam";
            this.processExam.Size = new System.Drawing.Size(541, 262);
            this.processExam.TabIndex = 105;
            this.processExam.Visible = false;
            // 
            // examCenterCtrl
            // 
            this.examCenterCtrl.Location = new System.Drawing.Point(267, 131);
            this.examCenterCtrl.Name = "examCenterCtrl";
            this.examCenterCtrl.Size = new System.Drawing.Size(655, 463);
            this.examCenterCtrl.TabIndex = 106;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 694);
            this.Controls.Add(this.epsConfirm);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.pMenuBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.processExam);
            this.Controls.Add(this.examPage);
            this.Controls.Add(this.examCenterCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExamCenter_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pMenuBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pMenuBar;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuHome;
        private System.Windows.Forms.Timer ChronomiterTimer;
        private System.Windows.Forms.Timer Loading;
        public ExamCenterComponents.EpsConfirm epsConfirm;
        public ExamCenterComponents.ExamPage examPage;
        public ExamCenterComponents.ProcessExam processExam;
        public ExamCenterComponents.ExamCenterCtrl examCenterCtrl;
    }
}