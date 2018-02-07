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
        public AnswerCtrl(Answer answer)
        {
            InitializeComponent();

            Update(answer);
        }

        public void Update(Answer answer)
        {
            cboxAnswer.Text = answer.Text;
        }

        public delegate void AnswerSelected(object sender, EventArgs e);
        public event AnswerSelected OnAnswerSelected;

        private void chkSelected_CheckedChanged(object sender, EventArgs e)
        {
            if (OnAnswerSelected != null)
                OnAnswerSelected(this, e);
        }
    }
}
