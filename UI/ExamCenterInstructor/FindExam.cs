using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenterTSZ.UI.ExamCenterInstructor
{
    public partial class FindExam : UserControl
    {
        public FindExam()
        {
            InitializeComponent();

        }

        private void btnFindExam_Click(object sender, EventArgs e)
        {
            var EInstructor = this.Parent as ExamInstructorCtrl;

            if (txtFindAssign.Text != "")
            {
                EInstructor.re_ViewExamCtrl.Show();
                EInstructor.re_ViewExamCtrl.GetQuestions(Convert.ToInt32(txtFindAssign.Text));
            }
            else
            {
                EInstructor.re_ViewExamCtrl.Hide();
            }

        }

        private void txtFindAssign_Enter(object sender, EventArgs e)
        {
            txtFindAssign.Text = null;
        }

        private void txtFindAssign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
