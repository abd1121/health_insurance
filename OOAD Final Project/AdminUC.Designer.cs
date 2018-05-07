namespace OOAD_Final_Project
{
    partial class AdminUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.username = new System.Windows.Forms.Label();
            this.userProfile = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.offersButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.categoriesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.recipeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.usersButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnActiveSide = new System.Windows.Forms.Panel();
            this.dashboardBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.container = new System.Windows.Forms.Panel();
            this.admin_Dashboard1 = new OOAD_Final_Project.Admin_Dashboard();
            this.userprofileRound = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).BeginInit();
            this.container.SuspendLayout();
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
            this.panel1.Controls.Add(this.offersButton);
            this.panel1.Controls.Add(this.categoriesButton);
            this.panel1.Controls.Add(this.recipeButton);
            this.panel1.Controls.Add(this.usersButton);
            this.panel1.Controls.Add(this.btnActiveSide);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 435);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.username.Click += new System.EventHandler(this.username_Click);
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
            this.userProfile.Click += new System.EventHandler(this.userProfile_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 62);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // offersButton
            // 
            this.offersButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.offersButton.BackColor = System.Drawing.Color.White;
            this.offersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.offersButton.BorderRadius = 0;
            this.offersButton.ButtonText = "  Offers  ";
            this.offersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offersButton.DisabledColor = System.Drawing.Color.Gray;
            this.offersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.offersButton.Iconcolor = System.Drawing.Color.Transparent;
            this.offersButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("offersButton.Iconimage")));
            this.offersButton.Iconimage_right = null;
            this.offersButton.Iconimage_right_Selected = null;
            this.offersButton.Iconimage_Selected = null;
            this.offersButton.IconMarginLeft = 0;
            this.offersButton.IconMarginRight = 0;
            this.offersButton.IconRightVisible = true;
            this.offersButton.IconRightZoom = 0D;
            this.offersButton.IconVisible = true;
            this.offersButton.IconZoom = 50D;
            this.offersButton.IsTab = true;
            this.offersButton.Location = new System.Drawing.Point(0, 253);
            this.offersButton.Margin = new System.Windows.Forms.Padding(5);
            this.offersButton.Name = "offersButton";
            this.offersButton.Normalcolor = System.Drawing.Color.White;
            this.offersButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.offersButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.offersButton.selected = false;
            this.offersButton.Size = new System.Drawing.Size(194, 49);
            this.offersButton.TabIndex = 3;
            this.offersButton.Text = "  Offers  ";
            this.offersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.offersButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.offersButton.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.offersButton.Click += new System.EventHandler(this.offersButton_Click);
            // 
            // categoriesButton
            // 
            this.categoriesButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.categoriesButton.BackColor = System.Drawing.Color.White;
            this.categoriesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoriesButton.BorderRadius = 0;
            this.categoriesButton.ButtonText = "  Categories";
            this.categoriesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesButton.DisabledColor = System.Drawing.Color.Gray;
            this.categoriesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.categoriesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.categoriesButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("categoriesButton.Iconimage")));
            this.categoriesButton.Iconimage_right = null;
            this.categoriesButton.Iconimage_right_Selected = null;
            this.categoriesButton.Iconimage_Selected = null;
            this.categoriesButton.IconMarginLeft = 0;
            this.categoriesButton.IconMarginRight = 0;
            this.categoriesButton.IconRightVisible = true;
            this.categoriesButton.IconRightZoom = 0D;
            this.categoriesButton.IconVisible = true;
            this.categoriesButton.IconZoom = 50D;
            this.categoriesButton.IsTab = true;
            this.categoriesButton.Location = new System.Drawing.Point(0, 205);
            this.categoriesButton.Margin = new System.Windows.Forms.Padding(5);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Normalcolor = System.Drawing.Color.White;
            this.categoriesButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.categoriesButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.categoriesButton.selected = false;
            this.categoriesButton.Size = new System.Drawing.Size(194, 49);
            this.categoriesButton.TabIndex = 2;
            this.categoriesButton.Text = "  Categories";
            this.categoriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriesButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.categoriesButton.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // recipeButton
            // 
            this.recipeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.recipeButton.BackColor = System.Drawing.Color.White;
            this.recipeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recipeButton.BorderRadius = 0;
            this.recipeButton.ButtonText = "  Recipe";
            this.recipeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recipeButton.DisabledColor = System.Drawing.Color.Gray;
            this.recipeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.recipeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.recipeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("recipeButton.Iconimage")));
            this.recipeButton.Iconimage_right = null;
            this.recipeButton.Iconimage_right_Selected = null;
            this.recipeButton.Iconimage_Selected = null;
            this.recipeButton.IconMarginLeft = 0;
            this.recipeButton.IconMarginRight = 0;
            this.recipeButton.IconRightVisible = true;
            this.recipeButton.IconRightZoom = 0D;
            this.recipeButton.IconVisible = true;
            this.recipeButton.IconZoom = 50D;
            this.recipeButton.IsTab = true;
            this.recipeButton.Location = new System.Drawing.Point(0, 157);
            this.recipeButton.Margin = new System.Windows.Forms.Padding(5);
            this.recipeButton.Name = "recipeButton";
            this.recipeButton.Normalcolor = System.Drawing.Color.White;
            this.recipeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.recipeButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.recipeButton.selected = false;
            this.recipeButton.Size = new System.Drawing.Size(194, 49);
            this.recipeButton.TabIndex = 3;
            this.recipeButton.Text = "  Recipe";
            this.recipeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recipeButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.recipeButton.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.recipeButton.Click += new System.EventHandler(this.recipeButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.usersButton.BackColor = System.Drawing.Color.White;
            this.usersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usersButton.BorderRadius = 0;
            this.usersButton.ButtonText = "  Users";
            this.usersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersButton.DisabledColor = System.Drawing.Color.Gray;
            this.usersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.usersButton.Iconcolor = System.Drawing.Color.Transparent;
            this.usersButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("usersButton.Iconimage")));
            this.usersButton.Iconimage_right = null;
            this.usersButton.Iconimage_right_Selected = null;
            this.usersButton.Iconimage_Selected = null;
            this.usersButton.IconMarginLeft = 0;
            this.usersButton.IconMarginRight = 0;
            this.usersButton.IconRightVisible = true;
            this.usersButton.IconRightZoom = 0D;
            this.usersButton.IconVisible = true;
            this.usersButton.IconZoom = 40D;
            this.usersButton.IsTab = true;
            this.usersButton.Location = new System.Drawing.Point(0, 109);
            this.usersButton.Margin = new System.Windows.Forms.Padding(5);
            this.usersButton.Name = "usersButton";
            this.usersButton.Normalcolor = System.Drawing.Color.White;
            this.usersButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.usersButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.usersButton.selected = false;
            this.usersButton.Size = new System.Drawing.Size(194, 49);
            this.usersButton.TabIndex = 2;
            this.usersButton.Text = "  Users";
            this.usersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.usersButton.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // btnActiveSide
            // 
            this.btnActiveSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnActiveSide.Location = new System.Drawing.Point(0, 62);
            this.btnActiveSide.Name = "btnActiveSide";
            this.btnActiveSide.Size = new System.Drawing.Size(3, 49);
            this.btnActiveSide.TabIndex = 1;
            this.btnActiveSide.Paint += new System.Windows.Forms.PaintEventHandler(this.btnActiveSide_Paint);
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
            this.container.Controls.Add(this.admin_Dashboard1);
            this.container.Location = new System.Drawing.Point(198, 3);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(633, 409);
            this.container.TabIndex = 1;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // admin_Dashboard1
            // 
            this.admin_Dashboard1.BackColor = System.Drawing.Color.White;
            this.admin_Dashboard1.Location = new System.Drawing.Point(2, 1);
            this.admin_Dashboard1.Name = "admin_Dashboard1";
            this.admin_Dashboard1.Size = new System.Drawing.Size(633, 406);
            this.admin_Dashboard1.TabIndex = 0;
            this.admin_Dashboard1.Load += new System.EventHandler(this.admin_Dashboard1_Load);
            // 
            // userprofileRound
            // 
            this.userprofileRound.ElipseRadius = 5;
            this.userprofileRound.TargetControl = this.userProfile;
            // 
            // AdminUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel1);
            this.Name = "AdminUC";
            this.Size = new System.Drawing.Size(835, 415);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).EndInit();
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton dashboardBtn;
        private System.Windows.Forms.Panel btnActiveSide;
        private Bunifu.Framework.UI.BunifuFlatButton usersButton;
        private System.Windows.Forms.Panel container;
        private Admin_Dashboard admin_Dashboard1;
        private Bunifu.Framework.UI.BunifuFlatButton offersButton;
        private Bunifu.Framework.UI.BunifuFlatButton categoriesButton;
        private Bunifu.Framework.UI.BunifuFlatButton recipeButton;
        private System.Windows.Forms.PictureBox userProfile;
        private Bunifu.Framework.UI.BunifuElipse userprofileRound;
        private System.Windows.Forms.Label username;
        private Bunifu.Framework.UI.BunifuFlatButton logoutBtn;
        private System.Windows.Forms.Panel panel2;
    }
}
