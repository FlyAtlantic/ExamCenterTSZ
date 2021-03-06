﻿using System;
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
using ExamCenterTSZ.UI.ExamCenterComponents.ViewMyExams;
using TSZTools;

namespace ExamCenterTSZ.UI
{
    public partial class Dashboard : Form
    {
        private ToolControlFrm toolFrm;
        public Dashboard()
        {

            InitializeComponent();
            Clock.Start();
            UpdatePilotOnline.Start();
            PilotInformations();

            if (result.AdminLevel <= 2)
            {
                btnAdminPanel.Visible = true;
                btnInstructor.Visible = true;
            }

            ShowInTaskbar = false;

            lblClock.Text = DateTime.UtcNow.ToString();

            lblWelcome.Text = String.Format("Have a nice {0},{1} {2} {3}", DateTime.UtcNow.DayOfWeek.ToString(), result.Rank, result.UserName, result.UserSurname);

            OnlinePilots();
            UpdateLastLoginPilots();
        }

        UserInformations result = new UserInformations();

        public class UserInformations
        {
          
            public int UserID
            { get; set; }
            public int Callsign
            { get; set; }
            public string UserName
            { get; set; }
            public string UserSurname
            { get; set; }
            public string Rank
            { get; set; }
            public int AdminLevel
            { get; set; }
            public int UserEps
            { get; set; }

        }

        public void PilotInformations()
        {

            string sqlPilotInformations = "SELECT user_nome, user_apelido, utilizadores.rank, ranks.rank, utilizadores.user_id, utilizadores.levelid, utilizadores.eps from utilizadores left join ranks on utilizadores.rank = ranks.rankid where user_email=@PilotId";
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
                        result.UserEps = (int)sqlCmdRes[6];
                    }
                

                PilotInfo.PilotInfos(result.UserID);
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
            lblWelcome.Text = String.Format("Have a nice {0},{1} {2} {3}", DateTime.UtcNow.DayOfWeek.ToString(), result.Rank, result.UserName, result.UserSurname);

            OnlinePilots();
            
        }

        public void OnlinePilots()
        {
            string sqlOnlinePIlots = "SELECT * FROM `utilizadores` WHERE ((NOW() - lastlogin)<70)";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlOnlinePIlots, conn);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        result.Callsign = (int)sqlCmdRes[1];
                        result.UserName = (string)sqlCmdRes[2];
                        result.UserSurname = (string)sqlCmdRes[3];


                        lblPilotsOnlineNow.Text = String.Format("TSZ{0} - {1} {2} \r\n", result.Callsign, result.UserName, result.UserSurname);
                    }

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

        public void UpdateLastLoginPilots()
        {
            string sqlUpdateLastLoginPilots = "UPDATE utilizadores SET lastlogin=NOW() where user_email=@Email";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlUpdateLastLoginPilots, conn);
                sqlCmd.Parameters.AddWithValue("@Email", Properties.Settings.Default.Email);

                sqlCmd.ExecuteNonQuery();
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
        ///
        ///Special Buttons
        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            CtrlsHides();

            adminExamCenterCtrl.Show();
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
            myExamsCtrl.Hide();
            adminExamCenterCtrl.Hide();


        }
        //All buttons Enabled/Disabled
        public void EnableButtons()
        {
            btnExitApp.Enabled = true;
            btnAdminPanel.Enabled = true;
            btnInstructor.Enabled = true;
            btnMenuExam.Enabled = true;
            btnMenuReviewExams.Enabled = true;
            btnRefresh.Enabled = true;

        }

        public void DisableButtons()
        {
            btnExitApp.Enabled = false;
            btnAdminPanel.Enabled = false;
            btnInstructor.Enabled = false;
            btnMenuExam.Enabled = false;
            btnMenuReviewExams.Enabled = false;
            btnRefresh.Enabled = false;
        }

        /// Menu Bar
        private void btnMenuExam_Click(object sender, EventArgs e)
        {
            CtrlsHides();

            examCenterCtrl.Actions();
            examCenterCtrl.Show();
        }

        private void btnMenuReviewExams_Click(object sender, EventArgs e)
        {

            CtrlsHides();

            myExamsCtrl.Show();

        }

        //Other Buttons
        private void btnRefresh_Click(object sender, EventArgs e)
        {
           PilotInformations();

           examCenterCtrl.Actions();
           myExamsCtrl.viewMyExamsGridCtrl.FillMyExams();

            lblWelcome.Text = String.Format("Have a nice {0},{1} {2} {3}", DateTime.UtcNow.DayOfWeek.ToString(), result.Rank, result.UserName, result.UserSurname);
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

        private void myExamsCtrl_VisibleChanged(object sender, EventArgs e)
        {
            myExamsCtrl.viewMyExamsGridCtrl.FillMyExams();
            myExamsCtrl.viewMyExamsGridCtrl.Show();
            myExamsCtrl.viewMyExamPageCtrl.Hide();
        }

        private void examInstructorCtrl_VisibleChanged(object sender, EventArgs e)
        {
            examInstructorCtrl.re_ViewExamCtrl.Hide();
        }


        private void btnTSZTools_Click(object sender, EventArgs e)
        {
            toolFrm = new ToolControlFrm();

            toolFrm.Show();
        }

        private void UpdatePilotOnline_Tick(object sender, EventArgs e)
        {
            UpdateLastLoginPilots();
        }
    }
}
