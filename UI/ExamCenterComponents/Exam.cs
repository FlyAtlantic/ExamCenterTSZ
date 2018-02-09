using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamCenterTSZ.Functions;
using MySql.Data.MySqlClient;

namespace ExamCenterTSZ.UI.ExamCenterComponents
{
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
        public string Text
        { get; set; }

        public List<Answer> Answers
        { get; set; }

        public int SelectedAnswer
        { get; set; }

        public bool IsSelectedAnswerCorrect
        { get; set; }

        public Question(string Text, List<Answer> Answers)
        {
            IsSelectedAnswerCorrect = false;
            SelectedAnswer = 0;
            this.Text = Text;
            this.Answers = Answers;
        }

    }

    public class LastQuestion
    {
        public string Text
        { get; set; }

        public List<LastAnswer> LastAnswers
        { get; set; }

        public int SelectedAnswer
        { get; set; }

        public int IsSelectedAnswerCorrect
        { get; set; }

        public LastQuestion(string Text, int Selected, int CorrectAnswer, List<LastAnswer> LastAnswers)
        {
            IsSelectedAnswerCorrect = CorrectAnswer;
            SelectedAnswer = Selected;
            this.Text = Text;
            this.LastAnswers = LastAnswers;
        }

    }

    public static class Exam
    {
        public static string Text
        { get; set; }

        public static List<Question> Questions
        { get; set; }

        /// <summary>
        /// Isto é só porque não quero saber da parte do SQL
        /// </summary>
        /// <returns></returns>
        //public static void GetExample()
        //{
        //    return new Exam("Exame Exemplo", new List<Question>()
        //    {
        //        new Question("Questão 1, a primeira opção é a correcta", new List<Answer>()
        //        {
        //            new Answer("Resposta Certa", true),
        //            new Answer("Resposta Errada", false)
        //        }),
        //        new Question("Questão 2, a segunda opção é a correcta", new List<Answer>()
        //        {
        //            new Answer("Resposta Errada", false),
        //            new Answer("Resposta Certa", true)
        //        })
        //    });
        //}

        /// <summary>
        /// colocas aqui código para ir buscar os dados ao mysql
        /// e devolver um new Answer(...)
        /// </summary>
        /// <param name=""></param>
        /// 
        public static void FromSQL(int ID)
        {
            string sqlPilotInformations = "SELECT * from exam_questions where examby=@ExamID";
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
            string sqlPilotInformations = "SELECT * from exam_answers left join exam_questions on exam_answers.question1 = exam_questions.question_id left join exam_assigns on exam_questions.examby = exam_assigns.exam_id where assignid=@AssignID";
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
                        int correctAnswer = Convert.ToInt32(sqlCmdRes[14]);
                        LastQuestions.Add(new LastQuestion(
                            (string)sqlCmdRes[8],
                            (int)sqlCmdRes[3],
                            (int)sqlCmdRes[14],
                            new List<LastAnswer>()
                            {
                                new LastAnswer((string)sqlCmdRes[10]),
                                new LastAnswer((string)sqlCmdRes[11]),
                                new LastAnswer((string)sqlCmdRes[12]),
                                new LastAnswer((string)sqlCmdRes[13])
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
}

