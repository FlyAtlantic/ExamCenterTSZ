﻿using System;
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

        public static List<Question> Questions
        { get; set; }
 
        public static void FromSQL(int ID, int assignID)
        {
            ExamID = ID;

            AssignID = assignID; 

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
            string sqlPilotInformations = "SELECT * from exam_answers left join exam_questions on exam_answers.question1 = exam_questions.question_id left join exam_assigns on exam_answers.assignid = exam_assigns.assign_id left join utilizadores on exam_assigns.idpilot = utilizadores.user_id left join exam_results on exam_answers.assignid = exam_results.examassigned where assignid=@AssignID";
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
                            (string)sqlCmdRes[26],
                            (string)sqlCmdRes[27],
                            (string)sqlCmdRes[48],
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

