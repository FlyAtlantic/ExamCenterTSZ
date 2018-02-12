using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamCenterTSZ.UI.ExamCenterComponents;

namespace ExamCenterTSZ.UI.ExamCenterInstructor
{
    public partial class LastAnswerCtrl : UserControl
    {
        LastAnswer answerBool;


        public LastAnswerCtrl(LastAnswer answer)
        {
            InitializeComponent();

            Update(answer);
        }

        public void Update(LastAnswer answer)
        {

            cboxAnswer.Text = answer.Text;
            answerBool = answer;
        }      
    }
}
