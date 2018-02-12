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

namespace ExamCenterTSZ.UI.AdminPanel.ExamCenter
{
    public partial class AdminQuestionNewEdit : UserControl
    {
        public class ExamQuestionsNewEdit
        {
            public string QuestionText
            { get; set; }

            public string Answer1
            { get; set; }

            public string Answer2
            { get; set; }

            public string Answer3
            { get; set; }

            public string Answer4
            { get; set; }

            public static int AnswerCorrect
            { get; set; }

            public int CorrectedAnswer
            { get; set; }

        }

        public AdminQuestionNewEdit()
        {
            InitializeComponent();
        }

        public void GetExamForView(int QuestionID)
        {
            ExamQuestionsNewEdit result = new ExamQuestionsNewEdit();

            string sqlAdminFromSql = "SELECT question, answer_correct, answer1, answer2, answer3, answer4 from exam_questions where question_id = @QuestionID";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlAdminFromSql, conn);
                sqlCmd.Parameters.AddWithValue("@QuestionID", QuestionID);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        result.QuestionText = (string)sqlCmdRes[0];
                        result.Answer1 = (string)sqlCmdRes[2];
                        result.Answer2 = (string)sqlCmdRes[3];
                        result.Answer3 = (string)sqlCmdRes[4];
                        result.Answer4 = (string)sqlCmdRes[5];
                        result.CorrectedAnswer = (int)sqlCmdRes[1];

                    }

            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @Exam.FromSQL()", crap);
            }
            finally
            {
                txtQuestion.Text = result.QuestionText;
                txtEditAnswer1.Text = result.Answer1;
                txtEditAnswer2.Text = result.Answer2;
                txtEditAnswer3.Text = result.Answer3;
                txtEditAnswer4.Text = result.Answer4;

                if (result.CorrectedAnswer == 1)
                    cboxAnswer1.Checked = true;
                if (result.CorrectedAnswer == 2)
                    cboxAnswer2.Checked = true;
                if (result.CorrectedAnswer == 3)
                    cboxAnswer3.Checked = true;
                if (result.CorrectedAnswer == 4)
                    cboxAnswer4.Checked = true;

                conn.Close();
            }
        }

        public void EditQuestion(int QuestionID, string questionText, string answer1, string answer2, string answer3, string answer4, int correctAnswer)
        {
            ExamQuestionsNewEdit result = new ExamQuestionsNewEdit();

            string sqlAdminFromSql = "UPDATE exam_questions SET question=@QuestionText, answer1=@Answer1, answer2=@Answer2, answer3=@Answer3, answer4=@Answer4, answer_correct=@CorrectAnswer WHERE question_id = @QuestionID LIMIT 1";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlAdminFromSql, conn);

                sqlCmd.Parameters.AddWithValue("@QuestionText", questionText);
                sqlCmd.Parameters.AddWithValue("@Answer1", answer1);
                sqlCmd.Parameters.AddWithValue("@Answer2", answer2);
                sqlCmd.Parameters.AddWithValue("@Answer3", answer3);
                sqlCmd.Parameters.AddWithValue("@Answer4", answer4);
                sqlCmd.Parameters.AddWithValue("@CorrectAnswer", correctAnswer);
                sqlCmd.Parameters.AddWithValue("@QuestionID", QuestionID);

                sqlCmd.ExecuteNonQuery();

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

        public void NewQuestion(string questionText, string answer1, string answer2, string answer3, string answer4, int correctAnswer, int exam)
        {
            ExamQuestionsNewEdit result = new ExamQuestionsNewEdit();

            string sqlAdminFromSql = "INSERT INTO exam_questions(question, answer1, answer2, answer3, answer4, answer_correct, examby) VALUES(@QuestionText, @Answer1, @Answer2, @Answer3, @Answer4, @CorrectAnswer, @ExamID) ";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlAdminFromSql, conn);

                sqlCmd.Parameters.AddWithValue("@QuestionText", questionText);
                sqlCmd.Parameters.AddWithValue("@Answer1", answer1);
                sqlCmd.Parameters.AddWithValue("@Answer2", answer2);
                sqlCmd.Parameters.AddWithValue("@Answer3", answer3);
                sqlCmd.Parameters.AddWithValue("@Answer4", answer4);
                sqlCmd.Parameters.AddWithValue("@CorrectAnswer", correctAnswer);
                sqlCmd.Parameters.AddWithValue("@ExamID", exam);

                sqlCmd.ExecuteNonQuery();

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

        private void cboxAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAnswer1.Checked)
            {
                ExamQuestionsNewEdit.AnswerCorrect = 1;
                cboxAnswer2.Checked = false;
                cboxAnswer3.Checked = false;
                cboxAnswer4.Checked = false;
            }
        }

        private void cboxAnswer2_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAnswer2.Checked)
            {
                ExamQuestionsNewEdit.AnswerCorrect = 2;
                cboxAnswer1.Checked = false;
                cboxAnswer3.Checked = false;
                cboxAnswer4.Checked = false;
            }
        }

        private void cboxAnswer3_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAnswer3.Checked)
            {
                ExamQuestionsNewEdit.AnswerCorrect = 3;
                cboxAnswer1.Checked = false;
                cboxAnswer2.Checked = false;
                cboxAnswer4.Checked = false;
            }
        }

        private void cboxAnswer4_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAnswer4.Checked)
            {
                ExamQuestionsNewEdit.AnswerCorrect = 4;
                cboxAnswer1.Checked = false;
                cboxAnswer2.Checked = false;
                cboxAnswer3.Checked = false;
            }
        }
    }
}
