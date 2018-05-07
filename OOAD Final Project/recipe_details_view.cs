using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOAD_Final_Project
{
    public partial class recipe_details_view : Form
    {
        public recipe_details_view()
        {
            InitializeComponent();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public recipe_details_view(server.recipe recipe)
        {
            InitializeComponent();
            recipeAuthor.Text = recipe.Author;
            recipeDescription.Text = recipe.Desc;
            recipeURL.Text = recipe.Video_url;
            recipeImage.Image = Image.FromFile(recipe.Recipe_thumb);
            recipeTitle.Text = recipe.Title;
            dateAdded.Text = recipe.Date;
        }

        private void exitMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
