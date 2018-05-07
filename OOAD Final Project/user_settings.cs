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
    public partial class user_settings : UserControl
    {
        server.Service1 myServer = new server.Service1();
        public user_settings()
        {
            InitializeComponent();
        }
        private static user_settings _instance;

        public static user_settings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new user_settings();
                }
                return _instance;
            }
        }

        private void save_changesBtn_Click(object sender, EventArgs e)
        {
            myServer.save_user_settings(myUtil.loggedIN, nametxtbox.Text, emailtxtbox.Text, passtxtbox.Text, usernametxtbox.Text, phonetxtbox.Text);
        }

        private void user_settings_Load(object sender, EventArgs e)
        {
            nametxtbox.Text = myUtil.loggedIN.Name;
            passtxtbox.Text = myUtil.loggedIN.Password;
            usernametxtbox.Text = myUtil.loggedIN.Username;
            emailtxtbox.Text = myUtil.loggedIN.Email;
            phonetxtbox.Text = myUtil.loggedIN.Phone;

            foreach(server.category c in myServer.getAllCategories()) {
                comboBox1.Items.Add(c.Category_name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
