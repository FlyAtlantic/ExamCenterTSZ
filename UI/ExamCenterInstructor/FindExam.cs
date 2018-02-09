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

            EInstructor.re_ViewExamCtrl.Show();

            //passa assignID
            EInstructor.re_ViewExamCtrl.GetQuestions(12);
        }
    }
}
