using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamCenterUpdate;

namespace ExamCenterTSZ
{
    public partial class StartImage : Form, ExamCenterUpdatable
    {
        private ExamCenterUpdater updater;

        public StartImage()
        {
            ShowInTaskbar = false;

            InitializeComponent();

            label1.Text = String.Format("Version: {0}", this.ApplicationAssembly.GetName().Version.ToString());
            //updater = new ExamCenterUpdater(this);

            //updater.DoUpdate();
        }

        public string ApplicationName
        {
            get { return "ExamCenterTSZ"; }
        }

        public string ApplicationID
        {
            get { return "ExamCenterTSZ"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("http://flyatlantic-va.com/site/programsC/update.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updater = new ExamCenterUpdater(this);

            updater.DoUpdate();
        }
    }
}
