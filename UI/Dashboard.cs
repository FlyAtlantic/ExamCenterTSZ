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
        public Exam CurrentExam
        { get; set; }

        public int CurrentQuestion
        { get; set; }

        int CountQuestions;

        public Dashboard()
        {

            InitializeComponent();
            Clock.Start();
            Actions();
        }

        ExamsByPilot result = new ExamsByPilot();

        public class ExamsByPilot
        {
            public bool RedSignal
            { get; set; }
            public bool BlueSignal
            { get; set; }
            public bool GreenSignal
            { get; set; }
            public bool TakeExamButton
            { get; set; }
            public int ExamID
            { get; set; }
            public int UserID
            { get; set; }
            public string UserName
            { get; set; }
            public string UserSurname
            { get; set; }
            public string Rank
            { get; set; }
            public int RankID
            { get; set; }
            public string NextRank
            { get; set; }
            public int Eps
            { get; set; }
            public string Name
            { get; set; }

        }

        public void Actions()
        {
            fpTyperatings.Controls.Clear();
            PilotInformations();
            VerifyExamsForPilotTyperatings();
            VerifyExamsForPilotQualifications();
            VerifyExamsForPilotRanks();
            NextRank();
        }

        public void PilotInformations()
        {

            string sqlPilotInformations = "SELECT user_nome, user_apelido, utilizadores.rank, ranks.rank, utilizadores.user_id from utilizadores left join ranks on utilizadores.rank = ranks.rankid where user_email=@PilotId";
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
                        result.RankID = (int)sqlCmdRes[2];
                        result.UserID = (int)sqlCmdRes[4];
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

        public void NextRank()
        {
            string sqlPilotInformations1 = "SELECT rank from ranks where rankid=@Rank";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPilotInformations1, conn);
                sqlCmd.Parameters.AddWithValue("@Rank", result.RankID + 1);
                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();

                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {

                        result.NextRank = (string)sqlCmdRes[0];

                        lblRank.Text = result.NextRank;
                    }
                else
                    result.NextRank = "0";
               
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

        public void VerifyPilotTypeRatings()
        {
            string sqlVerifyExamsForPilotTyperatings = "select typerating from typeratings LEFT JOIN typeratingsname ON typeratings.typerating = typeratingsname.id where pilot = @PilotID";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlVerifyExamsForPilotTyperatings, conn);
                sqlCmd.Parameters.AddWithValue("@PilotID", result.UserID);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {

                        switch ((int)sqlCmdRes[0])
                        {
                            case 1:
                                
                                break;
                            case 5:
                                
                                break;
                            case 6:
                                
                                break;
                            case 7:
                                
                                break;
                            case 8:
                                
                                break;
                            case 9:
                                
                                break;
                            case 11:
                                
                                break;
                            case 12:
                                
                                break;
                            case 13:
                                
                                break;
                            case 14:
                                
                                break;
                            case 15:
                                
                                break;
                            case 16:
                                
                                break;
                            case 17:

                                break;
                            case 18:

                                break;
                            case 19:

                                break;


                            default:

                                break;
                        }
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

        public void VerifyExamsForPilotTyperatings()
        {
            VerifyPilotTypeRatings();

            string sqlVerifyExamsForPilotTyperatings = "SELECT exam_assigns.exam_id, exams.type, name FROM exam_assigns left join utilizadores on exam_assigns.idpilot = utilizadores.user_id left join exams on exam_assigns.exam_id = exams.exam_id left join typeratingsname on exams.type = typeratingsname.id where user_email=@PilotId and type is not null";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlVerifyExamsForPilotTyperatings, conn);
                sqlCmd.Parameters.AddWithValue("@PilotId", Properties.Settings.Default.Email);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        result.ExamID = (int)sqlCmdRes[0];
                        result.Name = (string)sqlCmdRes[2];
                        switch ((int)sqlCmdRes[1])
                        {
                            case 1:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 5:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 6:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 7:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 8:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 9:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 11:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 12:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 13:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 14:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 15:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 16:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 17:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 18:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 19:
                                fpTyperatings.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;


                            default:
                                result.TakeExamButton = false;
                                break;
                        }
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
    
        public void VerifyExamsForPilotQualifications()
        {

            string VerifyExamsForPilotQualifications = "SELECT exam_assigns.exam_id, exams.qual, name FROM exam_assigns left join utilizadores on exam_assigns.idpilot = utilizadores.user_id left join exams on exam_assigns.exam_id = exams.exam_id left join qualificationsname on exams.qual = qualificationsname.id where user_email=@PilotId and qual is not null";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {

                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(VerifyExamsForPilotQualifications, conn);
                sqlCmd.Parameters.AddWithValue("@PilotId", Properties.Settings.Default.Email);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        result.ExamID = (int)sqlCmdRes[0];
                        result.Name = (string)sqlCmdRes[2];

                        switch ((int)sqlCmdRes[1])
                        {
                            case 1:
                                fpQualifications.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 4:
                                fpQualifications.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 6:
                                fpQualifications.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;

                            default:                               

                                break;

                        }
                    }
                else
                {
                    result.ExamID = 0;
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

        public void VerifyExamsForPilotRanks()
        {

            string sqlVerifyExamsForPilotRanks = "SELECT exam_assigns.exam_id, ranks.rank FROM exam_assigns left join utilizadores on exam_assigns.idpilot = utilizadores.user_id left join exams on exam_assigns.exam_id = exams.exam_id left join ranks on exams.exam_name = ranks.rankid where user_email=@PilotId and exam_name is not null";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlVerifyExamsForPilotRanks, conn);
                sqlCmd.Parameters.AddWithValue("@PilotId", Properties.Settings.Default.Email);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        result.ExamID = (int)sqlCmdRes[0];
                        result.Name = (string)sqlCmdRes[1];

                        switch ((int)sqlCmdRes[0])
                        {
                            case 2:
                                fpRank.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 3:
                                fpRank.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 4:
                                fpRank.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 5:
                                fpRank.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 6:
                                fpRank.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;
                            case 7:
                                fpRank.Controls.Add(new ButtonTyperating(result.Name, result.ExamID, this));
                                break;

                            default:

                                break;
                        }
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

        public void GetExamInfos(int btnValue)
        {

            string sqlGetExamInfos = "SELECT user_nome, user_apelido, COALESCE(typeratingsname.eps, qualificationsname.eps,0), COALESCE(typeratingsname.name, qualificationsname.name, ranks.rank) from exam_assigns left join utilizadores on exam_assigns.idpilot = utilizadores.user_id left join exams on exam_assigns.exam_id = exams.exam_id left join typeratingsname on exams.type = typeratingsname.id left join qualificationsname on exams.qual = qualificationsname.id left join ranks on exams.exam_name = ranks.rankid where user_email=@PilotEmail and exams.exam_id=@ExamID";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {

                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlGetExamInfos, conn);
                sqlCmd.Parameters.AddWithValue("@PilotEmail", Properties.Settings.Default.Email);
                sqlCmd.Parameters.AddWithValue("@ExamID", btnValue);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        result.UserName = (string)sqlCmdRes[0];
                        result.UserSurname = (string)sqlCmdRes[1];
                        result.Eps = Convert.ToInt32(sqlCmdRes[2]);
                        result.Name = (string)sqlCmdRes[3];

                    }

                else
                {

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

        private void ExamCenter_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to close me?",
                    "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.UtcNow.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close me?",
                    "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       
        public void OpenExamPanel(bool panel)
        {
            panelExamPage.Visible = panel;

        }

        public void StartExam(Exam exam)
        {
            CurrentExam = exam;
            CurrentQuestion = 0;          

            qstControl.Update(CurrentExam.Questions[CurrentQuestion]);

            CountQuestions = CurrentQuestion + 1;
            if (CurrentExam.Questions.Count > 1)
                btnNext.Enabled = true;

            lblCountQuestions.Text = String.Format("Question {0} of {1}", CountQuestions.ToString(), CurrentExam.Questions.Count.ToString());
        }

        private void btnPreviousQuestion_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnNext.Visible = true;
            btnFinish.Visible = false;

            CurrentQuestion--;
            qstControl.Update(CurrentExam.Questions[CurrentQuestion]);

            CountQuestions = CurrentQuestion + 1;
            if (CurrentQuestion == 0)
                btnPrevious.Enabled = false;

            lblCountQuestions.Text = String.Format("Question {0} of {1}", CountQuestions.ToString(), CurrentExam.Questions.Count.ToString());

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;

            CurrentQuestion++;
            qstControl.Update(CurrentExam.Questions[CurrentQuestion]);

            CountQuestions = CurrentQuestion + 1;
            if (CurrentQuestion == CurrentExam.Questions.Count - 1)
            {
                btnNext.Visible = false;
                btnFinish.Visible = true;
            }

            lblCountQuestions.Text = String.Format("Question {0} of {1}", CountQuestions.ToString(), CurrentExam.Questions.Count.ToString());
        }

        public void GetQuestions(int examID)
        {
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;

            StartExam(Exam.FromSQL(Convert.ToInt32(examID)));
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close me?",
                    "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                panelFinishExam.Visible = true;
            }          
        }

        private void panelFinishExam_VisibleChanged(object sender, EventArgs e)
        {
                examFinishedCtrl1.Visible = true;

        }
    }
}
