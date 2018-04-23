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
    public partial class RegisterControl : UserControl
    {
        server.Service1 myserver = new server.Service1();
        // Event & Delegates
        public delegate void registeredSuccessEventHandler(Object source, EventArgs e);
        public event registeredSuccessEventHandler registeredSuccess;



        public delegate void LoginClickEventHandler(object source, EventArgs e);
        public event LoginClickEventHandler LoginClick;
        // Event & Delegates :: END

        private static RegisterControl _instance = null;
        public RegisterControl()
        {
            InitializeComponent();
            resetForm();
        }

        public static RegisterControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new RegisterControl();
                }
                return _instance;
            }
        }
        
        public void resetForm()
        {
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneTextBox.Text = "";
            passwordTextBox.Text = "";
            errorRequiredFields.Hide();
            errorAlreadyExists.Hide();
        }

        private void passwordTextBox_OnValueChanged(object sender, EventArgs e)
        {
            passwordTextBox.isPassword = true;
            errorRequiredFields.Hide();
        }


        private void resgiterButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string phone = phoneTextBox.Text;

            if (name!="" && email != "" && password != "" && phone != "")
            {
                server.usersParent user = new server.usersParent();
                user = myserver.getUserBYEmail(email);
                if (user == null)
                {
                    myserver.addUser(name, email, password, phone);

                    Main homeControl = new Main();
                    // ADD HO GYA KA SUCCESS MESSAGE SHOW KARE
                    OnregisteredSuccess();
                }
                else
                {
                    errorAlreadyExists.Show();
                    // PEHLE SE USER MOJOOD HAI KA ERROR SHOW KARE
                }
            }
            else
            {
                // ERROR SHOW KARWAE KE BHAE JAN FIELDS TO PEHLE SARI FIL KARO 
                errorRequiredFields.Show();
            }
        }

        private void emailTextBox_OnValueChanged(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            errorRequiredFields.Hide();
            errorAlreadyExists.Hide();
            server.usersParent user = new server.usersParent();
            user = myserver.getUserBYEmail(email);
            if (UserDL.getUserBYEmail(email) != null)
            {
                //ERROR SHOW KARWA DE KE USER PEHLE SE HAI
                errorAlreadyExists.Show();
            }
        }

        public void OnregisteredSuccess()
        {
            if (registeredSuccess != null)
            {
                registeredSuccess(this, EventArgs.Empty);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            OnLoginClick();
        }

        public void OnLoginClick()
        {
            if (LoginClick != null)
            {
                LoginClick(this, EventArgs.Empty);
            }
        }

        private void phoneTextBox_OnValueChanged(object sender, EventArgs e)
        {
            errorRequiredFields.Hide();
        }

        private void nameTextBox_OnValueChanged(object sender, EventArgs e)
        {
            errorRequiredFields.Hide();
        }

        private void RegisterControl_Load(object sender, EventArgs e)
        {

        }
    }
    
}
