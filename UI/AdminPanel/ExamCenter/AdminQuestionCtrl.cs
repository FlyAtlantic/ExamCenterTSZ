using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenterTSZ.UI.AdminPanel.ExamCenter
{
    public partial class AdminQuestionCtrl : UserControl
    {
        int question;

        public AdminQuestionCtrl()
        {
            InitializeComponent();

        }

        int IDQuest = 0;

        public void Update(int question)
        {

            this.question = question;


            txtQuestion.Text = AdminViewQuestions.AdminQuestions[question].Text;

            fpAnswers.Controls.Clear();

            foreach (AdminAnswer a in AdminViewQuestions.AdminQuestions[question].AdminAnswers)
            {
                AdminAnswerCtrl e = new AdminAnswerCtrl(a);


                fpAnswers.Controls.Add(e);

                if (IDQuest <= 3)
                    fpAnswers.TabIndex = ++IDQuest;
                else
                    IDQuest = 0;

                e.cboxAnswer.TabIndex = IDQuest;

                if (fpAnswers.TabIndex == AdminViewQuestions.AdminQuestions[question].AnswerCorrect)
                {
                    e.cboxAnswer.Checked = true;
                    e.cboxAnswer.BackColor = Color.Green;
                }


                if (IDQuest == 4)
                    IDQuest = 0;
            }
        }

        public void EditQuestion(int question, int IDCheck)
        {
            this.question = question;
            
            fpAnswers.Controls.Clear();

            foreach (AdminAnswer a in AdminViewQuestions.AdminQuestions[question].AdminAnswers)
            {
                AdminEditAnswer e = new AdminEditAnswer(a);

                e.OnAnswerSelected += E_OnAnswerSelected;

                fpAnswers.Controls.Add(e);

                if (IDQuest <= 3)
                    fpAnswers.TabIndex = ++IDQuest;
                else
                    IDQuest = 0;

                e.cboxAnswer.TabIndex = IDQuest;

                if (txtQuestion.ReadOnly == true) {
                    if (fpAnswers.TabIndex == AdminViewQuestions.AdminQuestions[question].AnswerCorrect)
                    {
                        e.cboxAnswer.Checked = true;
                    }
                }
                else
                {
                    if (fpAnswers.TabIndex == IDCheck)
                    {
                        e.cboxAnswer.Checked = true;
                    }
                    else
                    {
                        e.cboxAnswer.Checked = false;
                    }
                }

                e.cboxAnswer.Enabled = true;
                

                if (IDQuest == 4)
                    IDQuest = 0;
            }
            txtQuestion.ReadOnly = false;
        }

        private void E_OnAnswerSelected(object sender, int IDCheck)
        {
            EditQuestion(question, IDCheck);
        }
    }
}
