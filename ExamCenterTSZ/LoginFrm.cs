﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamCenterTSZ.Functions;


namespace ExamCenterTSZ.UI
{
    public partial class LoginFrm : Form
    {

        StartImage InitialImg = new StartImage();

        public LoginFrm()
        {
            InitializeComponent();

            this.AcceptButton = btnLogin;

            ShowInTaskbar = false;

            InitialImg.Show();
        

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login.ValidateLogin(txtEmail.Text, txtPassword.Text))
                {
                    Dashboard d = new Dashboard();
                    //login correto
                    InitialImg.Hide();
                    d.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Properties.Settings.Default.Email = txtEmail.Text;
                Properties.Settings.Default.Password = txtPassword.Text;

                Properties.Settings.Default.Save();

            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            txtEmail.Text = Properties.Settings.Default.Email;
            txtPassword.Text = Properties.Settings.Default.Password;
        }
    }
}
