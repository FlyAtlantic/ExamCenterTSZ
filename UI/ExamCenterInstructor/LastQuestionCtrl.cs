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
    public partial class LastQuestionCtrl : UserControl
    {
        int question;

        public class PossibleSelect
        {
            public int index
            { get; set; }

            public int quest
            { get; set; }

            public PossibleSelect(int Index, int Quest)
            {
                this.index = Index;
                this.quest = Quest;
            }
        }

        public class BoxSelected
        {
            public int ID
            { get; set; }

            public int quest
            { get; set; }

            public BoxSelected(int ID, int Quest)
            {
                this.ID = ID;
                this.quest = Quest;
            }
        }

        public List<PossibleSelect> CheckPossibleSelect
        { get; set; }

        public List<BoxSelected> CheckBoxSelected
        { get; set; }

        List<PossibleSelect> possibleSelect = new List<PossibleSelect>();
        List<BoxSelected> Selected = new List<BoxSelected>();

        public LastQuestionCtrl()
        {
            InitializeComponent();

        }

        public delegate void AnswerSelected(object sender);
        public event AnswerSelected OnAnswerSelected;

        int IDQuest = 0;

        public void Update(int question)
        {

            this.question = question;

            if(LastExam.LastQuestions.Count != 0) { 
                txtQuestion.Text = LastExam.LastQuestions[question].Text;

                fpAnswers.Controls.Clear();

                foreach (LastAnswer a in LastExam.LastQuestions[question].LastAnswers)
                {
                    LastAnswerCtrl e = new LastAnswerCtrl(a);


                    fpAnswers.Controls.Add(e);

                    if (IDQuest <= 3)
                        fpAnswers.TabIndex = ++IDQuest;
                    else
                        IDQuest = 0;

                    e.cboxAnswer.TabIndex = IDQuest;

                    possibleSelect.Add(new PossibleSelect(IDQuest, question));

                    if (fpAnswers.TabIndex == LastExam.LastQuestions[question].SelectedAnswer)
                    {
                        e.cboxAnswer.Checked = true;

                        e.cboxAnswer.BackColor = Color.Orange;
                    }
                    else
                    {
                        e.cboxAnswer.Checked = false;
                    }

                    if (fpAnswers.TabIndex == LastExam.LastQuestions[question].IsSelectedAnswerCorrect)
                    {
                        e.cboxAnswer.BackColor = Color.Green;
                    }


                    if (IDQuest == 4)
                        IDQuest = 0;
                }
            }
            else
            {
                var ReviewExam = this.Parent as Re_ViewExamCtrl;

                ReviewExam.Hide();

                if (MessageBox.Show("Exam ID not exist!",
                     "Exam ID not exist!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                     MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    
                }
            }

        }

        private void E_OnAnswerSelected(object sender, bool correct, int IDCheck)
        {

            //LastExam.LastQuestions[question].IsSelectedAnswerCorrect = correct;

            //LastExam.LastQuestions[question].SelectedAnswer = IDCheck;

            Update(question);

        }
    }
}

