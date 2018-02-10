using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ExamCenterTSZ.Functions;
using ExamCenterTSZ.UI.DashboardComponents;
using ExamCenterTSZ.UI.ExamCenterComponents;

namespace ExamCenterTSZ.UI
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {

            InitializeComponent();
            Clock.Start();
            PilotInformations();

            if (result.AdminLevel <= 2)
            {
                btnAdminPanel.Visible = true;
                btnInstructor.Visible = true;
            }

            ShowInTaskbar = false;

            lblClock.Text = DateTime.UtcNow.ToString();
        }

        UserInformations result = new UserInformations();

        public class UserInformations
        {
          
            public int UserID
            { get; set; }
            public string UserName
            { get; set; }
            public string UserSurname
            { get; set; }
            public string Rank
            { get; set; }
            public int AdminLevel
            { get; set; }

        }

        public void PilotInformations()
        {

            string sqlPilotInformations = "SELECT user_nome, user_apelido, utilizadores.rank, ranks.rank, utilizadores.user_id, utilizadores.levelid from utilizadores left join ranks on utilizadores.rank = ranks.rankid where user_email=@PilotId";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPilotInformations, conn);
                sqlCmd.Parameters.AddWithValue("@PilotId", Properties.Settings.Default.Email);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        result.UserName = (string)sqlCmdRes[0];
                        result.UserSurname = (string)sqlCmdRes[1];
                        result.Rank = (string)sqlCmdRes[3];
                        result.UserID = (int)sqlCmdRes[4];
                        result.AdminLevel = (int)sqlCmdRes[5];
                    }

                lblWelcome.Text = String.Format("Have a nice {0},{1} {2} {3}", DateTime.UtcNow.DayOfWeek.ToString(), result.Rank, result.UserName, result.UserSurname);
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }       

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.UtcNow.ToString();
        }                                         

        ///
        ///Special Buttons
        private void btnAdminPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            CtrlsHides();

            examInstructorCtrl.Show();
        }

        private void CtrlsHides()
        {
            examInstructorCtrl.Hide();
            examCenterCtrl.Hide();

        }

        /// Menu Bar
        private void btnMenuExam_Click(object sender, EventArgs e)
        {
            CtrlsHides();

            examCenterCtrl.Actions();
            examCenterCtrl.Show();
        }


        //Other Buttons
        private void btnRefresh_Click(object sender, EventArgs e)
        {
           examCenterCtrl.Actions();
        }  

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close me?",
                     "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                     MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
