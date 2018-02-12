using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ExamCenterTSZ.UI.AdminPanel.ExamCenter.AdminQuestionNewEdit;

namespace ExamCenterTSZ.UI.AdminPanel.ExamCenter
{
    public partial class AdminManageQuestions : UserControl
    {
        public AdminManageQuestions()
        {
            InitializeComponent();
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {

            btnEditQuestion.Visible = false;

            btnBackView.Visible = false;

            btnBackEdit.Visible = true;

            btnSaveEditQuestion.Visible = true;

            adminQuestionNewEdit.txtQuestion.ReadOnly = false;

            adminQuestionNewEdit.GetExamForView(btnEditQuestion.TabIndex);

            adminQuestionNewEdit.Show();
        }

        private void btnBackEdit_Click(object sender, EventArgs e)
        {           

            btnBackEdit.Visible = false;

            btnSaveEditQuestion.Visible = false;

            btnEditQuestion.Visible = true;

            btnBackView.Visible = true;

            adminQuestionCtrl.txtQuestion.ReadOnly = true;

            adminQuestionCtrl.Update();

            adminQuestionNewEdit.Hide();

        }

        private void btnBackView_Click(object sender, EventArgs e)
        {

            var QControl = this.Parent as AdminQuestionsGridCtrl;

            QControl.gridViewQuestions.Show();


            Hide();
        }


        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            AdminViewQuestions.OnlyDeleteOneQuestionFromSql(btnEditQuestion.TabIndex);

            adminQuestionCtrl.Update();
        }

        private void btnSaveEditQuestion_Click(object sender, EventArgs e)
        {
            btnBackView.Visible = true;

            btnBackEdit.Visible = false;

            btnEditQuestion.Visible = true;

            adminQuestionNewEdit.EditQuestion(btnEditQuestion.TabIndex, adminQuestionNewEdit.txtQuestion.Text, adminQuestionNewEdit.txtEditAnswer1.Text, adminQuestionNewEdit.txtEditAnswer2.Text, adminQuestionNewEdit.txtEditAnswer3.Text, adminQuestionNewEdit.txtEditAnswer4.Text, ExamQuestionsNewEdit.AnswerCorrect);

            adminQuestionNewEdit.Hide();

            AdminViewQuestions.OnlyOneFromSql(Convert.ToInt32(btnEditQuestion.TabIndex));

            adminQuestionCtrl.Update();

            adminQuestionCtrl.txtQuestion.ReadOnly = true;

            btnSaveEditQuestion.Visible = false;

        }

    }
}
