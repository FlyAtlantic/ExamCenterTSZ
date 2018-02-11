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

        public int IDQuest = 0;

        public int AnswerCorrect = 0;

        public int QuestionID;   

        public int correctAnswer;

        public new void Update()
        {

            this.question = 0;

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

                var Manage = this.Parent as AdminManageQuestions;

                Manage.btnSaveEditQuestion.TabIndex = question;
            }
        }

        public void EditQuestion(int IDCheck)
        {
            
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
                e.txtEditAnswer.TabIndex = IDQuest;

                AnswerCorrect = AdminViewQuestions.AdminQuestions[question].AnswerCorrect;

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

                e.cboxAnswer.Enabled = false;
                

                if (IDQuest == 4)
                    IDQuest = 0;
            }
            txtQuestion.ReadOnly = false;
        }

        public void SendToDatabaseEditQuestionAnswer()
        {
            AdminViewQuestions.SaveEditQuestion(QuestionID, txtQuestion.Text, AdminAnswer.EditAnswer1, AdminAnswer.EditAnswer2, AdminAnswer.EditAnswer3, AdminAnswer.EditAnswer4, correctAnswer);

            Update();

            txtQuestion.ReadOnly = true;
        }
      

        private void E_OnAnswerSelected(object sender, int IDCheck)
        {
            AdminViewQuestions.OnlyOneFromSql(AdminViewQuestions.AdminQuestions[question].QuestionID);

            //EditQuestion(IDCheck);

            AnswerCorrect = IDCheck;
        }

    }
}
