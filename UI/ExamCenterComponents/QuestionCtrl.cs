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
    public partial class QuestionCtrl : UserControl
    {
        int questionSelected;

        public Question Question
        { get; private set; }

        public QuestionCtrl()
        {
            InitializeComponent();

        }
        public delegate void AnswerSelected(object sender, int selected);
        public event AnswerSelected OnAnswerSelected;
        public void Update(int question)
        {
            txtQuestion.Text = Exam.Questions[question].Text;
            this.Question = Exam.Questions[question];
            
            fpAnswers.Controls.Clear();
            foreach (Answer a in Exam.Questions[question].Answers)
            {
                AnswerCtrl e = new AnswerCtrl(a);

                e.OnAnswerCorrect += E_OnAnswerSelected;

                fpAnswers.Controls.Add(e);
            }

        }

        private void E_OnAnswerSelected(object sender, bool correct, int selected )
        {

            questionSelected = selected;

            Question.IsSelectedAnswerCorrect = correct;

            checkBox1.Checked = Question.IsSelectedAnswerCorrect;

            if (OnAnswerSelected != null)
                OnAnswerSelected(this, questionSelected);
        }
    }
}
