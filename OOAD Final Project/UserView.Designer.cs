namespace OOAD_Final_Project
{
    partial class UserView
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
            this.userImage = new System.Windows.Forms.PictureBox();
            this.userDetailsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userImage
            // 
            this.userImage.Image = global::OOAD_Final_Project.Properties.Resources._30595282_1944152219247918_2402168826331398144_n;
            this.userImage.Location = new System.Drawing.Point(9, 7);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(77, 79);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage.TabIndex = 0;
            this.userImage.TabStop = false;
            // 
            // userDetailsBtn
            // 
            this.userDetailsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.userDetailsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.userDetailsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userDetailsBtn.BorderRadius = 0;
            this.userDetailsBtn.ButtonText = "Delete";
            this.userDetailsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userDetailsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.userDetailsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.userDetailsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.userDetailsBtn.Iconimage = null;
            this.userDetailsBtn.Iconimage_right = null;
            this.userDetailsBtn.Iconimage_right_Selected = null;
            this.userDetailsBtn.Iconimage_Selected = null;
            this.userDetailsBtn.IconMarginLeft = 0;
            this.userDetailsBtn.IconMarginRight = 0;
            this.userDetailsBtn.IconRightVisible = true;
            this.userDetailsBtn.IconRightZoom = 0D;
            this.userDetailsBtn.IconVisible = true;
            this.userDetailsBtn.IconZoom = 50D;
            this.userDetailsBtn.IsTab = true;
            this.userDetailsBtn.Location = new System.Drawing.Point(9, 120);
            this.userDetailsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userDetailsBtn.Name = "userDetailsBtn";
            this.userDetailsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.userDetailsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.userDetailsBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.userDetailsBtn.selected = false;
            this.userDetailsBtn.Size = new System.Drawing.Size(78, 27);
            this.userDetailsBtn.TabIndex = 5;
            this.userDetailsBtn.Text = "Delete";
            this.userDetailsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userDetailsBtn.Textcolor = System.Drawing.Color.White;
            this.userDetailsBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDetailsBtn.Click += new System.EventHandler(this.userDetailsBtn_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.userDetailsBtn);
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuCards1.Controls.Add(this.userImage);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(95, 164);
            this.bunifuCards1.TabIndex = 7;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Edit";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(9, 91);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(78, 27);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Edit";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "UserView";
            this.Size = new System.Drawing.Size(94, 149);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox userImage;
        private Bunifu.Framework.UI.BunifuFlatButton userDetailsBtn;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}
