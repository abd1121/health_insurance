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
    public partial class search_bottom_grid : UserControl
    {
        public delegate void recipeClickEventhandler(object source, RecipeEventArgs e);
        public event recipeClickEventhandler recipeClick;

        server.Service1 myServer = new server.Service1();
        server.recipe this_recipe;

        public search_bottom_grid()
        {
            InitializeComponent();
            this_recipe = myServer.getRandomRecipe();
            recipeTitle.Text = this_recipe.Title;
            recipeImage.Image = Image.FromFile(this_recipe.Recipe_thumb);
        }

        public search_bottom_grid(string category)
        {
            InitializeComponent();
            this_recipe = myServer.getRandomRecipeByCateegory(category);
            recipeTitle.Text = this_recipe.Title;
            recipeImage.Image = Image.FromFile(this_recipe.Recipe_thumb);
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void recipeClickEvent(object sender, EventArgs e)
        {
            
            OnrecipeClick();
        }

        public void OnrecipeClick()
        {
            if (recipeClick != null)
            {
                recipeClick(this, new RecipeEventArgs { Recipe = this_recipe});
            }
        }
    }
}
