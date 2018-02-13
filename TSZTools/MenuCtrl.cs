using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSZTools
{
    public partial class MenuCtrl : UserControl
    {        

        public MenuCtrl()
        {
            InitializeComponent();          

        }

        private void btnMetars_Click(object sender, EventArgs e)
        {
            var tools = this.Parent as ToolControlFrm;

            tools.metarsCtrl.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var tools = this.Parent as ToolControlFrm;
            tools.Hide();
        }

        private void btnOcenicReport_Click(object sender, EventArgs e)
        {
            var tools = this.Parent as ToolControlFrm;

            tools.Width = 720;
            tools.Height = 507;

            tools.oceanicReportCtrl.Show();
        }

    }
}
