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
    public partial class planner_view : UserControl
    {
        public planner_view()
        {
            InitializeComponent();
            mondayRecpie.Text = myUtil.loggedIN.DietPlan.Monday.Title;
            tuesdayRecpie.Text = myUtil.loggedIN.DietPlan.Tuesday.Title; ;
            wednesdayRecpie.Text = myUtil.loggedIN.DietPlan.Wednesday.Title;
            thursdayRecpie.Text = myUtil.loggedIN.DietPlan.Thursday.Title;
            fridayRecpie.Text = myUtil.loggedIN.DietPlan.Friday.Title;
            saturdayRecpie.Text = myUtil.loggedIN.DietPlan.Saturday.Title;
            sundayRecpie.Text = myUtil.loggedIN.DietPlan.Sunday.Title;
        }
    }
}
