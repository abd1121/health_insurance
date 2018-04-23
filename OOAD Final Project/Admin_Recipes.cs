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
    public partial class Admin_Recipes : UserControl
    {
        server.Service1 myServer = new server.Service1();
        private static Admin_Recipes _instance;
        public Admin_Recipes()
        {
            InitializeComponent();
            loadRecipes();
        }

        public static Admin_Recipes Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Admin_Recipes();
                }
                return _instance;
            }
        }

        private void loadRecipes()
        {
            int index = 0;
            foreach(server.recipe r in myServer.getRecipes())
            {
                receipie_view new_recipe = new receipie_view(r, index++);
                recipiesContainer.Controls.Add(new_recipe);
            }
        }

        private void addnewrecipebtn_Click(object sender, EventArgs e)
        {
            addnewrecipe newrecipe = new addnewrecipe();
            newrecipe.AddRecipeBtnClick += OnAddRecipeBtnClick;
            newrecipe.Show();
        }

        public void OnAddRecipeBtnClick(object source, EventArgs e)
        {
            recipiesContainer.Controls.Clear();
            loadRecipes();
        }

        public void OndeleteRecipe(object source, EventArgs e)
        {
            recipiesContainer.Controls.Clear();
            loadRecipes();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            recipiesContainer.Controls.Clear();
            loadRecipes();
        }
    }
}
