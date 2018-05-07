using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            recipe_thumbnail.Image = Image.FromFile(this_recipe.Recipe_thumb);
        }

        public search_top_grid(string category)
        {
            InitializeComponent();
            this_recipe = myServer.getRandomRecipeByCateegory(category);
            recipe_description.Text = this_recipe.Desc;
            recipeTitle.Text = this_recipe.Title;
            recipe_thumbnail.Image = Image.FromFile(this_recipe.Recipe_thumb);
        }

        public search_top_grid(server.recipe recipe)
        {
            InitializeComponent();
            this_recipe = recipe;
            recipe_description.Text = this_recipe.Desc;
            recipeTitle.Text = this_recipe.Title;
            recipe_thumbnail.Image = Image.FromFile(this_recipe.Recipe_thumb);
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void loadRecipe_Click(object sender, EventArgs e)
        {
            load_recipe newTutorial = new load_recipe(this_recipe);
            newTutorial.Show();
        }
    }
}
