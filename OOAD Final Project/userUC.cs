﻿using System;
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
    public partial class userUC : UserControl
    {
        public delegate void logoutClickEventHandler(object source, EventArgs e);
        public event logoutClickEventHandler logoutClick;

        private static userUC _instance;
        public userUC()
        {
            InitializeComponent();

            user_dashboard r = user_dashboard.Instance;
            if (!container.Controls.Contains(r))
            {
                container.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
            r.whatEatClick += OnwhatEatClick;
        }

        public static userUC Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new userUC();
                }
                return _instance;
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            btnActiveSide.Dock = dashboardBtn.Dock;
            btnActiveSide.Location = dashboardBtn.Location;
            btnActiveSide.BringToFront();

            user_dashboard r = user_dashboard.Instance;
            if (!container.Controls.Contains(r))
            {
                container.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
            r.whatEatClick += OnwhatEatClick;
        }

        public void OnwhatEatClick(object source, EventArgs e) {
            register_user_diet r = new register_user_diet();
            if (!container.Controls.Contains(r))
            {
                container.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
        }

        private void dietplannerButton_Click(object sender, EventArgs e)
        {
            btnActiveSide.Dock = dietplannerButton.Dock;
            btnActiveSide.Location = dietplannerButton.Location;
            btnActiveSide.BringToFront();

            user_planner r = user_planner.Instance;
            if (!container.Controls.Contains(r))
            {
                container.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            btnActiveSide.Dock = settingsButton.Dock;
            btnActiveSide.Location = settingsButton.Location;
            btnActiveSide.BringToFront();

            user_settings r = user_settings.Instance;
            if (!container.Controls.Contains(r))
            {
                container.Controls.Add(r);
                r.BringToFront();
            }
            else
            {
                r.BringToFront();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            OnlogoutClick();
        }

        public void OnlogoutClick()
        {
            if (logoutClick != null)
            {
                logoutClick(this, EventArgs.Empty);
            }
        }
    }
}
