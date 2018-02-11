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

        int AnswerCorrect = 0;

        public void Update()
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

                e.cboxAnswer.Enabled = true;
                

                if (IDQuest == 4)
                    IDQuest = 0;
            }
            txtQuestion.ReadOnly = false;
        }

        public void SaveEditQuestion(int questionID, int IDCheck)
        {

            string questionText = txtQuestion.Text;

            int correctAnswer = AnswerCorrect;

            string answer1 = null;

            string answer2 = null;

            string answer3 = null;

            string answer4 = null;

            foreach (AdminAnswer a in AdminViewQuestions.AdminQuestions[question].AdminAnswers)
            {

                AdminEditAnswer Answer = new AdminEditAnswer(a);

                if (answer1 == null)
                    answer1 = Answer.txtEditAnswer.Text;
                if (answer2 == null && Answer.txtEditAnswer.Text != answer1)
                    answer2 = Answer.txtEditAnswer.Text;
                if (answer3 == null && Answer.txtEditAnswer.Text != answer1 && Answer.txtEditAnswer.Text != answer2)
                    answer3 = Answer.txtEditAnswer.Text;
                if (answer4 == null && Answer.txtEditAnswer.Text != answer1 && Answer.txtEditAnswer.Text != answer2 && Answer.txtEditAnswer.Text != answer3)
                    answer4 = Answer.txtEditAnswer.Text;

            }

            fpAnswers.Controls.Clear();

            SaveQuestion.SaveEditQuestion(questionID, txtQuestion.Text, answer1, answer2, answer3, answer4, correctAnswer);

            Update();

            txtQuestion.ReadOnly = true;

        }

        private void E_OnAnswerSelected(object sender, int IDCheck)
        {
            AdminViewOnlyOneQuestionToEdit.OnlyOneFromSql(AdminViewQuestions.AdminQuestions[question].QuestionID);

            EditQuestion(IDCheck);

            AnswerCorrect = IDCheck;
        }
    }
}
