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
    public partial class HomeControl : UserControl
    {
        private static HomeControl _instance = null;

        public HomeControl()
        {
            InitializeComponent();
        }

        public static HomeControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new HomeControl();
                }
                return _instance;
            }
        }
    }
}
