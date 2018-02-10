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

        public QuestionCtrl()
        {
            InitializeComponent();

        }

        public delegate void AnswerSelected(object sender);
        public event AnswerSelected OnAnswerSelected;

        int IDQuest = 0;

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
                
                if(IDQuest <= 3)
                fpAnswers.TabIndex = ++IDQuest;
                else
                IDQuest = 0;

                e.cboxAnswer.TabIndex = IDQuest;

                possibleSelect.Add( new PossibleSelect(IDQuest, question));

                if (fpAnswers.TabIndex == Exam.Questions[question].SelectedAnswer)
                {
                    e.cboxAnswer.Checked = true;
                }
                else
                {
                    e.cboxAnswer.Checked = false;
                }


                if (IDQuest == 4)
                    IDQuest = 0;

            }


        }

        public void SendInformationsToSendExam()
        {

        }

        private void E_OnAnswerSelected(object sender, bool correct, int IDCheck)
        {

            Exam.Questions[question].IsSelectedAnswerCorrect = correct;

            Exam.Questions[question].SelectedAnswer = IDCheck;

            Update(question);

        }
    }
}
