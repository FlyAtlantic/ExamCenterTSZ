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
            OceanicReport.OceanicReports(txtCallsign.Text, txtPosition.Text, cboxHourPosition.SelectedIndex, cboxMinutesPosition.SelectedIndex, cboxFlightLevel.SelectedIndex, txtNextPosition.Text, cboxHoursNextETA.SelectedIndex, cboxMinutesNextETA.SelectedIndex, txtThen.Text, cboxMach.SelectedIndex);

            txtReport.Text = OceanicReport.GeneratedReport;
        }

    }
}
