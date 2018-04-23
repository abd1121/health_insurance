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
    public partial class Admin_Dashboard : UserControl
    {
        private static Admin_Dashboard _instance;
        server.Service1 myService = new server.Service1();
        public Admin_Dashboard()
        {
            InitializeComponent();
            int totalUsers;
            bool usersCountPass;
            myService.getUsersCount(out totalUsers, out usersCountPass);
            usersCount.Text = totalUsers.ToString();
        }

        public static Admin_Dashboard Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Admin_Dashboard();
                }
                return _instance;
            }
        }
    }
}
