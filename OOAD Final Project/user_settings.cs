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
    public partial class user_settings : UserControl
    {
        public user_settings()
        {
            InitializeComponent();
        }
        private static user_settings _instance;

        public static user_settings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new user_settings();
                }
                return _instance;
            }
        }
    }
}
