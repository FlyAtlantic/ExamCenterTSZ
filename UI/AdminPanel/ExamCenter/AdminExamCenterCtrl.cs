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
using static ExamCenterTSZ.UI.AdminPanel.ExamCenter.AdminQuestionNewEdit;

namespace ExamCenterTSZ.UI.AdminPanel
{
    public partial class AdminExamCenterCtrl : UserControl
    {
        public static int ExamValueCbox
        { get; set; }

        public AdminExamCenterCtrl()
        {

            InitializeComponent();
            comboExams();
            AdminViewQuestions.AdminFromSql();
        }

        private void comboExams()
        {
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                string sqlAllExams = "select exam_id, COALESCE(ranks.rank, typeratingsname.name, qualificationsname.name) as Name from exams left join ranks on exams.exam_name = ranks.rankid left join typeratingsname on exams.type = typeratingsname.id left join qualificationsname on exams.qual = qualificationsname.id";

                MySqlCommand sqlCmd = new MySqlCommand(sqlAllExams, conn);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxExams.DataSource = ds.Tables[0];
                cboxExams.ValueMember = "exam_id";
                cboxExams.DisplayMember = "Name";
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

        private void cboxExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxExams.ValueMember == "")
            {
                adminQuestionsGridCtrl.FillAdminQuestions(1);
                ExamValueCbox = 1;
            }
            else
            {
                adminQuestionsGridCtrl.FillAdminQuestions(Convert.ToInt32(cboxExams.SelectedValue));
                ExamValueCbox = Convert.ToInt32(cboxExams.SelectedValue);
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            btnAddQuestion.Visible = true;
            btnAddQuestionMain.Hide();
            btnBackAddQst.Show();

            adminQuestionsGridCtrl.adminManageQuestions.btnBackEdit.Visible = false;
            adminQuestionsGridCtrl.adminManageQuestions.btnBackView.Visible = false;
            adminQuestionsGridCtrl.adminManageQuestions.btnEditQuestion.Visible = false;
            adminQuestionsGridCtrl.adminManageQuestions.btnDeleteQuestion.Visible = false;
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.Show();
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionCtrl.Hide();
            adminQuestionsGridCtrl.gridViewQuestions.Hide();


            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.txtQuestion.Clear();
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.txtEditAnswer1.Clear();
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.txtEditAnswer2.Clear();
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.txtEditAnswer3.Clear();
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.txtEditAnswer4.Clear();

            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.txtQuestion.ReadOnly = false;
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.cboxAnswer1.Checked = false;
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.cboxAnswer2.Checked = false;
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.cboxAnswer3.Checked = false;
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.cboxAnswer4.Checked = false;

            adminQuestionsGridCtrl.adminManageQuestions.Show();
        }

        private void btnBackAddQst_Click(object sender, EventArgs e)
        {
            adminQuestionsGridCtrl.adminManageQuestions.Hide();

            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.Hide();
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionCtrl.Show();
            adminQuestionsGridCtrl.gridViewQuestions.Show();
            btnAddQuestion.Visible = false;
            adminQuestionsGridCtrl.adminManageQuestions.btnBackView.Visible = true;
            btnAddQuestionMain.Visible = true;
            btnBackAddQst.Hide();
        }

        private void btnAddQuestion_Click_1(object sender, EventArgs e)
        {
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.Hide();

            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.NewQuestion(adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.txtQuestion.Text, adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.txtEditAnswer1.Text, adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.txtEditAnswer2.Text, adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.txtEditAnswer3.Text, adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.txtEditAnswer4.Text, ExamQuestionsNewEdit.AnswerCorrect, Convert.ToInt32(AdminExamCenterCtrl.ExamValueCbox));

            adminQuestionsGridCtrl.Show();

            adminQuestionsGridCtrl.adminManageQuestions.Hide();

            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionNewEdit.Hide();
            adminQuestionsGridCtrl.adminManageQuestions.adminQuestionCtrl.Show();
            adminQuestionsGridCtrl.gridViewQuestions.Show();

            btnBackAddQst.Hide();

            btnAddQuestion.Hide();

            btnAddQuestionMain.Show();

            adminQuestionsGridCtrl.FillAdminQuestions(Convert.ToInt32(cboxExams.SelectedValue));
        }
    }
}
