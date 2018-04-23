namespace OOAD_Final_Project
{
    partial class addnewcategory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.addcategoryBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.categorynametxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cancelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 10);
            this.panel1.TabIndex = 39;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-10, 47);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(589, 14);
            this.bunifuSeparator1.TabIndex = 38;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 33);
            this.label1.TabIndex = 37;
            this.label1.Text = "Add New Category";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // addcategoryBtn
            // 
            this.addcategoryBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.addcategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.addcategoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addcategoryBtn.BorderRadius = 5;
            this.addcategoryBtn.ButtonText = "Add Category";
            this.addcategoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addcategoryBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addcategoryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.addcategoryBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addcategoryBtn.Iconimage = null;
            this.addcategoryBtn.Iconimage_right = null;
            this.addcategoryBtn.Iconimage_right_Selected = null;
            this.addcategoryBtn.Iconimage_Selected = null;
            this.addcategoryBtn.IconMarginLeft = 0;
            this.addcategoryBtn.IconMarginRight = 0;
            this.addcategoryBtn.IconRightVisible = true;
            this.addcategoryBtn.IconRightZoom = 0D;
            this.addcategoryBtn.IconVisible = true;
            this.addcategoryBtn.IconZoom = 40D;
            this.addcategoryBtn.IsTab = true;
            this.addcategoryBtn.Location = new System.Drawing.Point(139, 132);
            this.addcategoryBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addcategoryBtn.Name = "addcategoryBtn";
            this.addcategoryBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.addcategoryBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.addcategoryBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.addcategoryBtn.selected = false;
            this.addcategoryBtn.Size = new System.Drawing.Size(158, 30);
            this.addcategoryBtn.TabIndex = 41;
            this.addcategoryBtn.Text = "Add Category";
            this.addcategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addcategoryBtn.Textcolor = System.Drawing.Color.White;
            this.addcategoryBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcategoryBtn.Click += new System.EventHandler(this.addcategoryBtn_Click);
            // 
            // categorynametxtbox
            // 
            this.categorynametxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categorynametxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.categorynametxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categorynametxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.categorynametxtbox.HintText = "Category Name";
            this.categorynametxtbox.isPassword = false;
            this.categorynametxtbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.categorynametxtbox.LineIdleColor = System.Drawing.Color.Gray;
            this.categorynametxtbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.categorynametxtbox.LineThickness = 3;
            this.categorynametxtbox.Location = new System.Drawing.Point(11, 79);
            this.categorynametxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.categorynametxtbox.Name = "categorynametxtbox";
            this.categorynametxtbox.Size = new System.Drawing.Size(379, 33);
            this.categorynametxtbox.TabIndex = 40;
            this.categorynametxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.BorderRadius = 5;
            this.cancelBtn.ButtonText = "Cancel";
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
            this.cancelBtn.Location = new System.Drawing.Point(11, 132);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.cancelBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.cancelBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.cancelBtn.selected = false;
            this.cancelBtn.Size = new System.Drawing.Size(122, 30);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn.Textcolor = System.Drawing.Color.White;
            this.cancelBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addnewcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(568, 442);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addcategoryBtn);
            this.Controls.Add(this.categorynametxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addnewcategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addnewcategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton addcategoryBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox categorynametxtbox;
        private Bunifu.Framework.UI.BunifuFlatButton cancelBtn;
    }
}