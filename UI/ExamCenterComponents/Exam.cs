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

        /// <summary>
        /// colocas aqui código para ir buscar os dados ao mysql
        /// e devolver um new Answer(...)
        /// </summary>
        /// <param name=""></param>
        public static Answer FromSQL(int ID)
        {
            return new Answer("Answer 1", false);
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
            SelectedAnswer = -1;
            this.Text = Text;
            this.Answers = Answers;
        }

        /// <summary>
        /// colocas aqui código para ir buscar os dados ao mysql
        /// e devolver um new Answer(...)
        /// </summary>
        /// <param name=""></param>
        public static Question FromSQL(int ID)
        {
            return new Question("Question 1", new List<Answer>());
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
    }
    
}
