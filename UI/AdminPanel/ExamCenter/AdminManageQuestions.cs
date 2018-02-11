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

            adminQuestionCtrl.EditQuestion(btnEditQuestion.TabIndex, 0);

            btnEditQuestion.Visible = false;

            btnBackEdit.Visible = true;

        }

        private void btnBackEdit_Click(object sender, EventArgs e)
        {
            btnBackEdit.Visible = false;

            btnEditQuestion.Visible = true;

            adminQuestionCtrl.txtQuestion.ReadOnly = true;

            adminQuestionCtrl.Update(btnEditQuestion.TabIndex);
        }
    }
}
