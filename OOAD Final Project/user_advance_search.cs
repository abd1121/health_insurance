using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Final_Project
{
    public partial class user_advance_search : Form
    {
        public delegate void whatEatClickEventhandler(object source, AdvanceWhatEatEventArgs e);
        public event whatEatClickEventhandler whatEatClick;

        public user_advance_search()
        {
            InitializeComponent();
            server.Service1 myServer = new server.Service1();
            foreach (server.category c in myServer.getAllCategories())
            {
                searchBy.AddItem(c.Category_name);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBy_onItemSelected(object sender, EventArgs e)
        {

        }

        private void mainContent_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            OnwhatEatClick();
        }

        public void OnwhatEatClick()
        {
            if (whatEatClick != null)
            {
                whatEatClick(this, new AdvanceWhatEatEventArgs {category = searchBy.selectedValue});
            }
        }
    }
}
