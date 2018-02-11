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
    public partial class AdminAnswerCtrl : UserControl
    {
        AdminAnswer answerBool;


        public AdminAnswerCtrl(AdminAnswer answer)
        {
            InitializeComponent();

            Update(answer);
        }

        public void Update(AdminAnswer answer)
        {
            cboxAnswer.Text = answer.Text;
            answerBool = answer;
        }
    }
}
