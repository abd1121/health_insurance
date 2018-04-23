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
            for(int i = 0; i < 4; ++i)
            {
                search_bottom_grid sb = new search_bottom_grid();
                relatedSuggetionsContainer.Controls.Add(sb);
            }
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
