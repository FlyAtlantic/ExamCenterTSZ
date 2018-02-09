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
    public partial class ProcessExam : UserControl
    {
         

        public ProcessExam()
        {
            InitializeComponent();

            lblFinishApproved.Visible = false;
            lblFinishRejected.Visible = false;
            txtLoadingStandby.Visible = true;

        }

        int t = 0;

        private void Loading_Tick(object sender, EventArgs e)
        {
            t = t + 1;

            if (t == 100)
            {
                Loading.Stop();

                txtLoadingStandby.Visible = false;
                btnCntFinish.Visible = true;

                //Exam True or False
                if(Exam.CalculateScore() >= 75)
                {
                    txtLoadingStandby.Visible = false;
                    lblFinishApproved.Text = String.Format("Approved with {0}% !", Exam.CalculateScore());
                    lblFinishApproved.Visible = true;
                }
                else
                {
                    txtLoadingStandby.Visible = false;
                    lblFinishRejected.Text = String.Format("Recejted with {0}% !", Exam.CalculateScore());
                    lblFinishRejected.Visible = true;
                }

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

        public void Start()
        {
            Loading.Start();

            var parent = this.Parent as Dashboard;

        }

        private void btnCntFinish_Click(object sender, EventArgs e)
        {           

            t = 0;
            Dashboard a = new Dashboard();
            var DBoard = this.Parent as Dashboard;

            DBoard.btnExitApp.Enabled = true;

            a.Show();
            a.examCenterCtrl.Actions();

            Hide();


        }
    }
}
