using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamCenterTSZ.UI.ExamCenterComponents;

namespace ExamCenterTSZ.UI.DashboardComponents
{
    public partial class ButtonTyperating : UserControl
    {


        bool panel = false;

        int eps = 0;
        int assignID = 0;
        int assignFor = 0;

        public ButtonTyperating(string typerating, int examid, int eps, int assignID, int assignFor)
        {
            InitializeComponent();

            Update(typerating, examid, eps, assignID, assignFor);

        }

        public void Update(string typerating, int examid, int eps, int assignID, int assignFor)
        {
            btnTyperating.Text = typerating.ToString();
            btnTyperating.Tag = examid;

            this.eps = eps;
            this.assignID = assignID;
            this.assignFor = assignFor;
        }

        public delegate void ClickButtonExam(int buttonValue, int eps, int assignID, int assignFor);
        public event ClickButtonExam OnClickButtonExam;

        private void btnTyperating_Click(object sender, EventArgs e)
        {
            if (OnClickButtonExam != null)
                OnClickButtonExam(Convert.ToInt32(btnTyperating.Tag), eps, assignID, assignFor);

            Hide();

        }
    }
}
