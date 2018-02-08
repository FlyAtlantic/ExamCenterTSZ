using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenterTSZ.UI.ExamCenterComponents
{
    public partial class ExamPage : UserControl
    {
        
        int h;
        int m;
        int s;
        int sBar;
        int MaxBar;
        int t = 0;

        public int CurrentQuestion
        { get; set; }

        int CountQuestions;

        public ExamPage()
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

        private void btnPreviousQuestion_Click(object sender, EventArgs e)
        {

            btnNext.Enabled = true;
            btnNext.Visible = true;
            btnFinish.Visible = false;

            CurrentQuestion--;
            qstControl.Update(CurrentQuestion);

            CountQuestions = CurrentQuestion + 1;
            if (CurrentQuestion == 0)
                btnPrevious.Enabled = false;

            lblCountQuestions.Text = String.Format("Question {0} of {1}", CountQuestions.ToString(), Exam.Questions.Count.ToString());

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {


            btnPrevious.Enabled = true;

            CurrentQuestion++;
            qstControl.Update(CurrentQuestion);

            CountQuestions = CurrentQuestion + 1;
            if (CurrentQuestion == Exam.Questions.Count - 1)
            {
                btnNext.Visible = false;
                btnFinish.Visible = true;
            }

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

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close me?",
                    "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                var DBoard = this.Parent as Dashboard;

                ChronomiterTimer.Stop();

                Hide();

                DBoard.processExam.Start();

                DBoard.processExam.Show();


            }
        }

        public void ChronometerStart()
        {
            h = 1;
            m = 0;
            s = 0;

            sBar = 0;
            MaxBar = 3600;

            ChronomiterTimer.Start();
        }

        public void ChronometerStop()
        {
            ChronomiterTimer.Stop();
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
                ChronomiterTimer.Stop();

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
            if (s < 10)
                lblCountTime.Text = String.Format("{0}:{1}:0{2}", hh, mm, ss);

        }

    }
}
