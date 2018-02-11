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

namespace ExamCenterTSZ.UI.AdminPanel
{
    public partial class AdminExamCenterCtrl : UserControl
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            //adminQuestionsGridCtrl1.FillAdminQuestions(Convert.ToInt32(textBox1.Text));
        }

        private void cboxExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxExams.ValueMember == "")
                adminQuestionsGridCtrl.FillAdminQuestions(1);
            else
                adminQuestionsGridCtrl.FillAdminQuestions(Convert.ToInt32(cboxExams.SelectedValue));
        }
    }
}
