using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSUIPC;

namespace PayloadManagerTSZ
{
    public partial class PayloadManager : Form
    {
        /// <summary>
        /// GW in pounds
        /// </summary>
        public int GrossWeight;
        /// <summary>
        /// ZFW in pounds
        /// </summary>
        public double ZeroFuelWeight;
        /// <summary>
        /// ZFW in pounds
        /// </summary>
        public int FuelTankCenter;

        public PayloadManager()
        {
            InitializeComponent();
            FSUIPCConnection.Open();
            
            GetValues();

            lblGW.Text = GrossWeight.ToString();
            lblZFW.Text = ZeroFuelWeight.ToString();

            Telemetry.Start();

        }

        public void GetValues()
        {
            FSUIPCConnection.Process();
            GrossWeight = Convert.ToInt32(FSUIPCOffsets.grossWeight.Value * 0.45359237);
            ZeroFuelWeight = Convert.ToInt32((FSUIPCOffsets.zeroFuelWeight.Value / 256) * 0.45359237);
            FuelTankCenter = Convert.ToInt32(FSUIPCOffsets.FuelCenterTankPercentage.Value);


            lblGW.Text = GrossWeight.ToString();
            lblZFW.Text = ZeroFuelWeight.ToString();
            lblFW.Text = FuelTankCenter.ToString();
        }

        private void InsertValues()
        {
            double convertFWdouble = Convert.ToDouble(txtFW.Text);
            int convertFWpounds = Convert.ToInt32((convertFWdouble *256 ) / 0.45359237);

            FSUIPCConnection.Process();
            //FSUIPCOffsets.FuelCenterTankPercentage.Value = convertFWpounds;

        }

        private void Telemetry_Tick(object sender, EventArgs e)
        {
            GetValues();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            InsertValues();
        }
    }
}
