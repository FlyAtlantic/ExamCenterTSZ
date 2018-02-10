using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ExamCenterTSZ.Functions;

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
            txtEpsInfo.Text = String.Format("Will be removed {0} ep's from your account to begin the exam!", eps.ToString());
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string sqlUpdatePilotAssign = "UPDATE `exam_assigns` SET `avaiable`=0 where assign_id = @AssignID";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            conn.Open();

            MySqlCommand sqlCmd2 = new MySqlCommand(sqlUpdatePilotAssign, conn);
            sqlCmd2.Parameters.AddWithValue("@AssignID", Exam.AssignID);

            sqlCmd2.ExecuteNonQuery();
            conn.Close();

            var DBoard = this.Parent as Dashboard;

            DBoard.examPage.Show();
            DBoard.examPage.ChronometerStart();
            Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void EpsConfirm_Load(object sender, EventArgs e)
        {
            var DBoard = this.Parent as Dashboard;

            DBoard.examPage.ChronometerStop();
        }
    }
}
