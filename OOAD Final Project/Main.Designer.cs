namespace OOAD_Final_Project
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.signupMenuButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loginMenuButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homeControl = new OOAD_Final_Project.HomeControl();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.EclipseNameBox = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exitMenuButton = new System.Windows.Forms.PictureBox();
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.FrontPageTitle = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.logo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sinupmenugolae = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.loginGulae = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // contentPanel
            // 
            this.contentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contentPanel.BackgroundImage")));
            this.contentPanel.Controls.Add(this.signupMenuButton);
            this.contentPanel.Controls.Add(this.loginMenuButton);
            this.contentPanel.Controls.Add(this.bunifuFlatButton1);
            this.contentPanel.Controls.Add(this.loginButton);
            this.contentPanel.Controls.Add(this.homeControl);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contentPanel.Location = new System.Drawing.Point(0, 41);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(835, 415);
            this.contentPanel.TabIndex = 0;
            // 
            // signupMenuButton
            // 
            this.signupMenuButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.signupMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.signupMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signupMenuButton.BorderRadius = 0;
            this.signupMenuButton.ButtonText = " Sign Up";
            this.signupMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupMenuButton.DisabledColor = System.Drawing.Color.Gray;
            this.signupMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.signupMenuButton.Iconcolor = System.Drawing.Color.Transparent;
            this.signupMenuButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("signupMenuButton.Iconimage")));
            this.signupMenuButton.Iconimage_right = null;
            this.signupMenuButton.Iconimage_right_Selected = null;
            this.signupMenuButton.Iconimage_Selected = null;
            this.signupMenuButton.IconMarginLeft = 0;
            this.signupMenuButton.IconMarginRight = 0;
            this.signupMenuButton.IconRightVisible = true;
            this.signupMenuButton.IconRightZoom = 0D;
            this.signupMenuButton.IconVisible = true;
            this.signupMenuButton.IconZoom = 40D;
            this.signupMenuButton.IsTab = true;
            this.signupMenuButton.Location = new System.Drawing.Point(564, 13);
            this.signupMenuButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signupMenuButton.Name = "signupMenuButton";
            this.signupMenuButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.signupMenuButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.signupMenuButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.signupMenuButton.selected = false;
            this.signupMenuButton.Size = new System.Drawing.Size(102, 30);
            this.signupMenuButton.TabIndex = 3;
            this.signupMenuButton.Text = " Sign Up";
            this.signupMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signupMenuButton.Textcolor = System.Drawing.Color.White;
            this.signupMenuButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupMenuButton.Click += new System.EventHandler(this.registerButtonClick);
            // 
            // loginMenuButton
            // 
            this.loginMenuButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.loginMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.loginMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginMenuButton.BorderRadius = 0;
            this.loginMenuButton.ButtonText = " Login";
            this.loginMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginMenuButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.loginMenuButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginMenuButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginMenuButton.Iconimage")));
            this.loginMenuButton.Iconimage_right = null;
            this.loginMenuButton.Iconimage_right_Selected = null;
            this.loginMenuButton.Iconimage_Selected = null;
            this.loginMenuButton.IconMarginLeft = 0;
            this.loginMenuButton.IconMarginRight = 0;
            this.loginMenuButton.IconRightVisible = true;
            this.loginMenuButton.IconRightZoom = 0D;
            this.loginMenuButton.IconVisible = true;
            this.loginMenuButton.IconZoom = 40D;
            this.loginMenuButton.IsTab = true;
            this.loginMenuButton.Location = new System.Drawing.Point(672, 13);
            this.loginMenuButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginMenuButton.Name = "loginMenuButton";
            this.loginMenuButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.loginMenuButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.loginMenuButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.loginMenuButton.selected = false;
            this.loginMenuButton.Size = new System.Drawing.Size(110, 30);
            this.loginMenuButton.TabIndex = 3;
            this.loginMenuButton.Text = " Login";
            this.loginMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginMenuButton.Textcolor = System.Drawing.Color.White;
            this.loginMenuButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginMenuButton.Click += new System.EventHandler(this.loginButtonClick);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "Login";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 89F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(6141, 1340);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(34, 31, 34, 31);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(1138, 350);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Login";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // loginButton
            // 
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.BorderRadius = 7;
            this.loginButton.ButtonText = "Login";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = null;
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = true;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = true;
            this.loginButton.IconZoom = 50D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(1068, 195);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(155, 57);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // homeControl
            // 
            this.homeControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeControl.BackgroundImage")));
            this.homeControl.Location = new System.Drawing.Point(-1, 0);
            this.homeControl.Name = "homeControl";
            this.homeControl.Size = new System.Drawing.Size(835, 415);
            this.homeControl.TabIndex = 4;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
            // 
            // EclipseNameBox
            // 
            this.EclipseNameBox.ElipseRadius = 5;
            this.EclipseNameBox.TargetControl = this;
            // 
            // exitMenuButton
            // 
            this.exitMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("exitMenuButton.Image")));
            this.exitMenuButton.Location = new System.Drawing.Point(806, 15);
            this.exitMenuButton.Name = "exitMenuButton";
            this.exitMenuButton.Size = new System.Drawing.Size(12, 13);
            this.exitMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitMenuButton.TabIndex = 7;
            this.exitMenuButton.TabStop = false;
            this.exitMenuButton.Click += new System.EventHandler(this.closeButtonClick);
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.Maroon;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.Black;
            this.bunifuColorTransition1.ProgessValue = 20;
            // 
            // FrontPageTitle
            // 
            this.FrontPageTitle.ElipseRadius = 20;
            this.FrontPageTitle.TargetControl = this;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.logo.Location = new System.Drawing.Point(34, 8);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(89, 25);
            this.logo.TabIndex = 11;
            this.logo.Text = "Foodies";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // sinupmenugolae
            // 
            this.sinupmenugolae.ElipseRadius = 10;
            this.sinupmenugolae.TargetControl = this.signupMenuButton;
            // 
            // loginGulae
            // 
            this.loginGulae.ElipseRadius = 15;
            this.loginGulae.TargetControl = this.loginMenuButton;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitMenuButton);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel contentPanel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse EclipseNameBox;
        private System.Windows.Forms.PictureBox exitMenuButton;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private Bunifu.Framework.UI.BunifuElipse FrontPageTitle;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton signupMenuButton;
        private Bunifu.Framework.UI.BunifuFlatButton loginMenuButton;
        private Bunifu.Framework.UI.BunifuElipse sinupmenugolae;
        private Bunifu.Framework.UI.BunifuElipse loginGulae;
        private HomeControl homeControl;
    }
}

