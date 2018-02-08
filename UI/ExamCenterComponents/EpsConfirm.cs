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
            textBox1.Text = eps.ToString();
        }
    }
}
