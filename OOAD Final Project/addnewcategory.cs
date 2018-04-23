using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Final_Project
{
    public partial class addnewcategory : Form
    {
        public delegate void addCategoryClickEventHandler(object source, EventArgs e);
        public event addCategoryClickEventHandler addCategoryClick;

        server.Service1 myServer = new server.Service1();

        int this_index;
        server.category this_category;
        public addnewcategory()
        {
            InitializeComponent();
        }

        public addnewcategory(server.category category, int index)
        {
            InitializeComponent();
            categorynametxtbox.Text = category.Category_name;

            this_category = category;
            this_index = index;

            addcategoryBtn.Text = "Save Changes";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addcategoryBtn_Click(object sender, EventArgs e)
        {
            string c_name = categorynametxtbox.Text;
            if(this_category == null)
            {
                myServer.addCategory(c_name);
            }
            else
            {
                myServer.updateCategory(this_index.ToString(), c_name);
            }

            OnaddCategoryClick();
            this.Hide();
        }

        public void OnaddCategoryClick()
        {
            if(addCategoryClick != null)
            {
                addCategoryClick(this, EventArgs.Empty);
            }
        }
    }
}
