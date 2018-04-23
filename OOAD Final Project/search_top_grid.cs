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
    public partial class search_top_grid : UserControl
    {
        server.Service1 myServer = new server.Service1();
        server.recipe this_recipe;
        public search_top_grid()
        {
            InitializeComponent();
            this_recipe = myServer.getRandomRecipe();
            recipe_description.Text = this_recipe.Desc;
            recipeTitle.Text = this_recipe.Title;
        }
    }
}
