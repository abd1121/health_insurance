namespace OOAD_Final_Project
{
    partial class userUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.username = new System.Windows.Forms.Label();
            this.userProfile = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dietplannerButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnActiveSide = new System.Windows.Forms.Panel();
            this.dashboardBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.container = new System.Windows.Forms.Panel();
            this.userprofileRound = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.userProfile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.dietplannerButton);
            this.panel1.Controls.Add(this.btnActiveSide);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 435);
            this.panel1.TabIndex = 2;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBtn.BorderRadius = 5;
            this.logoutBtn.ButtonText = "Logout";
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.DisabledColor = System.Drawing.Color.Gray;
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.logoutBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.logoutBtn.Iconimage = null;
            this.logoutBtn.Iconimage_right = null;
            this.logoutBtn.Iconimage_right_Selected = null;
            this.logoutBtn.Iconimage_Selected = null;
            this.logoutBtn.IconMarginLeft = 0;
            this.logoutBtn.IconMarginRight = 0;
            this.logoutBtn.IconRightVisible = true;
            this.logoutBtn.IconRightZoom = 0D;
            this.logoutBtn.IconVisible = true;
            this.logoutBtn.IconZoom = 40D;
            this.logoutBtn.IsTab = true;
            this.logoutBtn.Location = new System.Drawing.Point(60, 25);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.logoutBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.logoutBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.logoutBtn.selected = false;
            this.logoutBtn.Size = new System.Drawing.Size(99, 26);
            this.logoutBtn.TabIndex = 19;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutBtn.Textcolor = System.Drawing.Color.White;
            this.logoutBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.username.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(59, 7);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(124, 17);
            this.username.TabIndex = 1;
            this.username.Text = "Muhammad Numair";
            // 
            // userProfile
            // 
            this.userProfile.Image = global::OOAD_Final_Project.Properties.Resources._30595282_1944152219247918_2402168826331398144_n;
            this.userProfile.Location = new System.Drawing.Point(6, 6);
            this.userProfile.Name = "userProfile";
            this.userProfile.Size = new System.Drawing.Size(50, 50);
            this.userProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userProfile.TabIndex = 1;
            this.userProfile.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 62);
            this.panel2.TabIndex = 1;
            // 
            // settingsButton
            // 
            this.settingsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.settingsButton.BackColor = System.Drawing.Color.White;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.BorderRadius = 0;
            this.settingsButton.ButtonText = "  Settings";
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.DisabledColor = System.Drawing.Color.Gray;
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.settingsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.settingsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("settingsButton.Iconimage")));
            this.settingsButton.Iconimage_right = null;
            this.settingsButton.Iconimage_right_Selected = null;
            this.settingsButton.Iconimage_Selected = null;
            this.settingsButton.IconMarginLeft = 0;
            this.settingsButton.IconMarginRight = 0;
            this.settingsButton.IconRightVisible = true;
            this.settingsButton.IconRightZoom = 0D;
            this.settingsButton.IconVisible = true;
            this.settingsButton.IconZoom = 50D;
            this.settingsButton.IsTab = true;
            this.settingsButton.Location = new System.Drawing.Point(0, 157);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(5);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Normalcolor = System.Drawing.Color.White;
            this.settingsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.settingsButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.settingsButton.selected = false;
            this.settingsButton.Size = new System.Drawing.Size(194, 49);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "  Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.settingsButton.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // dietplannerButton
            // 
            this.dietplannerButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dietplannerButton.BackColor = System.Drawing.Color.White;
            this.dietplannerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dietplannerButton.BorderRadius = 0;
            this.dietplannerButton.ButtonText = "  Diet Planner";
            this.dietplannerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dietplannerButton.DisabledColor = System.Drawing.Color.Gray;
            this.dietplannerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dietplannerButton.Iconcolor = System.Drawing.Color.Transparent;
            this.dietplannerButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("dietplannerButton.Iconimage")));
            this.dietplannerButton.Iconimage_right = null;
            this.dietplannerButton.Iconimage_right_Selected = null;
            this.dietplannerButton.Iconimage_Selected = null;
            this.dietplannerButton.IconMarginLeft = 0;
            this.dietplannerButton.IconMarginRight = 0;
            this.dietplannerButton.IconRightVisible = true;
            this.dietplannerButton.IconRightZoom = 0D;
            this.dietplannerButton.IconVisible = true;
            this.dietplannerButton.IconZoom = 40D;
            this.dietplannerButton.IsTab = true;
            this.dietplannerButton.Location = new System.Drawing.Point(0, 109);
            this.dietplannerButton.Margin = new System.Windows.Forms.Padding(5);
            this.dietplannerButton.Name = "dietplannerButton";
            this.dietplannerButton.Normalcolor = System.Drawing.Color.White;
            this.dietplannerButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dietplannerButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dietplannerButton.selected = false;
            this.dietplannerButton.Size = new System.Drawing.Size(194, 49);
            this.dietplannerButton.TabIndex = 2;
            this.dietplannerButton.Text = "  Diet Planner";
            this.dietplannerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dietplannerButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dietplannerButton.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dietplannerButton.Click += new System.EventHandler(this.dietplannerButton_Click);
            // 
            // btnActiveSide
            // 
            this.btnActiveSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnActiveSide.Location = new System.Drawing.Point(0, 62);
            this.btnActiveSide.Name = "btnActiveSide";
            this.btnActiveSide.Size = new System.Drawing.Size(3, 49);
            this.btnActiveSide.TabIndex = 1;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardBtn.BorderRadius = 0;
            this.dashboardBtn.ButtonText = "  Dashboard";
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.DisabledColor = System.Drawing.Color.Gray;
            this.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dashboardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboardBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Iconimage")));
            this.dashboardBtn.Iconimage_right = null;
            this.dashboardBtn.Iconimage_right_Selected = null;
            this.dashboardBtn.Iconimage_Selected = null;
            this.dashboardBtn.IconMarginLeft = 0;
            this.dashboardBtn.IconMarginRight = 0;
            this.dashboardBtn.IconRightVisible = true;
            this.dashboardBtn.IconRightZoom = 0D;
            this.dashboardBtn.IconVisible = true;
            this.dashboardBtn.IconZoom = 40D;
            this.dashboardBtn.IsTab = true;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 61);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(5);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Normalcolor = System.Drawing.Color.White;
            this.dashboardBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dashboardBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dashboardBtn.selected = true;
            this.dashboardBtn.Size = new System.Drawing.Size(194, 49);
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.Text = "  Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dashboardBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(198, 4);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(633, 409);
            this.container.TabIndex = 3;
            // 
            // userprofileRound
            // 
            this.userprofileRound.ElipseRadius = 5;
            this.userprofileRound.TargetControl = this.userProfile;
            // 
            // userUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.container);
            this.Name = "userUC";
            this.Size = new System.Drawing.Size(835, 415);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton logoutBtn;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox userProfile;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton settingsButton;
        private Bunifu.Framework.UI.BunifuFlatButton dietplannerButton;
        private System.Windows.Forms.Panel btnActiveSide;
        private Bunifu.Framework.UI.BunifuFlatButton dashboardBtn;
        private System.Windows.Forms.Panel container;
        private Bunifu.Framework.UI.BunifuElipse userprofileRound;
    }
}
