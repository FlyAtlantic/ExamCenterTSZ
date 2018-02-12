using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenterTSZ.UI.ExamCenterComponents
{
    public partial class AnswerCtrl : UserControl
    {
        Answer answerBool;


        public AnswerCtrl(Answer answer)
        {
            InitializeComponent();           

            Update(answer);
        }

        public void Update(Answer answer)
        {

            cboxAnswer.Text = answer.Text;
            answerBool = answer;          
        }

        public delegate void AnswerCorrect(object sender, bool correct, int IDChk);
        public event AnswerCorrect OnAnswerCorrect;

        private void cboxAnswer_Click(object sender, EventArgs e)
        {
            if (cboxAnswer.Checked)
            {
                if (OnAnswerCorrect != null)
                    OnAnswerCorrect(this, answerBool.Correct && cboxAnswer.Checked, cboxAnswer.TabIndex);
            }
        }
    }
}
