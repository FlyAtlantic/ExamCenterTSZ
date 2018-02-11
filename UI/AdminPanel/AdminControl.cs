using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamCenterTSZ.Functions;
using MySql.Data.MySqlClient;

namespace ExamCenterTSZ.UI.AdminPanel
{
    public class AdminAnswer
    {
        public string Text
        { get; set; }


        public AdminAnswer(string Text)
        {
            this.Text = Text;
        }

    }

    public class AdminQuestion
    {
        public int QuestionID
        { get; set; }

        public string Text
        { get; set; }

        public List<AdminAnswer> AdminAnswers
        { get; set; }

        public int AnswerCorrect
        { get; set; }

        public AdminQuestion(string Text, int QuestionID, int AnswerCorrect, List<AdminAnswer> AdminAnswers)
        {

            this.Text = Text;
            this.AdminAnswers = AdminAnswers;
            this.QuestionID = QuestionID;
            this.AnswerCorrect = AnswerCorrect;

        }

    }

    public static class AdminViewQuestions
    {
        public static string Text
        { get; set; }

        public static List<AdminQuestion> AdminQuestions
        { get; set; }

        public static void AdminFromSql()
        {
            string sqlPilotInformations = "SELECT question, question_id, answer_correct, answer1, answer2, answer3, answer4 from exam_questions";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPilotInformations, conn);
                //sqlCmd.Parameters.AddWithValue("@ExamID", ID);

                string Text = "";
                List<AdminQuestion> AdminQuestions = new List<AdminQuestion>();

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        AdminQuestions.Add(new AdminQuestion(
                            (string)sqlCmdRes[0],
                            (int)sqlCmdRes[1],
                            (int)sqlCmdRes[2],
                            new List<AdminAnswer>()
                            {
                                new AdminAnswer((string)sqlCmdRes[3]),
                                new AdminAnswer((string)sqlCmdRes[4]),
                                new AdminAnswer((string)sqlCmdRes[5]),
                                new AdminAnswer((string)sqlCmdRes[6])
                            }));
                    }
                AdminViewQuestions.Text = Text;
                AdminViewQuestions.AdminQuestions = AdminQuestions;
            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @Exam.FromSQL()", crap);
            }
            finally
            {

                conn.Close();
            }
        }
    }
}
