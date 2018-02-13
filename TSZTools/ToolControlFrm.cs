using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSZTools
{
    public partial class ToolControlFrm : Form
    {
        public ToolControlFrm()
        {
            InitializeComponent();

            Width = 720;
            Height = 131;

        }

        private void btnMetars_Click(object sender, EventArgs e)
        {
            metarsCtrl.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnOcenicReport_Click(object sender, EventArgs e)
        {
            Width = 720;
            Height = 507;

            oceanicReportCtrl.Show();
        }
    }
}
