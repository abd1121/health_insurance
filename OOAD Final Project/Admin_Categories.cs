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
    public partial class Admin_Categories : UserControl
    {
        private static Admin_Categories _instance;
        public Admin_Categories()
        {
            InitializeComponent();
            loadCategories();
        }

        public static Admin_Categories Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Admin_Categories();
                }
                return _instance;
            }
        }

        private void addnewcategorybtn_Click(object sender, EventArgs e)
        {
            addnewcategory new_category = new addnewcategory();
            new_category.addCategoryClick += OnaddCategoryClick;
            new_category.Show();
        }

        private void loadCategories()
        {
            server.Service1 myServer = new server.Service1();
            int index = 0;
            foreach (server.category c in myServer.getAllCategories())
            {
                category_view c_view = new category_view(c, index++);
                categoriesContainer.Controls.Add(c_view);
            }
        }

        private void categoriesContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        public void OnaddCategoryClick(object source, EventArgs e)
        {
            categoriesContainer.Controls.Clear();
            loadCategories();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            categoriesContainer.Controls.Clear();
            loadCategories();
        }
    }
}
