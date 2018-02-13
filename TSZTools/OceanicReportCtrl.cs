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
    public partial class OceanicReportCtrl : UserControl
    {
        public OceanicReportCtrl()
        {
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var Tools = this.Parent as ToolControlFrm;

            Tools.Width = 720;
            Tools.Height = 131;

            Hide();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            OceanicReport.OceanicReports(txtCallsign.Text, txtPosition.Text,Convert.ToInt32(cboxHourPosition.SelectedValue), Convert.ToInt32(cboxMinutesPosition.SelectedValue), cboxFlightLevel.SelectedValue.ToString(), txtNextPosition.Text, Convert.ToInt32(cboxHoursNextETA.SelectedValue), Convert.ToInt32(cboxMinutesNextETA.SelectedValue), txtThen.Text, Convert.ToInt32(cboxMach.SelectedValue));

            txtReport.Text = OceanicReport.GeneratedReport;
        }

    }
}
