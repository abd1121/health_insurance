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
    public partial class Admin_Users : UserControl
    {
        server.Service1 myService = new server.Service1();
        private static Admin_Users _instance;
        public Admin_Users()
        {
            InitializeComponent();
            loadUsers();
        }

        public void loadUsers()
        {
            int index = 0;
            foreach (server.User user in myService.getAllUsers())
            {
                UserView new_user = new UserView(user, index++);
                usersContainer.Controls.Add(new_user);
            }
            
        }

        public void clearUsers()
        {
            usersContainer.Controls.Clear();
        }

        public static Admin_Users Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Admin_Users();
                }
                return _instance;
            }
        }
        public void onUseradded(object source, EventArgs e)
        {
            clearUsers();
            this.loadUsers();
        }
        private void loginMenuButton_Click(object sender, EventArgs e)
        {
            addnewUser adduser = new addnewUser();
            adduser.useradded += onUseradded;
            adduser.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            clearUsers();
            this.loadUsers();
        }
    }
}
