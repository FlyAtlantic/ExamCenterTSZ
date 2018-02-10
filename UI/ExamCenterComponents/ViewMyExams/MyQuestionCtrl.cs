using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenterTSZ.UI.ExamCenterComponents.ViewMyExams
{
    public partial class MyQuestionCtrl : UserControl
    {
        int question;

        public class MyPossibleSelect
        {
            public int index
            { get; set; }

            public int quest
            { get; set; }

            public MyPossibleSelect(int Index, int Quest)
            {
                this.index = Index;
                this.quest = Quest;
            }
        }

        public class MyBoxSelected
        {
            public int ID
            { get; set; }

            public int quest
            { get; set; }

            public MyBoxSelected(int ID, int Quest)
            {
                this.ID = ID;
                this.quest = Quest;
            }
        }

        public List<MyPossibleSelect> CheckPossibleSelect
        { get; set; }

        public List<MyBoxSelected> CheckBoxSelected
        { get; set; }

        List<MyPossibleSelect> possibleSelect = new List<MyPossibleSelect>();
        List<MyBoxSelected> Selected = new List<MyBoxSelected>();

        public MyQuestionCtrl()
        {
            InitializeComponent();

        }

        int IDQuest = 0;

        public void Update(int question)
        {

            this.question = question;

            txtQuestion.Text = MyExams.LastQuestions[question].Text;

            fpAnswers.Controls.Clear();

            foreach (MyLastAnswer a in MyExams.LastQuestions[question].LastAnswers)
            {
                MyAnswer e = new MyAnswer(a);

                fpAnswers.Controls.Add(e);

                if (IDQuest <= 3)
                    fpAnswers.TabIndex = ++IDQuest;
                else
                    IDQuest = 0;

                e.cboxAnswer.TabIndex = IDQuest;

                possibleSelect.Add(new MyPossibleSelect(IDQuest, question));

                if (fpAnswers.TabIndex == MyExams.LastQuestions[question].SelectedAnswer)
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

    }
}
