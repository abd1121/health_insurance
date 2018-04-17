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
    public partial class registeredSuccessUC : UserControl
    {
        public delegate void loginClickEventHandler(object source, EventArgs e);
        public event loginClickEventHandler loginClick;
        private static registeredSuccessUC _instance;
        public registeredSuccessUC()
        {
            InitializeComponent();
        }

        public static registeredSuccessUC Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new registeredSuccessUC();
                }
                return _instance;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void resgiterButton_Click(object sender, EventArgs e)
        {
            onLoginClick();
        }

        public void onLoginClick()
        {
            if (loginClick != null)
            {
                loginClick(this, EventArgs.Empty);
            }
        }

    }
}
