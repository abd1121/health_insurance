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
    public partial class receipie_view : UserControl
    {
        public delegate void deleteRecipeEventaHandler(object source, EventArgs e);
        public event deleteRecipeEventaHandler deleteRecipe;

        server.recipe this_recipe;
        int this_index;
        server.Service1 myServer = new server.Service1();
        public receipie_view()
        {
            InitializeComponent();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public receipie_view(server.recipe r, int index)
        {
            InitializeComponent();
            recipeTitle.Text = r.Title;
            this_recipe = r;
            this_index = index;
            recipeImage.Image = Image.FromFile(r.Recipe_thumb);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            addnewrecipe edit_recipe = new addnewrecipe(this_recipe, this_index);
            edit_recipe.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            myServer.deleteRecipe(this_index.ToString());
        }

         public void OndeleteRecipe()
        {
            if(deleteRecipe != null){
                deleteRecipe(this, EventArgs.Empty);
            }
        }

        private void recipeImage_Click(object sender, EventArgs e)
        {
            recipe_details_view dw = new recipe_details_view(this_recipe);
            dw.Show();
        }

        private void recipeTitle_Click(object sender, EventArgs e)
        {
            recipe_details_view dw = new recipe_details_view(this_recipe);
            dw.Show();
        }
    }
}
