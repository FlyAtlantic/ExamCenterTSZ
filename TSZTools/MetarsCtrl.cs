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
    public partial class MetarsCtrl : UserControl
    {
        public MetarsCtrl()
        {
            InitializeComponent();
        }

        private void btnViewMetar_Click(object sender, EventArgs e)
        {

            Metars.GetMetars(txtICAO.Text);

            lblViewMetar.Text = Metars.Metar;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
