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
        public delegate void WhatEatButtonClickContainer(object source, EventArgs e);
        public event WhatEatButtonClickContainer WhatEatButtonClick;
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

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            
            OnWhatEatButtonClick();
        }

        public void OnWhatEatButtonClick()
        {
            if (WhatEatButtonClick != null)
            {
                WhatEatButtonClick(this, EventArgs.Empty);
            }
        }
    }
}
