namespace OOAD_Final_Project
{
    partial class user_advance_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_advance_search));
            this.mainContent = new Bunifu.Framework.UI.BunifuCards();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchBy = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.mainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContent
            // 
            this.mainContent.BackColor = System.Drawing.Color.White;
            this.mainContent.BorderRadius = 5;
            this.mainContent.BottomSahddow = true;
            this.mainContent.color = System.Drawing.Color.Tomato;
            this.mainContent.Controls.Add(this.closeBtn);
            this.mainContent.Controls.Add(this.cancelBtn);
            this.mainContent.Controls.Add(this.searchBy);
            this.mainContent.LeftSahddow = false;
            this.mainContent.Location = new System.Drawing.Point(0, 0);
            this.mainContent.Name = "mainContent";
            this.mainContent.RightSahddow = true;
            this.mainContent.ShadowDepth = 20;
            this.mainContent.Size = new System.Drawing.Size(574, 262);
            this.mainContent.TabIndex = 0;
            this.mainContent.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContent_Paint);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(551, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 20;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.BorderRadius = 5;
            this.cancelBtn.ButtonText = "Search";
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DisabledColor = System.Drawing.Color.Gray;
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.cancelBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.cancelBtn.Iconimage = null;
            this.cancelBtn.Iconimage_right = null;
            this.cancelBtn.Iconimage_right_Selected = null;
            this.cancelBtn.Iconimage_Selected = null;
            this.cancelBtn.IconMarginLeft = 0;
            this.cancelBtn.IconMarginRight = 0;
            this.cancelBtn.IconRightVisible = true;
            this.cancelBtn.IconRightZoom = 0D;
            this.cancelBtn.IconVisible = true;
            this.cancelBtn.IconZoom = 40D;
            this.cancelBtn.IsTab = true;
            this.cancelBtn.Location = new System.Drawing.Point(43, 129);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.cancelBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.cancelBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.cancelBtn.selected = false;
            this.cancelBtn.Size = new System.Drawing.Size(122, 30);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Search";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn.Textcolor = System.Drawing.Color.White;
            this.cancelBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // searchBy
            // 
            this.searchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.searchBy.BorderRadius = 3;
            this.searchBy.DisabledColor = System.Drawing.Color.Gray;
            this.searchBy.ForeColor = System.Drawing.Color.White;
            this.searchBy.Items = new string[0];
            this.searchBy.Location = new System.Drawing.Point(43, 87);
            this.searchBy.Name = "searchBy";
            this.searchBy.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.searchBy.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.searchBy.selectedIndex = -1;
            this.searchBy.Size = new System.Drawing.Size(217, 35);
            this.searchBy.TabIndex = 1;
            this.searchBy.onItemSelected += new System.EventHandler(this.searchBy_onItemSelected);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.mainContent;
            this.bunifuDragControl1.Vertical = true;
            // 
            // user_advance_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 261);
            this.Controls.Add(this.mainContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user_advance_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced_search";
            this.mainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards mainContent;
        private Bunifu.Framework.UI.BunifuDropdown searchBy;
        private Bunifu.Framework.UI.BunifuFlatButton cancelBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox closeBtn;
    }
}