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
    public partial class EpsConfirm : UserControl
    {


        public EpsConfirm()
        {

            InitializeComponent();
        }

        public void GetEps(int eps)
        {
            txtEpsInfo.Text = String.Format("Will be removed {0} ep's from your account to begin the exam!", eps.ToString());
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            var DBoard = this.Parent as Dashboard;

            DBoard.examPage.Show();
            Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
