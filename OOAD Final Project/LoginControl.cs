using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Final_Project
{
    public partial class LoginControl : UserControl
    {
        public delegate void registerClickEventHandler(object source, EventArgs e);
        public event registerClickEventHandler registerClick;

        public delegate void ForgotPasswordEventHandler(object source, EventArgs e);
        public event ForgotPasswordEventHandler ForgotPassword;

        public delegate void UserLoginEventhandler(object source, EventArgs e);
        public event UserLoginEventhandler UserLogin;

        public delegate void BackLoginClickEventHandler(object source, EventArgs e);
        public event BackLoginClickEventHandler BackLoginClick;
        // ADMIN LOGIN
        public delegate void AdminLoginEventHandler(object source, EventArgs e);
        public event AdminLoginEventHandler AdminLogin;


        private static LoginControl _instance = null;
        public LoginControl()
        {
            InitializeComponent();
            resetForm();
        }

        public static LoginControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoginControl();
                }
                return _instance;
            }
        }

        public void resetForm()
        {
            emailTxtBox.Text = "";
            passTxtBox.Text = "";
            errorRequiredFields.Hide();
            errorInccorectDetails.Hide();
        }

        private void passTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            errorInccorectDetails.Hide();
            errorRequiredFields.Hide();
            passTxtBox.isPassword = true;
        }

        private void forgotPassBtn_Click(object sender, EventArgs e)
        {
            OnForgotPassword();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTxtBox.Text;
            string password = passTxtBox.Text;
            if(email != "" && password != "")
            {
                server.Service1 myServer = new server.Service1();

                server.User user = new server.User();
                user = myServer.getUserBYEmail(email);
                myUtil.loggedIN = user;
                if(myUtil.loggedIN.DietPlan != null)
                {
                    MessageBox.Show("Janu Diet Plan Pehle se Hai");
                }
                else
                {
                    MessageBox.Show("nananana");
                }
                if (user != null)
                {
                    if (user.Password == password)
                    {
                        // SUCCESS MESSAGE --> LOGIN SUCCESSFULY
                            if (user.UserRole == "Admin")
                            {
                                OnAdminLogin();
                            }
                            else if(user.UserRole == "User")
                            {
                                OnUserLogin();
                            }
                    }
                    else
                    {
                        // ERROR MESSAGE --> LOGIN UNSUCCESSFULL
                        errorInccorectDetails.Show();
                    }
                }
                else
                {
                    // ERROR MESSAGE --> USER NOT EXISTS
                    errorInccorectDetails.Show();
                }
            }
            else
            {
                // FILL IN ALL THE REQUIRED FIELDS
                errorRequiredFields.Show();
            }
        }

        private void rgstrHereBtn_Click(object sender, EventArgs e)
        {
            OnRegisterClick();
        }

        public void OnRegisterClick()
        {
            if (registerClick != null)
            {
                registerClick(this, EventArgs.Empty);
            }
        }

        public void OnForgotPassword()
        {
            if (ForgotPassword != null)
            {
                ForgotPassword(this, EventArgs.Empty);
            }
        }

        private void emailTxtBox_OnValueChanged(object sender, EventArgs e)
        {
            errorInccorectDetails.Hide();
            errorRequiredFields.Hide();
        }

        public void OnAdminLogin()
        {
            if (AdminLogin != null)
            {
                AdminLogin(this, EventArgs.Empty);
            }
        }

        public void OnUserLogin()
        {
            if (UserLogin != null)
            {
                UserLogin(this, EventArgs.Empty);
            }
        }

        private void backButtonClick(object sender, EventArgs e)
        {
            OnBackLoginClick();
        }

        public void OnBackLoginClick()
        {
            if (BackLoginClick != null)
            {
                BackLoginClick(this, EventArgs.Empty);
            }
        }

    }
}
