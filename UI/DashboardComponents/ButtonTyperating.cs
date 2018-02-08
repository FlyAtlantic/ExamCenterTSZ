﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamCenterTSZ.UI.ExamCenterComponents;

namespace ExamCenterTSZ.UI.DashboardComponents
{
    public partial class ButtonTyperating : UserControl
    {

        Dashboard DBoard
        { get; set; }

        bool panel = false;

        int eps = 0;

        public ButtonTyperating(string typerating, int examid, Dashboard d, int eps)
        {
            InitializeComponent();

            Update(typerating, examid, eps);

            DBoard = d;
        }

        public void Update(string typerating, int examid, int eps)
        {
            btnTyperating.Text = typerating.ToString();
            btnTyperating.Tag = examid;

            this.eps = eps;
        }



        private void btnTyperating_Click(object sender, EventArgs e)
        {
            
            DBoard.GetQuestions(Convert.ToInt32(btnTyperating.Tag), eps);

            DBoard.epsConfirm.Show();

            DBoard.panelExamPage.Visible = true;

        }
    }
}
