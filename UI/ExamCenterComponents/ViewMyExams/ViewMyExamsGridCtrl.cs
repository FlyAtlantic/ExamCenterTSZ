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
using ExamCenterTSZ.UI.ExamCenterComponents.ViewMyExams;

namespace ExamCenterTSZ.UI.ExamCenterComponents
{
    public partial class ViewMyExamsGridCtrl : UserControl
    {
        public ViewMyExamsGridCtrl()
        {
            InitializeComponent();

            FillMyExams();

        }

        private void FillMyExams()
        {
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                string sqlLogbook = "SELECT examassigned as `Exam ID`, date as Date, result as Result from exam_results left join utilizadores on exam_results.pilotid = utilizadores.user_id where user_email=@Email";

                MySqlCommand sqlCmd = new MySqlCommand(sqlLogbook, conn);
                sqlCmd.Parameters.AddWithValue("@Email", Properties.Settings.Default.Email);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                gridViewExams.DataSource = ds.Tables[0];
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

        private void gridViewExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnViewExam.TabIndex = Convert.ToInt32(gridViewExams.Rows[e.RowIndex].Cells["Exam ID"].Value);
        }

        private void btnViewExam_Click(object sender, EventArgs e)
        {
            if (btnViewExam.TabIndex != 0) {
                var MyExamPage = this.Parent as MyExamsCtrl;
                MyExamPage.viewMyExamPageCtrl.Show();
                MyExamPage.viewMyExamPageCtrl.GetQuestions(Convert.ToInt32(btnViewExam.TabIndex));
                Hide();
            }
        }
    }
}
