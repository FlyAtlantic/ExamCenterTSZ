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

namespace ExamCenterTSZ.UI.DashboardComponents
{
    public partial class ButtonTyperating : UserControl
    {


        bool panel = false;

        int eps = 0;

        public ButtonTyperating(string typerating, int examid, int eps)
        {
            InitializeComponent();

            Update(typerating, examid, eps);

        }

        public void Update(string typerating, int examid, int eps)
        {
            btnTyperating.Text = typerating.ToString();
            btnTyperating.Tag = examid;

            this.eps = eps;
        }

        public delegate void ClickButtonExam(int buttonValue, int eps);
        public event ClickButtonExam OnClickButtonExam;

        private void btnTyperating_Click(object sender, EventArgs e)
        {
            if (OnClickButtonExam != null)
                OnClickButtonExam(Convert.ToInt32(btnTyperating.Tag), eps);

            //var DBoard = this.Parent as ExamCenter;

            //DBoard.examPage.GetQuestions(Convert.ToInt32(btnTyperating.Tag), eps);

            //DBoard.epsConfirm.Show();

            //DBoard.examPage.Show();

            Hide();

        }
    }
}
