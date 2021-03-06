﻿namespace ExamCenterTSZ.UI
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
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitApp = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdminPanel = new Bunifu.Framework.UI.BunifuTileButton();
            this.pMenuBar = new System.Windows.Forms.Panel();
            this.lblPilotsOnlineNow = new System.Windows.Forms.Label();
            this.lblPilotsOnline = new System.Windows.Forms.Label();
            this.btnTSZTools = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuReviewExams = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnInstructor = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMenuExam = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.examCenterCtrl = new ExamCenterTSZ.UI.ExamCenterComponents.ExamCenterCtrl();
            this.examPage = new ExamCenterTSZ.UI.ExamCenterComponents.ExamPage();
            this.processExam = new ExamCenterTSZ.UI.ExamCenterComponents.ProcessExam();
            this.epsConfirm = new ExamCenterTSZ.UI.ExamCenterComponents.EpsConfirm();
            this.examInstructorCtrl = new ExamCenterTSZ.UI.ExamCenterInstructor.ExamInstructorCtrl();
            this.myExamsCtrl = new ExamCenterTSZ.UI.ExamCenterComponents.ViewMyExams.MyExamsCtrl();
            this.adminExamCenterCtrl = new ExamCenterTSZ.UI.AdminPanel.AdminExamCenterCtrl();
            this.UpdatePilotOnline = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.btnExitApp);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 77);
            this.panel1.TabIndex = 95;
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnExitApp.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnExitApp.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApp.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnExitApp.ForeColor = System.Drawing.Color.White;
            this.btnExitApp.Image = global::ExamCenterTSZ.Properties.Resources._2000px_Oxygen480_actions_system_shutdown_svg;
            this.btnExitApp.ImagePosition = 0;
            this.btnExitApp.ImageZoom = 100;
            this.btnExitApp.LabelPosition = 0;
            this.btnExitApp.LabelText = "";
            this.btnExitApp.Location = new System.Drawing.Point(1085, 6);
            this.btnExitApp.Margin = new System.Windows.Forms.Padding(6);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(62, 58);
            this.btnExitApp.TabIndex = 4;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
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
            // btnAdminPanel
            // 
            this.btnAdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAdminPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAdminPanel.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAdminPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminPanel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAdminPanel.ForeColor = System.Drawing.Color.White;
            this.btnAdminPanel.Image = global::ExamCenterTSZ.Properties.Resources.admin_icon;
            this.btnAdminPanel.ImagePosition = 0;
            this.btnAdminPanel.ImageZoom = 100;
            this.btnAdminPanel.LabelPosition = 0;
            this.btnAdminPanel.LabelText = "";
            this.btnAdminPanel.Location = new System.Drawing.Point(136, 21);
            this.btnAdminPanel.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(63, 58);
            this.btnAdminPanel.TabIndex = 2;
            this.btnAdminPanel.Visible = false;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // pMenuBar
            // 
            this.pMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pMenuBar.Controls.Add(this.lblPilotsOnlineNow);
            this.pMenuBar.Controls.Add(this.lblPilotsOnline);
            this.pMenuBar.Controls.Add(this.btnTSZTools);
            this.pMenuBar.Controls.Add(this.btnMenuReviewExams);
            this.pMenuBar.Controls.Add(this.btnRefresh);
            this.pMenuBar.Controls.Add(this.btnInstructor);
            this.pMenuBar.Controls.Add(this.btnAdminPanel);
            this.pMenuBar.Controls.Add(this.btnMenuExam);
            this.pMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuBar.Location = new System.Drawing.Point(0, 77);
            this.pMenuBar.Name = "pMenuBar";
            this.pMenuBar.Size = new System.Drawing.Size(211, 617);
            this.pMenuBar.TabIndex = 96;
            // 
            // lblPilotsOnlineNow
            // 
            this.lblPilotsOnlineNow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPilotsOnlineNow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPilotsOnlineNow.Location = new System.Drawing.Point(20, 365);
            this.lblPilotsOnlineNow.Name = "lblPilotsOnlineNow";
            this.lblPilotsOnlineNow.Size = new System.Drawing.Size(179, 187);
            this.lblPilotsOnlineNow.TabIndex = 7;
            this.lblPilotsOnlineNow.Text = "Pilots Online:";
            // 
            // lblPilotsOnline
            // 
            this.lblPilotsOnline.AutoSize = true;
            this.lblPilotsOnline.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPilotsOnline.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPilotsOnline.Location = new System.Drawing.Point(20, 337);
            this.lblPilotsOnline.Name = "lblPilotsOnline";
            this.lblPilotsOnline.Size = new System.Drawing.Size(92, 17);
            this.lblPilotsOnline.TabIndex = 6;
            this.lblPilotsOnline.Text = "Pilots Online:";
            // 
            // btnTSZTools
            // 
            this.btnTSZTools.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnTSZTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnTSZTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTSZTools.BorderRadius = 0;
            this.btnTSZTools.ButtonText = "Tools";
            this.btnTSZTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTSZTools.DisabledColor = System.Drawing.Color.Gray;
            this.btnTSZTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSZTools.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTSZTools.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTSZTools.Iconimage")));
            this.btnTSZTools.Iconimage_right = null;
            this.btnTSZTools.Iconimage_right_Selected = null;
            this.btnTSZTools.Iconimage_Selected = null;
            this.btnTSZTools.IconMarginLeft = 0;
            this.btnTSZTools.IconMarginRight = 0;
            this.btnTSZTools.IconRightVisible = true;
            this.btnTSZTools.IconRightZoom = 0D;
            this.btnTSZTools.IconVisible = true;
            this.btnTSZTools.IconZoom = 90D;
            this.btnTSZTools.IsTab = false;
            this.btnTSZTools.Location = new System.Drawing.Point(0, 214);
            this.btnTSZTools.Name = "btnTSZTools";
            this.btnTSZTools.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnTSZTools.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnTSZTools.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTSZTools.selected = false;
            this.btnTSZTools.Size = new System.Drawing.Size(238, 48);
            this.btnTSZTools.TabIndex = 5;
            this.btnTSZTools.Text = "Tools";
            this.btnTSZTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTSZTools.Textcolor = System.Drawing.Color.White;
            this.btnTSZTools.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTSZTools.Click += new System.EventHandler(this.btnTSZTools_Click);
            // 
            // btnMenuReviewExams
            // 
            this.btnMenuReviewExams.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnMenuReviewExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnMenuReviewExams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuReviewExams.BorderRadius = 0;
            this.btnMenuReviewExams.ButtonText = "Review Exams";
            this.btnMenuReviewExams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuReviewExams.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuReviewExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuReviewExams.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuReviewExams.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuReviewExams.Iconimage")));
            this.btnMenuReviewExams.Iconimage_right = null;
            this.btnMenuReviewExams.Iconimage_right_Selected = null;
            this.btnMenuReviewExams.Iconimage_Selected = null;
            this.btnMenuReviewExams.IconMarginLeft = 0;
            this.btnMenuReviewExams.IconMarginRight = 0;
            this.btnMenuReviewExams.IconRightVisible = true;
            this.btnMenuReviewExams.IconRightZoom = 0D;
            this.btnMenuReviewExams.IconVisible = true;
            this.btnMenuReviewExams.IconZoom = 90D;
            this.btnMenuReviewExams.IsTab = false;
            this.btnMenuReviewExams.Location = new System.Drawing.Point(0, 160);
            this.btnMenuReviewExams.Name = "btnMenuReviewExams";
            this.btnMenuReviewExams.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnMenuReviewExams.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnMenuReviewExams.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuReviewExams.selected = false;
            this.btnMenuReviewExams.Size = new System.Drawing.Size(238, 48);
            this.btnMenuReviewExams.TabIndex = 4;
            this.btnMenuReviewExams.Text = "Review Exams";
            this.btnMenuReviewExams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReviewExams.Textcolor = System.Drawing.Color.White;
            this.btnMenuReviewExams.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuReviewExams.Click += new System.EventHandler(this.btnMenuReviewExams_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnRefresh.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnRefresh.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::ExamCenterTSZ.Properties.Resources.refreshImg;
            this.btnRefresh.ImagePosition = 0;
            this.btnRefresh.ImageZoom = 95;
            this.btnRefresh.LabelPosition = 0;
            this.btnRefresh.LabelText = "";
            this.btnRefresh.Location = new System.Drawing.Point(66, 15);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 64);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnInstructor
            // 
            this.btnInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnInstructor.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnInstructor.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnInstructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstructor.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnInstructor.ForeColor = System.Drawing.Color.White;
            this.btnInstructor.Image = ((System.Drawing.Image)(resources.GetObject("btnInstructor.Image")));
            this.btnInstructor.ImagePosition = 0;
            this.btnInstructor.ImageZoom = 100;
            this.btnInstructor.LabelPosition = 0;
            this.btnInstructor.LabelText = "";
            this.btnInstructor.Location = new System.Drawing.Point(6, 21);
            this.btnInstructor.Margin = new System.Windows.Forms.Padding(6);
            this.btnInstructor.Name = "btnInstructor";
            this.btnInstructor.Size = new System.Drawing.Size(62, 58);
            this.btnInstructor.TabIndex = 3;
            this.btnInstructor.Visible = false;
            this.btnInstructor.Click += new System.EventHandler(this.btnInstructor_Click);
            // 
            // btnMenuExam
            // 
            this.btnMenuExam.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnMenuExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnMenuExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuExam.BorderRadius = 0;
            this.btnMenuExam.ButtonText = "Take Exams";
            this.btnMenuExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuExam.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuExam.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuExam.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuExam.Iconimage")));
            this.btnMenuExam.Iconimage_right = null;
            this.btnMenuExam.Iconimage_right_Selected = null;
            this.btnMenuExam.Iconimage_Selected = null;
            this.btnMenuExam.IconMarginLeft = 0;
            this.btnMenuExam.IconMarginRight = 0;
            this.btnMenuExam.IconRightVisible = true;
            this.btnMenuExam.IconRightZoom = 0D;
            this.btnMenuExam.IconVisible = true;
            this.btnMenuExam.IconZoom = 90D;
            this.btnMenuExam.IsTab = false;
            this.btnMenuExam.Location = new System.Drawing.Point(0, 106);
            this.btnMenuExam.Name = "btnMenuExam";
            this.btnMenuExam.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnMenuExam.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnMenuExam.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuExam.selected = false;
            this.btnMenuExam.Size = new System.Drawing.Size(238, 48);
            this.btnMenuExam.TabIndex = 0;
            this.btnMenuExam.Text = "Take Exams";
            this.btnMenuExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuExam.Textcolor = System.Drawing.Color.White;
            this.btnMenuExam.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuExam.Click += new System.EventHandler(this.btnMenuExam_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(231, 92);
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
            this.lblClock.Location = new System.Drawing.Point(971, 89);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(176, 20);
            this.lblClock.TabIndex = 90;
            this.lblClock.Text = "2011-01-07 14:04:25";
            // 
            // examCenterCtrl
            // 
            this.examCenterCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.examCenterCtrl.Location = new System.Drawing.Point(257, 131);
            this.examCenterCtrl.Name = "examCenterCtrl";
            this.examCenterCtrl.Size = new System.Drawing.Size(651, 463);
            this.examCenterCtrl.TabIndex = 106;
            // 
            // examPage
            // 
            this.examPage.CurrentQuestion = 0;
            this.examPage.Location = new System.Drawing.Point(234, 153);
            this.examPage.Name = "examPage";
            this.examPage.Size = new System.Drawing.Size(882, 529);
            this.examPage.TabIndex = 104;
            this.examPage.Visible = false;
            // 
            // processExam
            // 
            this.processExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processExam.Location = new System.Drawing.Point(400, 220);
            this.processExam.Name = "processExam";
            this.processExam.Size = new System.Drawing.Size(541, 262);
            this.processExam.TabIndex = 105;
            this.processExam.Visible = false;
            // 
            // epsConfirm
            // 
            this.epsConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epsConfirm.Location = new System.Drawing.Point(320, 220);
            this.epsConfirm.Name = "epsConfirm";
            this.epsConfirm.Size = new System.Drawing.Size(551, 262);
            this.epsConfirm.TabIndex = 107;
            this.epsConfirm.Visible = false;
            // 
            // examInstructorCtrl
            // 
            this.examInstructorCtrl.Location = new System.Drawing.Point(234, 131);
            this.examInstructorCtrl.Name = "examInstructorCtrl";
            this.examInstructorCtrl.Size = new System.Drawing.Size(882, 534);
            this.examInstructorCtrl.TabIndex = 108;
            this.examInstructorCtrl.Visible = false;
            this.examInstructorCtrl.VisibleChanged += new System.EventHandler(this.examInstructorCtrl_VisibleChanged);
            // 
            // myExamsCtrl
            // 
            this.myExamsCtrl.Location = new System.Drawing.Point(217, 129);
            this.myExamsCtrl.Name = "myExamsCtrl";
            this.myExamsCtrl.Size = new System.Drawing.Size(930, 553);
            this.myExamsCtrl.TabIndex = 109;
            this.myExamsCtrl.Visible = false;
            this.myExamsCtrl.VisibleChanged += new System.EventHandler(this.myExamsCtrl_VisibleChanged);
            // 
            // adminExamCenterCtrl
            // 
            this.adminExamCenterCtrl.Location = new System.Drawing.Point(217, 129);
            this.adminExamCenterCtrl.Name = "adminExamCenterCtrl";
            this.adminExamCenterCtrl.Size = new System.Drawing.Size(948, 528);
            this.adminExamCenterCtrl.TabIndex = 110;
            this.adminExamCenterCtrl.Visible = false;
            // 
            // UpdatePilotOnline
            // 
            this.UpdatePilotOnline.Interval = 60000;
            this.UpdatePilotOnline.Tick += new System.EventHandler(this.UpdatePilotOnline_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 694);
            this.Controls.Add(this.adminExamCenterCtrl);
            this.Controls.Add(this.myExamsCtrl);
            this.Controls.Add(this.examInstructorCtrl);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pMenuBar.ResumeLayout(false);
            this.pMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pMenuBar;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuExam;
        private Bunifu.Framework.UI.BunifuTileButton btnRefresh;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblClock;
        private Bunifu.Framework.UI.BunifuTileButton btnAdminPanel;
        private Bunifu.Framework.UI.BunifuTileButton btnInstructor;
        public Bunifu.Framework.UI.BunifuTileButton btnExitApp;
        public ExamCenterComponents.EpsConfirm epsConfirm;
        public ExamCenterComponents.ExamPage examPage;
        public ExamCenterComponents.ProcessExam processExam;
        public ExamCenterComponents.ExamCenterCtrl examCenterCtrl;
        private ExamCenterInstructor.ExamInstructorCtrl examInstructorCtrl;
        private ExamCenterComponents.ViewMyExams.MyExamsCtrl myExamsCtrl;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuReviewExams;
        public AdminPanel.AdminExamCenterCtrl adminExamCenterCtrl;
        private Bunifu.Framework.UI.BunifuFlatButton btnTSZTools;
        private System.Windows.Forms.Label lblPilotsOnlineNow;
        private System.Windows.Forms.Label lblPilotsOnline;
        private System.Windows.Forms.Timer UpdatePilotOnline;
    }
}