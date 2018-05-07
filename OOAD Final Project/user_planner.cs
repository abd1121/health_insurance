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
    public partial class user_planner : UserControl
    {
        public user_planner()
        {
            InitializeComponent();
        }
        private static user_planner _instance;

        public static user_planner Instance
        {
            get
            {
                _instance = new user_planner();
                return _instance;
            }

        }

        private void load_generate_diet_plan()
        {

        }

        public void loadPlans()
        {
            planner_view pv = new planner_view();
            dietPlanContainer.Controls.Add(pv);
        }
        private void dietPlanBtn_Click(object sender, EventArgs e)
        {
            server.Service1 myServer = new server.Service1();
            myUtil.loggedIN = myServer.generateDietPlan(myUtil.loggedIN);
            loadPlans();
        }

        private void user_planner_Load(object sender, EventArgs e)
        {
            if(myUtil.loggedIN.DietPlan != null)
            {
                loadPlans();
            }
        }
    }
}
