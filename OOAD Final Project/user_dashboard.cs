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
    public partial class user_dashboard : UserControl
    {
        public delegate void whatEatClickEventhandler(object source, EventArgs e);
        public event whatEatClickEventhandler whatEatClick;

        public delegate void AdvanceClickEventhandler(object source, EventArgs e);
        public event whatEatClickEventhandler AdvanceClick;
        private static user_dashboard _instance;
        public user_dashboard()
        {
            InitializeComponent();
        }

        public static user_dashboard Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new user_dashboard();
                }
                return _instance;
            }
        }

        private void advanceSearch_click(object sender, EventArgs e)
        {
            OnAdvanceClick();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            OnwhatEatClick();
        }

        public void OnwhatEatClick() {
            if (whatEatClick !=null) {
                whatEatClick(this, EventArgs.Empty);
            }
        }

        public void OnAdvanceClick()
        {
            if (whatEatClick != null)
            {
                AdvanceClick(this, EventArgs.Empty);
            }
        }
    }
}
