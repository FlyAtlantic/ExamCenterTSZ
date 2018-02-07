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
        public List<Answer> Answers
        { get; private set; }

        public QuestionCtrl()
        {
            InitializeComponent();
        }

        public void Update(Question question)
        {
            txtQuestion.Text = question.Text;
            Answers = question.Answers;

            fpAnswers.Controls.Clear();
            foreach (Answer a in Answers)
                fpAnswers.Controls.Add(new AnswerCtrl(a));
        }
    }
}
