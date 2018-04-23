namespace OOAD_Final_Project
{
    partial class user_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_dashboard));
            this.searchBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.advancedSearchIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.advancedSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.BorderRadius = 7;
            this.searchBtn.ButtonText = "   What i should Eat Today?";
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.DisabledColor = System.Drawing.Color.Gray;
            this.searchBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.searchBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("searchBtn.Iconimage")));
            this.searchBtn.Iconimage_right = null;
            this.searchBtn.Iconimage_right_Selected = null;
            this.searchBtn.Iconimage_Selected = null;
            this.searchBtn.IconMarginLeft = 0;
            this.searchBtn.IconMarginRight = 0;
            this.searchBtn.IconRightVisible = true;
            this.searchBtn.IconRightZoom = 0D;
            this.searchBtn.IconVisible = true;
            this.searchBtn.IconZoom = 40D;
            this.searchBtn.IsTab = false;
            this.searchBtn.Location = new System.Drawing.Point(82, 180);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.searchBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.searchBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.searchBtn.selected = false;
            this.searchBtn.Size = new System.Drawing.Size(469, 48);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "   What i should Eat Today?";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchBtn.Textcolor = System.Drawing.Color.White;
            this.searchBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.searchLbl.Location = new System.Drawing.Point(257, 236);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(123, 17);
            this.searchLbl.TabIndex = 13;
            this.searchLbl.Text = "Advanced Search";
            this.searchLbl.Click += new System.EventHandler(this.advanceSearch_click);
            // 
            // advancedSearchIcon
            // 
            this.advancedSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.advancedSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("advancedSearchIcon.Image")));
            this.advancedSearchIcon.Location = new System.Drawing.Point(238, 235);
            this.advancedSearchIcon.Name = "advancedSearchIcon";
            this.advancedSearchIcon.Size = new System.Drawing.Size(20, 20);
            this.advancedSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.advancedSearchIcon.TabIndex = 14;
            this.advancedSearchIcon.TabStop = false;
            this.advancedSearchIcon.Click += new System.EventHandler(this.advanceSearch_click);
            // 
            // user_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.advancedSearchIcon);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchBtn);
            this.Name = "user_dashboard";
            this.Size = new System.Drawing.Size(633, 409);
            ((System.ComponentModel.ISupportInitialize)(this.advancedSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton searchBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel searchLbl;
        private System.Windows.Forms.PictureBox advancedSearchIcon;
    }
}
