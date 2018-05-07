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
    public partial class register_user_diet : UserControl
    {
        string this_category;
        public register_user_diet()
        {
            InitializeComponent();
            search_top_grid s = new search_top_grid();
            top_container.Controls.Add(s);
            for (int i = 0; i < 4; ++i)
            {
                search_bottom_grid sb = new search_bottom_grid();
                relatedSuggetionsContainer.Controls.Add(sb);
            }
        }

        public register_user_diet(string category)
        {
            InitializeComponent();
            this_category = category;
            search_top_grid s = new search_top_grid(this_category);
            top_container.Controls.Add(s);
            for (int i = 0; i < 4; ++i)
            {
                search_bottom_grid sb = new search_bottom_grid(this_category);
                relatedSuggetionsContainer.Controls.Add(sb);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void register_user_diet_Load(object sender, EventArgs e)
        {
            label2.Text = "Hi, " + myUtil.loggedIN.Name + " You Should Have This Today";
        }
    }
}
