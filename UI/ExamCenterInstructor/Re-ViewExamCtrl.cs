using System;
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

            CurrentQuestion = 0;

            lastQuestionCtrl.Update(CurrentQuestion);

            CountQuestions = CurrentQuestion + 1;
            if (LastExam.LastQuestions.Count > 1)
                btnNext.Enabled = true;

            lblCountQuestions.Text = String.Format("Question {0} of {1}", CountQuestions.ToString(), LastExam.LastQuestions.Count.ToString());

            pBarProgress.MaximumValue = LastExam.LastQuestions.Count;
            pBarProgress.Value = CountQuestions;
        }

        public void GetQuestions(int examID)
        {

            btnNext.Enabled = false;
            btnPrevious.Enabled = false;

            LastExam.LastExamFromSQL(Convert.ToInt32(examID));
            StartExam();

        }

        
        private void btnPreviousQuestion_Click(object sender, EventArgs e)
        {

            btnNext.Enabled = true;
            btnNext.Visible = true;
            btnFinish.Visible = false;

            CurrentQuestion--;
            lastQuestionCtrl.Update(CurrentQuestion);

            CountQuestions = CurrentQuestion + 1;
            if (CurrentQuestion == 0)
                btnPrevious.Visible = false;

            lblCountQuestions.Text = String.Format("Question {0} of {1}", CountQuestions.ToString(), LastExam.LastQuestions.Count.ToString());
            pBarProgress.Value = CountQuestions--;

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {


            btnPrevious.Enabled = true;

            CurrentQuestion++;
            lastQuestionCtrl.Update(CurrentQuestion);

            CountQuestions = CurrentQuestion + 1;
            if (CurrentQuestion == LastExam.LastQuestions.Count - 1)
            {
                btnNext.Visible = false;
                btnFinish.Visible = true;
            }
            else
            {
                btnPrevious.Visible = true;
            }

            lblCountQuestions.Text = String.Format("Question {0} of {1}", CountQuestions.ToString(), LastExam.LastQuestions.Count.ToString());
            pBarProgress.Value = CountQuestions++;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close me?",
                    "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                

                Hide();


            }
        }
    }
}

