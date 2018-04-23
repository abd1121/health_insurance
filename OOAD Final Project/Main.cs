using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Final_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            // DEFAULT ADMIN
            InitializeComponent();

            HomeControl h = HomeControl.Instance;
            if (!contentPanel.Controls.Contains(h))
            {
                contentPanel.Controls.Add(h);
                h.BringToFront();
            }
            else
            {
                h.BringToFront();
            }
            signupMenuButton.BringToFront();
            loginMenuButton.BringToFront();

            h.WhatEatButtonClick += OnWhatEatButtonClick;
        }

        // BUTTON CLICKS
        private void closeButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButtonClick(object sender, EventArgs e)
        {
            LoginControl l1 = LoginControl.Instance;
            l1.resetForm();
            if (!contentPanel.Controls.Contains(l1))
            {
                contentPanel.Controls.Add(l1);
                l1.BringToFront();
            }
            else
            {
                l1.BringToFront();
            }
            signupMenuButton.BringToFront();
            loginMenuButton.BringToFront();

            // EVENTS
            l1.registerClick += this.onRegisterClick;
            l1.ForgotPassword += this.OnForgotPassword;
            l1.AdminLogin += this.onAdminLogin;
            l1.BackLoginClick += homeButtonClick;
            l1.UserLogin += this.onUserLogin;
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
            RegisterControl r = RegisterControl.Instance;
            r.resetForm();
            if (!contentPanel.Controls.Contains(r))
            {
                contentPanel.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
            signupMenuButton.BringToFront();
            loginMenuButton.BringToFront();
            r.registeredSuccess += this.OnregisteredSuccess;
            r.LoginClick += this.onLoginClick;
        }

        private void homeButtonClick(object sender, EventArgs e)
        {
            HomeControl h = HomeControl.Instance;
            if (!contentPanel.Controls.Contains(h))
            {
                contentPanel.Controls.Add(h);
                h.BringToFront();
            }
            else
            {
                h.BringToFront();
            }
            signupMenuButton.BringToFront();
            loginMenuButton.BringToFront();
        }

        // BUTTON CLICKS :: ENDS

        // EVENT FUNCTIONS
        public void onLoginClick(object source, EventArgs e)
        {
            LoginControl l1 = LoginControl.Instance;
            l1.resetForm();
            if (!contentPanel.Controls.Contains(l1))
            {
                contentPanel.Controls.Add(l1);
                l1.BringToFront();
            }
            else
            {
                l1.BringToFront();
            }
            signupMenuButton.BringToFront();
            loginMenuButton.BringToFront();
            l1.registerClick += this.onRegisterClick;
            l1.ForgotPassword += this.OnForgotPassword;
            l1.AdminLogin += this.onAdminLogin;
            l1.UserLogin += this.onUserLogin;
            l1.BackLoginClick += homeButtonClick;
        }

        public void onRegisterClick(object source, EventArgs e)
        {
            RegisterControl r = RegisterControl.Instance;
            r.resetForm();
            if (!contentPanel.Controls.Contains(r))
            {
                contentPanel.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
            signupMenuButton.BringToFront();
            loginMenuButton.BringToFront();
            r.registeredSuccess += this.OnregisteredSuccess;
            r.LoginClick += this.onLoginClick;
        }

        public void OnregisteredSuccess(Object source, EventArgs e)
        {
            registeredSuccessUC r = registeredSuccessUC.Instance;
            if (!contentPanel.Controls.Contains(r))
            {
                contentPanel.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
            r.loginClick += this.onLoginClick;
        }

        public void OnForgotPassword(Object source, EventArgs e)
        {
            resetpasswordControl r = resetpasswordControl.Instance;
            if (!contentPanel.Controls.Contains(r))
            {
                contentPanel.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
            signupMenuButton.BringToFront();
            loginMenuButton.BringToFront();
        }

        public void onAdminLogin(object source, EventArgs e)
        {
            AdminUC r = AdminUC.Instance;
            if (!contentPanel.Controls.Contains(r))
            {
                contentPanel.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
            r.logoutbtnClick += this.onLoginClick;
        }

        public void OnWhatEatButtonClick(object source, EventArgs e)
        {
            guest_user_diet r = new guest_user_diet();
            if (!contentPanel.Controls.Contains(r))
            {
                contentPanel.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }

            signupMenuButton.BringToFront();
            loginMenuButton.BringToFront();

            r.backButtonClick += homeButtonClick;
        }

        public void onUserLogin(object source, EventArgs e)
        {
            userUC r = userUC.Instance;
            if (!contentPanel.Controls.Contains(r))
            {
                contentPanel.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
            r.logoutClick += onLoginClick;
        }
        // EVENT FUNCTIONS :: ENDS
    }
}
