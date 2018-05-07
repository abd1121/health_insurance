﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
namespace OOAD_Final_Project
{
    public partial class addnewrecipe : Form
    {
        string destination;
        public delegate void AddRecipeBtnClickEventHandler(object source, EventArgs e);
        public event AddRecipeBtnClickEventHandler AddRecipeBtnClick;
        server.Service1 myServer = new server.Service1();

        server.recipe this_recipe;
        int this_index;

        public addnewrecipe()
        {
            InitializeComponent();
            foreach(server.category c in myServer.getAllCategories())
            {
                categoriesList.Items.Add(c.Category_name);
            }
        }

        public addnewrecipe(server.recipe r, int index)
        {
            InitializeComponent();
            foreach (server.category c in myServer.getAllCategories())
            {
                categoriesList.Items.Add(c.Category_name);
            }
            this_recipe = r;
            this_index = index;

            titletxtbox.Text = r.Title;
            authortxtbox.Text = r.Author;
            urltextbox.Text = r.Video_url;
            desctxtbox.Text = r.Desc;

            addRecipeBtn.Text = "Save Changes";
        }

        private void addnewrecipe_Load(object sender, EventArgs e)
        {

        }

        public static byte[] imageToBytes(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private void addRecipeBtn_Click(object sender, EventArgs e)
        {
            string title = titletxtbox.Text;
            string author = authortxtbox.Text;
            string date = datetxtbox.Value.ToString("yyyy-MM-dd");
            string desc = desctxtbox.Text;
            string url = urltextbox.Text;
            List<string> categories = new List<string>();
            foreach (var item in categoriesList.SelectedItems)
            {
                categories.Add(item.ToString());
            }
            Image recipe_thubmnail = pictureView.Image;

            if(this_recipe == null)
            {
                myServer.addRecipe(title, author, date, url, desc, categories.ToArray(), destination);
            }
            else
            {
                myServer.updateRecipe(this_index.ToString(),title, author, date, url, desc, categories.ToArray());
            }
            
            OnAddRecipeBtnClick();
            this.Hide();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void OnAddRecipeBtnClick()
        {
            if (AddRecipeBtnClick != null)
            {
                AddRecipeBtnClick(this, EventArgs.Empty);
            }
        }

        private void chooseImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureView.Image = Image.FromStream(op.OpenFile());
            }
            
            destination = @"F:\Github Project\health_insurance\images\" + Path.GetFileName(op.FileName);
            File.Copy(op.FileName, destination);
        }
    }
}
