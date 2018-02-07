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
        int question;

        public QuestionCtrl()
        {
            InitializeComponent();

        }
        public delegate void AnswerSelected(object sender);
        public event AnswerSelected OnAnswerSelected;
        public void Update(int question)
        {
            this.question = question;

            txtQuestion.Text = Exam.Questions[question].Text;
            
            fpAnswers.Controls.Clear();
            foreach (Answer a in Exam.Questions[question].Answers)
            {
                AnswerCtrl e = new AnswerCtrl(a);

                e.OnAnswerCorrect += E_OnAnswerSelected;

                fpAnswers.Controls.Add(e);
            }

        }

        private void E_OnAnswerSelected(object sender, bool correct )
        {

            Exam.Questions[question].IsSelectedAnswerCorrect = correct;

        }
    }
}
