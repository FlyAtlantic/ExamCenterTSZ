﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamCenterTSZ.UI.ExamCenterComponents;

namespace ExamCenterTSZ.UI.ExamCenterInstructor
{
    public partial class Re_ViewExamCtrl : UserControl
    {
        
            int h;
            int m;
            int s;
            int sBar;
            int t = 0;

        public int CurrentQuestion
        { get; set; }

        int CountQuestions;

        public Re_ViewExamCtrl()
        {
            InitializeComponent();
        }

        public void StartExam()
        {
            btnNext.Visible = true;
            btnFinish.Visible = false;

            ChronometerStart();

            CurrentQuestion = 0;

            qstControl.Update(CurrentQuestion);

            CountQuestions = CurrentQuestion + 1;
            if (Exam.Questions.Count > 1)
                btnNext.Enabled = true;

            lblCountQuestions.Text = String.Format("Question {0} of {1}", CountQuestions.ToString(), Exam.Questions.Count.ToString());
        }

        public void GetQuestions(int examID, int eps)
        {

            btnNext.Enabled = false;
            btnPrevious.Enabled = false;

            Exam.FromSQL(Convert.ToInt32(examID));
            StartExam();

            var DBoard = this.Parent as Dashboard;
            DBoard.epsConfirm.GetEps(eps);

        }

        public void ChronometerStart()
        {
            h = 1;
            m = 0;
            s = 0;

            sBar = 0;


        }

        public void ChronometerStop()
        {

        }

        private void ChronomiterTimer_Tick(object sender, EventArgs e)
        {
            s = s - 1;

            sBar = sBar + 1;

            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }

            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }

            if (h == 0 && m == 0 && s == 0)
            {


                //END of Time


            }

            string hh = Convert.ToString(h);
            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);
            int ssBar = (sBar * 100) / 3600;

            if (h == 0)
                lblCountTime.Text = String.Format("0{0}:{1}:{2}", hh, mm, ss);
            if (h == 0 && m < 0)
                lblCountTime.Text = String.Format("0{0}:0{1}:{2}", hh, mm, ss);
            if (h == 0 && m < 10 && s < 10)
                lblCountTime.Text = String.Format("0{0}:0{1}:0{2}", hh, mm, ss);
            if (h == 0 && s < 10)
                lblCountTime.Text = String.Format("0{0}:{1}:0{2}", hh, mm, ss);

            pBarProgress.Value = ssBar;

        }

        private void ExamPage_Load(object sender, EventArgs e)
        {
            var DBoard = this.Parent as Dashboard;

            DBoard.btnExitApp.Enabled = false;

        }
    }
}

