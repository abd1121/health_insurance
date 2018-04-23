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
        public delegate void logoutBtnClickEventHandler(object source, EventArgs e);
        public event logoutBtnClickEventHandler logoutbtnClick;

        private static AdminUC _instance;
        public AdminUC()
        {
            InitializeComponent();
            username.Text = myUtil.loggedIN.Name;
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
            

            Admin_Users r = Admin_Users.Instance;
            if (!container.Controls.Contains(r))
            {
                container.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            btnActiveSide.Dock = dashboardBtn.Dock;
            btnActiveSide.Location = dashboardBtn.Location;
            btnActiveSide.BringToFront();

            Admin_Dashboard r = Admin_Dashboard.Instance;
            if (!container.Controls.Contains(r))
            {
                container.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
        }

        private void recipeButton_Click(object sender, EventArgs e)
        {
            btnActiveSide.Dock = recipeButton.Dock;
            btnActiveSide.Location = recipeButton.Location;
            btnActiveSide.BringToFront();

            Admin_Recipes r = Admin_Recipes.Instance;
            if (!container.Controls.Contains(r))
            {
                container.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            btnActiveSide.Dock = categoriesButton.Dock;
            btnActiveSide.Location = categoriesButton.Location;
            btnActiveSide.BringToFront();

            Admin_Categories r = Admin_Categories.Instance;
            if (!container.Controls.Contains(r))
            {
                container.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
        }

        private void offersButton_Click(object sender, EventArgs e)
        {
            btnActiveSide.Dock = offersButton.Dock;
            btnActiveSide.Location = offersButton.Location;
            btnActiveSide.BringToFront();
        }

        private void advertisersButton_Click(object sender, EventArgs e)
        {
            btnActiveSide.Dock = advertisersButton.Dock;
            btnActiveSide.Location = advertisersButton.Location;
            btnActiveSide.BringToFront();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            myUtil.loggedIN = null;
            OnlogoutbtnClick();
        }

        public void OnlogoutbtnClick()
        {
            if (logoutbtnClick != null)
            {
                logoutbtnClick(this, EventArgs.Empty);
            }
        }

        private void admin_Dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActiveSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
