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
    public partial class AdminEditAnswer : UserControl
    {
        AdminAnswer answerBool;


        public AdminEditAnswer(AdminAnswer answer)
        {
            InitializeComponent();

            Update(answer);
        }

        public void Update(AdminAnswer answer)
        {
            txtEditAnswer.Text = answer.Text;
            answerBool = answer;
        }

        public delegate void AnswerSelected(object sender, int IDChk);
        public event AnswerSelected OnAnswerSelected;

        public delegate void TextChanged1(object sender, string textAnswer);
        public event TextChanged1 OnATextChanged;

        private void cboxAnswer_Click(object sender, EventArgs e)
        {
            if (cboxAnswer.Checked)
            {
                if (OnAnswerSelected != null)
                    OnAnswerSelected(this, cboxAnswer.TabIndex);
            }
        }

        private void txtEditAnswer_TextChanged(object sender, EventArgs e)
        {
                if (OnATextChanged != null)
                    OnATextChanged(this, txtEditAnswer.Text);
        }
    }
}
