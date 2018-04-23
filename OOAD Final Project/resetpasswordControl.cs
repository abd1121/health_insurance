using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace OOAD_Final_Project
{
    public partial class resetpasswordControl : UserControl
    {
        private static resetpasswordControl _instance;
        public resetpasswordControl()
        {
            InitializeComponent();
        }

        public static resetpasswordControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new resetpasswordControl();
                }
                return _instance;
            }
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            server.Service1 myServer = new server.Service1();
            server.usersParent user = new server.usersParent();
            string email = emailTxtBox.Text;
            user = myServer.getUserBYEmail(email);
            if(user != null)
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("numair.cs@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Forgotten Password (Foodies)";
                mail.Body = "Hello, " + user.Name + " You Have Requested For a Forgotten Password. Your Password is " + user.Password;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("numair.cs@gmail.com", "downloadism.com");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Password Mailed To Your Inbox");
            }
            else
            {
                MessageBox.Show("User Don't Exists In Our System");
            }
        }
    }
}
