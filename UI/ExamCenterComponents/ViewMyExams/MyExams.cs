using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamCenterTSZ.Functions;
using MySql.Data.MySqlClient;

namespace ExamCenterTSZ.UI.ExamCenterComponents.ViewMyExams
{
    public class MyLastAnswer
    {
        public string Text
        { get; set; }

        public bool Correct
        { get; set; }

        public int Selected
        { get; set; }

        public MyLastAnswer(string Text)
        {
            this.Text = Text;
        }

    }

    public class MyLastQuestion
    {     

        public string Text
        { get; set; }

        public List<MyLastAnswer> LastAnswers
        { get; set; }

        public int SelectedAnswer
        { get; set; }

        public int IsSelectedAnswerCorrect
        { get; set; }

        public string Result
        { get; set; }

        public MyLastQuestion(string Text, int Selected, int CorrectAnswer, string Result, List<MyLastAnswer> LastAnswers)
        {
            IsSelectedAnswerCorrect = CorrectAnswer;
            SelectedAnswer = Selected;
            this.Text = Text;
            this.LastAnswers = LastAnswers;
            this.Result = Result;
        }

    }

    public static class MyExams
    {
        public static string Text
        { get; set; }

        public static List<MyLastQuestion> LastQuestions
        { get; set; }


        public static void LastExamFromSQL(int ID)
        {
            string sqlPilotInformations = "SELECT * from exam_answers left join exam_questions on exam_answers.question1 = exam_questions.question_id left join exam_assigns on exam_answers.assignid = exam_assigns.assign_id left join utilizadores on exam_assigns.idpilot = utilizadores.user_id left join exam_results on exam_answers.assignid = exam_results.examassigned where assignid=@AssignID";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPilotInformations, conn);
                sqlCmd.Parameters.AddWithValue("@AssignID", ID);

                string Text = "";
                List<MyLastQuestion> LastQuestions = new List<MyLastQuestion>();

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        int correctAnswer = Convert.ToInt32(sqlCmdRes[14]);
                        LastQuestions.Add(new MyLastQuestion(
                            (string)sqlCmdRes[7],
                            (int)sqlCmdRes[3],
                            (int)sqlCmdRes[13],
                            (string)sqlCmdRes[47],
                            new List<MyLastAnswer>()
                            {
                                new MyLastAnswer((string)sqlCmdRes[9]),
                                new MyLastAnswer((string)sqlCmdRes[10]),
                                new MyLastAnswer((string)sqlCmdRes[11]),
                                new MyLastAnswer((string)sqlCmdRes[12])
                            }));
                    }
                MyExams.Text = Text;
                MyExams.LastQuestions = LastQuestions;
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
