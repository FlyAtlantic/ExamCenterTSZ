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
using ExamCenterTSZ.UI.DashboardComponents;

namespace ExamCenterTSZ.UI.ExamCenterComponents
{
    public partial class ExamCenterCtrl : UserControl
    {
        public ExamCenterCtrl()
        {
            InitializeComponent();
            Actions();
        }

        ExamsByPilot result = new ExamsByPilot();

        public class ExamsByPilot
        {
            public bool TakeExamButton
            { get; set; }
            public int ExamID
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
            public int AssignID
            { get; set; }
            public int AssignFor
            { get; set; }

        }

        public void Actions()
        {
            //PilotInformations();
            fpTyperatings.Controls.Clear();
            fpQualifications.Controls.Clear();
            fpRank.Controls.Clear();

            VerifyExamsForPilotTyperatings();
            VerifyExamsForPilotQualifications();
            VerifyExamsForPilotRanks();

        }           

        public void VerifyExamsForPilotTyperatings()
        {

            string sqlVerifyExamsForPilotTyperatings = "SELECT exam_assigns.exam_id, exams.type, name, typeratingsname.eps, exam_assigns.assign_id FROM exam_assigns left join utilizadores on exam_assigns.idpilot = utilizadores.user_id left join exams on exam_assigns.exam_id = exams.exam_id left join typeratingsname on exams.type = typeratingsname.id where user_email=@PilotId and avaiable=1 and type is not null";
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
                        result.Eps = (int)sqlCmdRes[3];
                        result.AssignID = (int)sqlCmdRes[4];
                        result.AssignFor = (int)sqlCmdRes[1];

                        switch ((int)sqlCmdRes[1])
                        {
                            case 1:
                                var Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 5:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 6:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 7:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 8:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 9:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 11:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 12:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 13:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 14:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 15:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 16:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 17:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 18:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
                                break;
                            case 19:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpTyperatings.Controls.Add(Button);
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

            string VerifyExamsForPilotQualifications = "SELECT exam_assigns.exam_id, exams.qual, name, qualificationsname.eps, exam_assigns.assign_id FROM exam_assigns left join utilizadores on exam_assigns.idpilot = utilizadores.user_id left join exams on exam_assigns.exam_id = exams.exam_id left join qualificationsname on exams.qual = qualificationsname.id where user_email=@PilotId and avaiable=1 and qual is not null";
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
                        result.Eps = (int)sqlCmdRes[3];
                        result.AssignID = (int)sqlCmdRes[4];
                        result.AssignFor = (int)sqlCmdRes[1];

                        switch ((int)sqlCmdRes[1])
                        {
                            case 1:
                                var Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpQualifications.Controls.Add(Button);
                                break;
                            case 4:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpQualifications.Controls.Add(Button);
                                break;
                            case 6:
                                Button = new ButtonTyperating(result.Name, result.ExamID, result.Eps, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpQualifications.Controls.Add(Button);
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

            string sqlVerifyExamsForPilotRanks = "SELECT exam_assigns.exam_id, ranks.rank, exam_assigns.assign_id FROM exam_assigns left join utilizadores on exam_assigns.idpilot = utilizadores.user_id left join exams on exam_assigns.exam_id = exams.exam_id left join ranks on exams.exam_name = ranks.rankid where user_email=@PilotId and avaiable=1 and exam_name is not null";
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
                        result.AssignID = (int)sqlCmdRes[2];
                        result.AssignFor = (int)sqlCmdRes[0];

                        switch ((int)sqlCmdRes[0])
                        {
                            case 1:
                                var Button = new ButtonTyperating("Admission Exam", result.ExamID, 0, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpRank.Controls.Add(Button);
                                break;
                            case 2:
                                Button = new ButtonTyperating(result.Name, result.ExamID, 0, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpRank.Controls.Add(Button);
                                break;
                            case 3:
                                Button = new ButtonTyperating(result.Name, result.ExamID, 0, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpRank.Controls.Add(Button);
                                break;
                            case 4:
                                Button = new ButtonTyperating(result.Name, result.ExamID, 0, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpRank.Controls.Add(Button);
                                break;
                            case 5:
                                Button = new ButtonTyperating(result.Name, result.ExamID, 0, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpRank.Controls.Add(Button);
                                break;
                            case 6:
                                Button = new ButtonTyperating(result.Name, result.ExamID, 0, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpRank.Controls.Add(Button);
                                break;
                            case 7:
                                Button = new ButtonTyperating(result.Name, result.ExamID, 0, result.AssignID, result.AssignFor);
                                Button.OnClickButtonExam += E_OnButtonClickExam;
                                fpRank.Controls.Add(Button);
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

        public void E_OnButtonClickExam(int buttonValue, int eps, int assignID, int assignFor)
        {
            var DBoard = this.Parent as Dashboard;

            DBoard.examPage.GetQuestions(buttonValue, eps, assignID, assignFor);

            DBoard.epsConfirm.Show();

        }
    }
}
