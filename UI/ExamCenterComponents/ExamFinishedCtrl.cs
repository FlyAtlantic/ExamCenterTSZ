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
    public partial class ExamFinishedCtrl : UserControl
    {
        public ExamFinishedCtrl()
        {
            InitializeComponent();
            ProgressBar();           
        }

        public void ProgressBar()
        {
            progressBar1.Value = 50;
        }
    }
}
