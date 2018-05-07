namespace OOAD_Final_Project
{
    partial class user_details_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_details_view));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.recipeTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.userImage = new System.Windows.Forms.PictureBox();
            this.exitMenuButton = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.userName = new System.Windows.Forms.Label();
            this.recipeAuthorLabel = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.userPhone = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.Label();
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-10, 45);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(589, 26);
            this.bunifuSeparator1.TabIndex = 34;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // recipeTitle
            // 
            this.recipeTitle.AutoSize = true;
            this.recipeTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recipeTitle.Location = new System.Drawing.Point(6, 12);
            this.recipeTitle.Name = "recipeTitle";
            this.recipeTitle.Size = new System.Drawing.Size(163, 33);
            this.recipeTitle.TabIndex = 33;
            this.recipeTitle.Text = "User Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(-9, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 10);
            this.panel1.TabIndex = 32;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // userImage
            // 
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.Location = new System.Drawing.Point(16, 77);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(121, 107);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage.TabIndex = 37;
            this.userImage.TabStop = false;
            // 
            // exitMenuButton
            // 
            this.exitMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("exitMenuButton.Image")));
            this.exitMenuButton.Location = new System.Drawing.Point(544, 19);
            this.exitMenuButton.Name = "exitMenuButton";
            this.exitMenuButton.Size = new System.Drawing.Size(12, 13);
            this.exitMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitMenuButton.TabIndex = 36;
            this.exitMenuButton.TabStop = false;
            this.exitMenuButton.Click += new System.EventHandler(this.exitMenuButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.userImage;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(256, 75);
            this.userName.MaximumSize = new System.Drawing.Size(500, 100);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(168, 21);
            this.userName.TabIndex = 42;
            this.userName.Text = "Muhammad Numair";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recipeAuthorLabel
            // 
            this.recipeAuthorLabel.AutoSize = true;
            this.recipeAuthorLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeAuthorLabel.Location = new System.Drawing.Point(143, 77);
            this.recipeAuthorLabel.MaximumSize = new System.Drawing.Size(500, 100);
            this.recipeAuthorLabel.Name = "recipeAuthorLabel";
            this.recipeAuthorLabel.Size = new System.Drawing.Size(66, 19);
            this.recipeAuthorLabel.TabIndex = 43;
            this.recipeAuthorLabel.Text = "Name: ";
            this.recipeAuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 112);
            this.label1.MaximumSize = new System.Drawing.Size(500, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Email: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 144);
            this.label2.MaximumSize = new System.Drawing.Size(500, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Username: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 178);
            this.label3.MaximumSize = new System.Drawing.Size(500, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Phone #: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 214);
            this.label4.MaximumSize = new System.Drawing.Size(500, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Password: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userEmail
            // 
            this.userEmail.AutoSize = true;
            this.userEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmail.Location = new System.Drawing.Point(256, 110);
            this.userEmail.MaximumSize = new System.Drawing.Size(500, 100);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(180, 21);
            this.userEmail.TabIndex = 42;
            this.userEmail.Text = "numair.cs@gmail.com";
            this.userEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(256, 142);
            this.user_name.MaximumSize = new System.Drawing.Size(500, 100);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(64, 21);
            this.user_name.TabIndex = 42;
            this.user_name.Text = "numair";
            this.user_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userPhone
            // 
            this.userPhone.AutoSize = true;
            this.userPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPhone.Location = new System.Drawing.Point(256, 176);
            this.userPhone.MaximumSize = new System.Drawing.Size(500, 100);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(114, 21);
            this.userPhone.TabIndex = 42;
            this.userPhone.Text = "0332-2652270";
            this.userPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userPass
            // 
            this.userPass.AutoSize = true;
            this.userPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPass.Location = new System.Drawing.Point(256, 212);
            this.userPass.MaximumSize = new System.Drawing.Size(500, 100);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(37, 21);
            this.userPass.TabIndex = 42;
            this.userPass.Text = "123";
            this.userPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this;
            this.bunifuDragControl3.Vertical = true;
            // 
            // user_details_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 274);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.recipeTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.exitMenuButton);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.userPhone);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recipeAuthorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user_details_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user_details_view";
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label recipeTitle;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.PictureBox exitMenuButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label userPass;
        private System.Windows.Forms.Label userPhone;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label userEmail;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label recipeAuthorLabel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    }
}