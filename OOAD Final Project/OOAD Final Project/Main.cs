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
            server.Service1 myService = new server.Service1();
            myService.addUser("Muhammad Numair", "admin", "123", "03322652270");
            
            InitializeComponent();
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
        }
        // EVENT FUNCTIONS :: ENDS
    }
}
