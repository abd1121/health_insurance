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
    public partial class category_view : UserControl
    {
        server.category this_category;

        server.Service1 myServer = new server.Service1();
        int this_index;
        public category_view()
        {
            InitializeComponent();
        }

        public category_view(server.category category, int index)
        {
            InitializeComponent();
            categoryName.Text = category.Category_name;
            this_index = index;
            this_category = category;
        }

        private void categoryName_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            myServer.deleteCategory(this_index.ToString());
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            addnewcategory edit_category = new addnewcategory(this_category, this_index);
            edit_category.Show();
        }
    }
}
