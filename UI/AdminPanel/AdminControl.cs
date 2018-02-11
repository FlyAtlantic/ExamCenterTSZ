using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

    public class AdminEditAnswer
    {
        public string Text
        { get; set; }


        public AdminEditAnswer(string Text)
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
            string sqlAdminFromSql = "SELECT question, question_id, answer_correct, answer1, answer2, answer3, answer4 from exam_questions";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlAdminFromSql, conn);
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

    public static class AdminViewOnlyOneQuestionToEdit
    {
        public static string Text
        { get; set; }

        public static List<AdminQuestion> AdminQuestion
        { get; set; }

        public static void OnlyOneFromSql(int questionID)
        {

            string sqlOnlyOneQuestionToEdit = "SELECT question, question_id, answer_correct, answer1, answer2, answer3, answer4 from exam_questions where question_id = @QuestionID";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlOnlyOneQuestionToEdit, conn);
                sqlCmd.Parameters.AddWithValue("@QuestionID", questionID);

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

    public static class SaveQuestion
    {
        public static void SaveEditQuestion(int questionID, string questionText, string answer1, string answer2, string answer3, string answer4, int correctAnswer )
        {
            string sqlSaveEditQuestion = "UPDATE exam_questions SET question=@QuestionText, answer1=@Answer1, answer2=@Answer2, answer3=@Answer3, answer4=@Answer4, answer_correct=@AnswerCorrect where question_id=@QuestionID LIMIT 1";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlSaveEditQuestion, conn);
                sqlCmd.Parameters.AddWithValue("@QuestionText", questionText);
                sqlCmd.Parameters.AddWithValue("@Answer1", answer1);
                sqlCmd.Parameters.AddWithValue("@Answer2", answer2);
                sqlCmd.Parameters.AddWithValue("@Answer3", answer3);
                sqlCmd.Parameters.AddWithValue("@Answer4", answer4);
                sqlCmd.Parameters.AddWithValue("@AnswerCorrect", correctAnswer);
                sqlCmd.Parameters.AddWithValue("@QuestionID", questionID);

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
    }
}
