using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamCenterTSZ.Functions;
using MySql.Data.MySqlClient;

namespace ExamCenterTSZ.UI.ExamCenterComponents
{
    public static class PilotInfo
    {
        public static int ID
        { get; set; }

        public static void PilotInfos(int UserID)
        {
            ID = UserID;
        }

    }

    public class Answer
    {
        public string Text
        { get; set; }

        public bool Correct
        { get; set; }


        public Answer(string Text, bool Correct)
        {
            this.Text = Text;
            this.Correct = Correct;
        }

        public bool Selected
        { get; set; }

    }

    public class LastAnswer
    {
        public string Text
        { get; set; }

        public bool Correct
        { get; set; }

        public int Selected
        { get; set; }

        public LastAnswer(string Text)
        {
            this.Text = Text;
        }

    }

    public class Question
    {
        public int QuestionID
        { get; set; }

        public string Text
        { get; set; }

        public List<Answer> Answers
        { get; set; }

        public int SelectedAnswer
        { get; set; }

        public bool IsSelectedAnswerCorrect
        { get; set; }

        public Question(string Text, int QuestionID, List<Answer> Answers)
        {
            IsSelectedAnswerCorrect = false;
            SelectedAnswer = 0;
            this.Text = Text;
            this.Answers = Answers;
            this.QuestionID = QuestionID;
        }

    }

    public class LastQuestion
    {
        public string Name
        { get; set; }

        public string Surname
        { get; set; }

        public string Text
        { get; set; }

        public List<LastAnswer> LastAnswers
        { get; set; }

        public int SelectedAnswer
        { get; set; }

        public int IsSelectedAnswerCorrect
        { get; set; }

        public string Result
        { get; set; }

        public LastQuestion(string Text, int Selected, int CorrectAnswer, string Name, string Surname, string Result, List<LastAnswer> LastAnswers)
        {
            IsSelectedAnswerCorrect = CorrectAnswer;
            SelectedAnswer = Selected;
            this.Text = Text;
            this.LastAnswers = LastAnswers;
            this.Name = Name;
            this.Surname = Surname;
            this.Result = Result;
        }

    }

    public static class Exam
    {
        public static int ExamID
        { get; set; }

        public static string Text
        { get; set; }

        public static int AssignID
        { get; set; }

        public static int AssignFor
        { get; set; }

        public static List<Question> Questions
        { get; set; }
 
        public static void FromSQL(int ID, int assignID, int assignFor)
        {
            ExamID = ID;

            AssignID = assignID;

            AssignFor = assignFor;

            string sqlPilotInformations = "SELECT * from exam_questions where examby=@ExamID ORDER BY rand() LIMIT 20";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPilotInformations, conn);
                sqlCmd.Parameters.AddWithValue("@ExamID", ID);

                string Text = "";
                List<Question> Questions = new List<Question>();

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        int correctAnswer = Convert.ToInt32(sqlCmdRes[9]);
                        Questions.Add(new Question(
                            (string)sqlCmdRes[3],
                            (int)sqlCmdRes[0],
                            new List<Answer>()
                            {
                                new Answer((string)sqlCmdRes[5], (correctAnswer == 1)),
                                new Answer((string)sqlCmdRes[6], (correctAnswer == 2)),
                                new Answer((string)sqlCmdRes[7], (correctAnswer == 3)),
                                new Answer((string)sqlCmdRes[8], (correctAnswer == 4))
                            }));
                    }
                Exam.Text = Text;
                Exam.Questions = Questions;
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

        public static double CalculateScore()
        {
            int score = 0;

            foreach(Question q in Exam.Questions)
            {
                if (q.IsSelectedAnswerCorrect)
                    score += 1;
            }

            return (100 * score) / Questions.Count;
        }
    }

    public static class LastExam
    {
        public static string Text
        { get; set; }

        public static List<LastQuestion> LastQuestions
        { get; set; }

        
        public static void LastExamFromSQL(int ID)
        {
            string sqlPilotInformations = "SELECT question, answer1, answer2, answer3, answer4, answer_correct, user_nome, user_apelido, result, pilotanswer from exam_answers left join exam_questions on exam_answers.question1 = exam_questions.question_id left join exam_assigns on exam_answers.assignid = exam_assigns.assign_id left join utilizadores on exam_assigns.idpilot = utilizadores.user_id left join exam_results on exam_answers.assignid = exam_results.examassigned where assignid=@AssignID";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPilotInformations, conn);
                sqlCmd.Parameters.AddWithValue("@AssignID", ID);

                string Text = "";
                List<LastQuestion> LastQuestions = new List<LastQuestion>();

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        int correctAnswer = Convert.ToInt32(sqlCmdRes[5]);
                        LastQuestions.Add(new LastQuestion(
                            (string)sqlCmdRes[0],
                            (int)sqlCmdRes[9],
                            (int)sqlCmdRes[5],
                            (string)sqlCmdRes[6],
                            (string)sqlCmdRes[7],
                            (string)sqlCmdRes[8],
                            new List<LastAnswer>()
                            {
                                new LastAnswer((string)sqlCmdRes[1]),
                                new LastAnswer((string)sqlCmdRes[2]),
                                new LastAnswer((string)sqlCmdRes[3]),
                                new LastAnswer((string)sqlCmdRes[4])
                            }));
                    }
                LastExam.Text = Text;
                LastExam.LastQuestions = LastQuestions;
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

    public static class SendExam
    {
        public static void LastExamFromSQL()
        {
            string sqlResultExamtoDatabase = "INSERT INTO `exam_results` (`examassigned` , `pilotid`, `date`, `result`, `state`) VALUES(@ExamID, @PilotID, NOW(), @Result , @State)";
            string sqlSendAnswerstoDatabase = "INSERT INTO `exam_answers` (`assignid` , `question1` , `pilotanswer`) VALUES(@AssignID, @Question, @Answer)";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);
            
            try
            {
                conn.Open();

                foreach (Question a in Exam.Questions)
                {

                    MySqlCommand sqlCmd = new MySqlCommand(sqlSendAnswerstoDatabase, conn);
                    sqlCmd.Parameters.AddWithValue("@AssignID", Exam.AssignID);
                    sqlCmd.Parameters.AddWithValue("@Question", a.QuestionID);
                    sqlCmd.Parameters.AddWithValue("@Answer", a.SelectedAnswer);

                    sqlCmd.ExecuteNonQuery();
                }

                int FinalResult = Convert.ToInt32(Exam.CalculateScore());

                MySqlCommand sqlCmd1 = new MySqlCommand(sqlResultExamtoDatabase, conn);                
                sqlCmd1.Parameters.AddWithValue("@ExamID", Exam.AssignID);
                sqlCmd1.Parameters.AddWithValue("@PilotID", PilotInfo.ID);
                sqlCmd1.Parameters.AddWithValue("@Result", FinalResult.ToString());

                if (FinalResult >= 75)
                {
                    sqlCmd1.Parameters.AddWithValue("@State", "Approved");
                }
                else
                {
                    sqlCmd1.Parameters.AddWithValue("@State", "Rejected");
                }

                sqlCmd1.ExecuteNonQuery();

                //Admission Exam
                if (FinalResult >= 75 && Exam.ExamID == 1)
                {
                    string sqlInsertFirstQualification = "INSERT INTO `qualifications` ( `qualification` , `pilot` , `validity` , `expire` ) VALUES(0, @UserID, NOW() , NOW()+INTERVAL 100 YEAR)";

                    MySqlCommand sqlCmd2 = new MySqlCommand(sqlInsertFirstQualification, conn);
                    sqlCmd2.Parameters.AddWithValue("@UserID", PilotInfo.ID);

                    sqlCmd2.ExecuteNonQuery();
                }

                //ranks
                if (FinalResult >= 75 && Exam.ExamID <=7)
                {
                    string sqlUpdateRank = "UPDATE utilizadores SET rank=@Rank WHERE user_id=@UserID";

                    MySqlCommand sqlCmd2 = new MySqlCommand(sqlUpdateRank, conn);
                    sqlCmd2.Parameters.AddWithValue("@Rank", Exam.AssignFor);
                    sqlCmd2.Parameters.AddWithValue("@UserID", PilotInfo.ID);

                    sqlCmd2.ExecuteNonQuery();
                }

                //Typeratings
                if (FinalResult >= 75 && Exam.ExamID >= 8 && Exam.ExamID <= 22)
                {
                    string sqlInsertTyperating = "INSERT INTO `typeratings` ( `typerating` , `pilot` , `validity` , `expire` ) VALUES(@Typerating, @UserID, NOW() , NOW()+INTERVAL 3 MONTH)";

                    MySqlCommand sqlCmd2 = new MySqlCommand(sqlInsertTyperating, conn);
                    sqlCmd2.Parameters.AddWithValue("@Typerating", Exam.AssignFor);
                    sqlCmd2.Parameters.AddWithValue("@UserID", PilotInfo.ID);

                    sqlCmd2.ExecuteNonQuery();
                }

                //Qualifications
                if (FinalResult >= 75 && Exam.ExamID >= 8 && Exam.ExamID <= 22)
                {
                    string sqlInsertQualification = "INSERT INTO `qualifications` ( `qualification` , `pilot` , `validity` , `expire` ) VALUES(@Qualification, @UserID, NOW() , NOW()+INTERVAL 3 MONTH)";

                    MySqlCommand sqlCmd2 = new MySqlCommand(sqlInsertQualification, conn);
                    sqlCmd2.Parameters.AddWithValue("@Qualification", Exam.AssignFor);
                    sqlCmd2.Parameters.AddWithValue("@UserID", PilotInfo.ID);

                    sqlCmd2.ExecuteNonQuery();
                }

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

