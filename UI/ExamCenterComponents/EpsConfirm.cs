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
        int UserEps = 0;

        int ExamEps = 0;

        public EpsConfirm()
        {

            InitializeComponent();

        }

        public void GetUserEps()
        {
            string sqlPilotEps = "SELECT eps from utilizadores where user_email=@PilotEmail";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            conn.Open();
            MySqlCommand sqlCmd = new MySqlCommand(sqlPilotEps, conn);
            sqlCmd.Parameters.AddWithValue("@PilotEmail", Properties.Settings.Default.Email);

            MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
            if (sqlCmdRes.HasRows)
                while (sqlCmdRes.Read())
                {
                    UserEps = (int)sqlCmdRes[0];
                }
            conn.Close();
        }

        public void GetEps(int eps)
        {
            GetUserEps();

            txtEpsInfo.Text = String.Format("Will be removed {0} ep's from your account to begin the exam!", eps.ToString());

            ExamEps = eps;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            var DBoard = this.Parent as Dashboard;

            if (UserEps >= ExamEps) {
                string sqlUpdatePilotAssign = "UPDATE `exam_assigns` SET `avaiable`=0 where assign_id = @AssignID";
                MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

                conn.Open();

                MySqlCommand sqlCmd2 = new MySqlCommand(sqlUpdatePilotAssign, conn);
                sqlCmd2.Parameters.AddWithValue("@AssignID", Exam.AssignID);

                sqlCmd2.ExecuteNonQuery();
                conn.Close();



                DBoard.examPage.Show();
                DBoard.examPage.ChronometerStart();
                Hide();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            var DBoard = this.Parent as Dashboard;

            DBoard.examCenterCtrl.Actions();

            Hide();
        }

        private void EpsConfirm_Load(object sender, EventArgs e)
        {
            var DBoard = this.Parent as Dashboard;

            DBoard.examPage.ChronometerStop();
        }
    }
}
