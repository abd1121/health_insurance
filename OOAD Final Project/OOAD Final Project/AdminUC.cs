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
    public partial class AdminUC : UserControl
    {
        private static AdminUC _instance;
        public AdminUC()
        {
            InitializeComponent();
        }

        public static AdminUC Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new AdminUC();
                }
                return _instance;
            }
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            btnActiveSide.Dock = usersButton.Dock;
            btnActiveSide.Location = usersButton.Location;
            btnActiveSide.BringToFront();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            btnActiveSide.Dock = dashboardBtn.Dock;
            btnActiveSide.Location = dashboardBtn.Location;
            btnActiveSide.BringToFront();
        }
    }
}
