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

        Dashboard DBoard
        { get; set; }

        bool panel = false;

        public ButtonTyperating(string typerating, int examid, Dashboard d)
        {
            InitializeComponent();

            Update(typerating, examid);

            DBoard = d;
        }

        public void Update(string typerating, int examid)
        {
            btnTyperating.Text = typerating.ToString();
            btnTyperating.Tag = examid;
        }

        private void btnTyperating_Click(object sender, EventArgs e)
        {

            DBoard.panelExamPage.Visible = true;
            DBoard.GetQuestions(Convert.ToInt32(btnTyperating.Tag));

            panel = true;

            DBoard.OpenExamPanel(panel);
            
        }
    }
}
