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
    public partial class FinishExam : UserControl
    {
        public FinishExam()
        {
            InitializeComponent();
        }

        int t = 0;

        private void Loading_Tick(object sender, EventArgs e)
        {
            t = t + 1;

            if (t == 100)
            {
                Loading.Stop();

                txtLoadingStandby.Visible = false;
                btnCntFinishExam.Visible = true;

                //Exam True or False

                lblFinishApproved.Visible = true;


                //lblFinishRejected.Visible = true;

            }

            string tt = Convert.ToString(t);

            if (t > 100)
            {
                t = 100;

                LoadingBar.Value = t;

            }
            else
                LoadingBar.Value = t;
        }


        //private void btnCntFinishExam_Click(object sender, EventArgs e)
        //{
        //    panelFinishExam.Visible = false;
        //    panelExamPage.Visible = false;
        //    panelExamPage.Enabled = true;
        //}
    }
}
