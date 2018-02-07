using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCenterTSZ.UI.ExamCenterComponents
{
    class ExamCenter : ApplicationContext
    {
        public Exam CurrentExam
        { get; set; }

        //public ExamFrmCtrl UI
        //{ get; set; }

        public ExamCenter()
        {
            //UI = new ExamForm();

            //UI.Show();
            //UI.StartExam(Exam.FromSQL(0));
        }
    }
}
