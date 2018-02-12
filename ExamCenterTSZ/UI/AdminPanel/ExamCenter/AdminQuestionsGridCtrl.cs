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
    public partial class AdminQuestionsGridCtrl : UserControl
    {
        public AdminQuestionsGridCtrl()
        {
            InitializeComponent();
        }

        public void FillAdminQuestions(int ExamID)
        {
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                string sqlAdminQuestions = "select question_id as `Question ID`, image as `Img`, question as Question from exam_questions where examby = @ExamID";

                MySqlCommand sqlCmd = new MySqlCommand(sqlAdminQuestions, conn);
                sqlCmd.Parameters.AddWithValue("@ExamID", ExamID);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                gridViewQuestions.DataSource = ds.Tables[0];

                var a = this.Parent as AdminExamCenterCtrl;

                a.lblNumQuestions.Text =String.Format("{0} Questions", ds.Tables[0].Select("`Question ID` is not null").Length.ToString());
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

        private void gridViewQuestions_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            adminManageQuestions.btnEditQuestion.Visible = true;
            adminManageQuestions.btnDeleteQuestion.Visible = true;
            adminManageQuestions.adminQuestionNewEdit.Hide();
            adminManageQuestions.adminQuestionCtrl.Show();

            gridViewQuestions.Hide();

            adminManageQuestions.Show();

            AdminViewQuestions.OnlyOneFromSql(Convert.ToInt32(gridViewQuestions.Rows[e.RowIndex].Cells["Question ID"].Value));

            adminManageQuestions.adminQuestionCtrl.Update();

            adminManageQuestions.btnEditQuestion.TabIndex = Convert.ToInt32(gridViewQuestions.Rows[e.RowIndex].Cells["Question ID"].Value);
            
        }
    }
}
