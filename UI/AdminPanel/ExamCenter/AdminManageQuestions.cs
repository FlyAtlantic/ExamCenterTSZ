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
    public partial class AdminManageQuestions : UserControl
    {
        public AdminManageQuestions()
        {
            InitializeComponent();
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {

            adminQuestionCtrl.EditQuestion(0);

            btnEditQuestion.Visible = false;

            btnBackView.Visible = false;

            btnBackEdit.Visible = true;

            btnSaveEditQuestion.Visible = true;

        }

        private void btnBackEdit_Click(object sender, EventArgs e)
        {
            btnBackEdit.Visible = false;

            btnSaveEditQuestion.Visible = false;

            btnEditQuestion.Visible = true;

            btnBackView.Visible = true;

            adminQuestionCtrl.txtQuestion.ReadOnly = true;

            adminQuestionCtrl.Update();
        }

        private void btnBackView_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            AdminViewOnlyOneQuestionToEdit.OnlyDeleteOneQuestionFromSql(btnEditQuestion.TabIndex);

            adminQuestionCtrl.Update();
        }

        private void btnSaveEditQuestion_Click(object sender, EventArgs e)
        {
            adminQuestionCtrl.SaveEditQuestion(btnEditQuestion.TabIndex, 0);

            AdminViewOnlyOneQuestionToEdit.OnlyOneFromSql(btnEditQuestion.TabIndex);

            adminQuestionCtrl.Update();
        }
    }
}
