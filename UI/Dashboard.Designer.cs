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
            this.fpTyperatings = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pMenuBar = new System.Windows.Forms.Panel();
            this.btnMenuHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTyperatings = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelExamPage = new System.Windows.Forms.Panel();
            this.lblClockText = new System.Windows.Forms.Label();
            this.lblCountTime = new System.Windows.Forms.Label();
            this.btnFinish = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblCountQuestions = new System.Windows.Forms.Label();
            this.btnNext = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuTileButton();
            this.qstControl = new ExamCenterTSZ.UI.ExamCenterComponents.QuestionCtrl();
            this.fpRank = new System.Windows.Forms.FlowLayoutPanel();
            this.fpQualifications = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRank = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblQualifications = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelFinishExam = new System.Windows.Forms.Panel();
            this.btnCntFinish = new System.Windows.Forms.Button();
            this.lblFinishApproved = new System.Windows.Forms.Label();
            this.lblFinishRejected = new System.Windows.Forms.Label();
            this.txtLoadingStandby = new System.Windows.Forms.TextBox();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.ChronomiterTimer = new System.Windows.Forms.Timer(this.components);
            this.Loading = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pMenuBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelExamPage.SuspendLayout();
            this.panelFinishExam.SuspendLayout();
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
            // fpTyperatings
            // 
            this.fpTyperatings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpTyperatings.Location = new System.Drawing.Point(53, 75);
            this.fpTyperatings.Name = "fpTyperatings";
            this.fpTyperatings.Size = new System.Drawing.Size(224, 358);
            this.fpTyperatings.TabIndex = 94;
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
            this.btnMenuHome.ButtonText = "Home";
            this.btnMenuHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuHome.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnMenuHome.Text = "Home";
            this.btnMenuHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuHome.Textcolor = System.Drawing.Color.White;
            this.btnMenuHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblTyperatings
            // 
            this.lblTyperatings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTyperatings.AutoSize = true;
            this.lblTyperatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyperatings.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTyperatings.Location = new System.Drawing.Point(62, 43);
            this.lblTyperatings.Name = "lblTyperatings";
            this.lblTyperatings.Size = new System.Drawing.Size(119, 24);
            this.lblTyperatings.TabIndex = 97;
            this.lblTyperatings.Text = "Typeratings";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panelExamPage);
            this.panel2.Controls.Add(this.fpRank);
            this.panel2.Controls.Add(this.fpQualifications);
            this.panel2.Controls.Add(this.lblRank);
            this.panel2.Controls.Add(this.lblQualifications);
            this.panel2.Controls.Add(this.lblTyperatings);
            this.panel2.Controls.Add(this.fpTyperatings);
            this.panel2.Location = new System.Drawing.Point(226, 122);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(931, 535);
            this.panel2.TabIndex = 98;
            // 
            // panelExamPage
            // 
            this.panelExamPage.Controls.Add(this.lblClockText);
            this.panelExamPage.Controls.Add(this.lblCountTime);
            this.panelExamPage.Controls.Add(this.btnFinish);
            this.panelExamPage.Controls.Add(this.lblCountQuestions);
            this.panelExamPage.Controls.Add(this.btnNext);
            this.panelExamPage.Controls.Add(this.btnPrevious);
            this.panelExamPage.Controls.Add(this.qstControl);
            this.panelExamPage.Location = new System.Drawing.Point(3, 3);
            this.panelExamPage.Name = "panelExamPage";
            this.panelExamPage.Size = new System.Drawing.Size(931, 532);
            this.panelExamPage.TabIndex = 99;
            this.panelExamPage.Visible = false;
            // 
            // lblClockText
            // 
            this.lblClockText.AutoSize = true;
            this.lblClockText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblClockText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblClockText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblClockText.Location = new System.Drawing.Point(654, 15);
            this.lblClockText.Name = "lblClockText";
            this.lblClockText.Size = new System.Drawing.Size(104, 16);
            this.lblClockText.TabIndex = 103;
            this.lblClockText.Text = "Time to finish:";
            // 
            // lblCountTime
            // 
            this.lblCountTime.AutoSize = true;
            this.lblCountTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCountTime.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCountTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCountTime.Location = new System.Drawing.Point(754, 15);
            this.lblCountTime.Name = "lblCountTime";
            this.lblCountTime.Size = new System.Drawing.Size(64, 16);
            this.lblCountTime.TabIndex = 102;
            this.lblCountTime.Text = "00:00:00";
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Firebrick;
            this.btnFinish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnFinish.color = System.Drawing.Color.Firebrick;
            this.btnFinish.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFinish.Image = null;
            this.btnFinish.ImagePosition = 16;
            this.btnFinish.ImageZoom = 50;
            this.btnFinish.LabelPosition = 33;
            this.btnFinish.LabelText = "Send";
            this.btnFinish.Location = new System.Drawing.Point(295, 465);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(106, 48);
            this.btnFinish.TabIndex = 99;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblCountQuestions
            // 
            this.lblCountQuestions.AutoSize = true;
            this.lblCountQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountQuestions.Location = new System.Drawing.Point(21, 13);
            this.lblCountQuestions.Name = "lblCountQuestions";
            this.lblCountQuestions.Size = new System.Drawing.Size(52, 18);
            this.lblCountQuestions.TabIndex = 101;
            this.lblCountQuestions.Text = "label1";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnNext.color = System.Drawing.Color.SeaGreen;
            this.btnNext.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = null;
            this.btnNext.ImagePosition = 18;
            this.btnNext.ImageZoom = 50;
            this.btnNext.LabelPosition = 36;
            this.btnNext.LabelText = "Next >>";
            this.btnNext.Location = new System.Drawing.Point(179, 465);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 48);
            this.btnNext.TabIndex = 7;
            this.btnNext.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrevious.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnPrevious.color = System.Drawing.Color.SeaGreen;
            this.btnPrevious.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.Image = null;
            this.btnPrevious.ImagePosition = 18;
            this.btnPrevious.ImageZoom = 50;
            this.btnPrevious.LabelPosition = 36;
            this.btnPrevious.LabelText = "<< Previous";
            this.btnPrevious.Location = new System.Drawing.Point(43, 465);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(107, 48);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Click += new System.EventHandler(this.btnPreviousQuestion_Click);
            // 
            // qstControl
            // 
            this.qstControl.Location = new System.Drawing.Point(18, 43);
            this.qstControl.Name = "qstControl";
            this.qstControl.Size = new System.Drawing.Size(800, 330);
            this.qstControl.TabIndex = 0;
            // 
            // fpRank
            // 
            this.fpRank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpRank.Location = new System.Drawing.Point(398, 75);
            this.fpRank.Name = "fpRank";
            this.fpRank.Size = new System.Drawing.Size(224, 358);
            this.fpRank.TabIndex = 103;
            // 
            // fpQualifications
            // 
            this.fpQualifications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpQualifications.Location = new System.Drawing.Point(225, 75);
            this.fpQualifications.Name = "fpQualifications";
            this.fpQualifications.Size = new System.Drawing.Size(224, 358);
            this.fpQualifications.TabIndex = 102;
            // 
            // lblRank
            // 
            this.lblRank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRank.Location = new System.Drawing.Point(414, 43);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(105, 24);
            this.lblRank.TabIndex = 101;
            this.lblRank.Text = "Promotion";
            // 
            // lblQualifications
            // 
            this.lblQualifications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQualifications.AutoSize = true;
            this.lblQualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualifications.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQualifications.Location = new System.Drawing.Point(226, 43);
            this.lblQualifications.Name = "lblQualifications";
            this.lblQualifications.Size = new System.Drawing.Size(135, 24);
            this.lblQualifications.TabIndex = 99;
            this.lblQualifications.Text = "Qualifications";
            // 
            // panelFinishExam
            // 
            this.panelFinishExam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFinishExam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFinishExam.Controls.Add(this.btnCntFinish);
            this.panelFinishExam.Controls.Add(this.lblFinishApproved);
            this.panelFinishExam.Controls.Add(this.lblFinishRejected);
            this.panelFinishExam.Controls.Add(this.txtLoadingStandby);
            this.panelFinishExam.Controls.Add(this.LoadingBar);
            this.panelFinishExam.Location = new System.Drawing.Point(410, 230);
            this.panelFinishExam.Name = "panelFinishExam";
            this.panelFinishExam.Size = new System.Drawing.Size(542, 278);
            this.panelFinishExam.TabIndex = 100;
            this.panelFinishExam.Visible = false;
            this.panelFinishExam.VisibleChanged += new System.EventHandler(this.panelFinishExam_VisibleChanged);
            // 
            // btnCntFinish
            // 
            this.btnCntFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCntFinish.Location = new System.Drawing.Point(214, 172);
            this.btnCntFinish.Name = "btnCntFinish";
            this.btnCntFinish.Size = new System.Drawing.Size(130, 28);
            this.btnCntFinish.TabIndex = 10;
            this.btnCntFinish.Text = "Continue";
            this.btnCntFinish.UseVisualStyleBackColor = true;
            this.btnCntFinish.Visible = false;
            this.btnCntFinish.Click += new System.EventHandler(this.btnCntFinishExam_Click);
            // 
            // lblFinishApproved
            // 
            this.lblFinishApproved.AutoSize = true;
            this.lblFinishApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinishApproved.ForeColor = System.Drawing.Color.Green;
            this.lblFinishApproved.Location = new System.Drawing.Point(234, 86);
            this.lblFinishApproved.Name = "lblFinishApproved";
            this.lblFinishApproved.Size = new System.Drawing.Size(90, 20);
            this.lblFinishApproved.TabIndex = 9;
            this.lblFinishApproved.Text = "Approved!";
            this.lblFinishApproved.Visible = false;
            // 
            // lblFinishRejected
            // 
            this.lblFinishRejected.AutoSize = true;
            this.lblFinishRejected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinishRejected.ForeColor = System.Drawing.Color.Red;
            this.lblFinishRejected.Location = new System.Drawing.Point(236, 89);
            this.lblFinishRejected.Name = "lblFinishRejected";
            this.lblFinishRejected.Size = new System.Drawing.Size(86, 20);
            this.lblFinishRejected.TabIndex = 8;
            this.lblFinishRejected.Text = "Rejected!";
            this.lblFinishRejected.Visible = false;
            // 
            // txtLoadingStandby
            // 
            this.txtLoadingStandby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtLoadingStandby.ForeColor = System.Drawing.Color.Green;
            this.txtLoadingStandby.Location = new System.Drawing.Point(3, 83);
            this.txtLoadingStandby.Name = "txtLoadingStandby";
            this.txtLoadingStandby.ReadOnly = true;
            this.txtLoadingStandby.Size = new System.Drawing.Size(532, 26);
            this.txtLoadingStandby.TabIndex = 7;
            this.txtLoadingStandby.Text = "Your exam is being reviewed";
            this.txtLoadingStandby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadingBar
            // 
            this.LoadingBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingBar.Location = new System.Drawing.Point(90, 133);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(378, 23);
            this.LoadingBar.TabIndex = 3;
            // 
            // ChronomiterTimer
            // 
            this.ChronomiterTimer.Interval = 1000;
            this.ChronomiterTimer.Tick += new System.EventHandler(this.ChronomiterTimer_Tick);
            // 
            // Loading
            // 
            this.Loading.Interval = 50;
            this.Loading.Tick += new System.EventHandler(this.Loading_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.pMenuBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panelFinishExam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExamCenter_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pMenuBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelExamPage.ResumeLayout(false);
            this.panelExamPage.PerformLayout();
            this.panelFinishExam.ResumeLayout(false);
            this.panelFinishExam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.FlowLayoutPanel fpTyperatings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pMenuBar;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuHome;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTyperatings;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRank;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQualifications;
        private System.Windows.Forms.FlowLayoutPanel fpRank;
        private System.Windows.Forms.FlowLayoutPanel fpQualifications;
        public System.Windows.Forms.Panel panelExamPage;
        private Bunifu.Framework.UI.BunifuTileButton btnNext;
        private Bunifu.Framework.UI.BunifuTileButton btnPrevious;
        private ExamCenterComponents.QuestionCtrl qstControl;
        private Bunifu.Framework.UI.BunifuTileButton btnFinish;
        private System.Windows.Forms.Panel panelFinishExam;
        private System.Windows.Forms.Label lblCountQuestions;
        private System.Windows.Forms.Label lblClockText;
        private System.Windows.Forms.Label lblCountTime;
        private System.Windows.Forms.Timer ChronomiterTimer;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Timer Loading;
        private System.Windows.Forms.Label lblFinishApproved;
        private System.Windows.Forms.Label lblFinishRejected;
        private System.Windows.Forms.TextBox txtLoadingStandby;
        private System.Windows.Forms.Button btnCntFinish;
    }
}