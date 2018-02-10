using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenterTSZ.UI.ExamCenterComponents.ViewMyExams
{
    public partial class MyAnswer : UserControl
    {
        MyLastAnswer answerBool;


        public MyAnswer(MyLastAnswer answer)
        {
            InitializeComponent();

            Update(answer);
        }

        public void Update(MyLastAnswer answer)
        {

            cboxAnswer.Text = answer.Text;
            answerBool = answer;
        }

    }
}
