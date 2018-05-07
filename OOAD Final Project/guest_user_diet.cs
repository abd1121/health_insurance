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
    public partial class guest_user_diet : UserControl
    {
        public delegate void backButtonClickEventHandler(object source, EventArgs e);
        public event backButtonClickEventHandler backButtonClick;

        //public guest_user_diet()
        //{
        //    InitializeComponent();
        //}

        public guest_user_diet()
        {
            InitializeComponent();
            search_top_grid s = new search_top_grid();
            top_container.Controls.Add(s);
            search_bottom_grid sb1 = new search_bottom_grid();
            relatedSuggetionsContainer.Controls.Add(sb1);
            sb1.recipeClick += OnrecipeClick;

            search_bottom_grid sb2 = new search_bottom_grid();
            relatedSuggetionsContainer.Controls.Add(sb2);
            sb2.recipeClick += OnrecipeClick;

            search_bottom_grid sb3 = new search_bottom_grid();
            relatedSuggetionsContainer.Controls.Add(sb3);
            sb3.recipeClick += OnrecipeClick;

            search_bottom_grid sb4 = new search_bottom_grid();
            relatedSuggetionsContainer.Controls.Add(sb4);
            sb4.recipeClick += OnrecipeClick;
        }

        public void OnrecipeClick(object source, RecipeEventArgs e)
        {
            
            search_top_grid s = new search_top_grid(e.Recipe);
            top_container.Controls.Add(s);
            s.BringToFront();
        }

        private void loadOffersButton_Click(object sender, EventArgs e)
        {
            OnbackButtonClick();
        }

        public void OnbackButtonClick()
        {
            if (backButtonClick != null)
            {
                backButtonClick(this, EventArgs.Empty);
            }
        }
    }
}
