namespace OOAD_Final_Project
{
    partial class category_view
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
            this.categoryName = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.editButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // categoryName
            // 
            this.categoryName.AutoSize = true;
            this.categoryName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.categoryName.Location = new System.Drawing.Point(12, 6);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(221, 21);
            this.categoryName.TabIndex = 0;
            this.categoryName.Text = "Category Name Goes Here";
            this.categoryName.Click += new System.EventHandler(this.categoryName_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(2, 29);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(591, 10);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // editButton
            // 
            this.editButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.BorderRadius = 5;
            this.editButton.ButtonText = "Edit";
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.DisabledColor = System.Drawing.Color.Gray;
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.editButton.Iconcolor = System.Drawing.Color.Transparent;
            this.editButton.Iconimage = null;
            this.editButton.Iconimage_right = null;
            this.editButton.Iconimage_right_Selected = null;
            this.editButton.Iconimage_Selected = null;
            this.editButton.IconMarginLeft = 0;
            this.editButton.IconMarginRight = 0;
            this.editButton.IconRightVisible = true;
            this.editButton.IconRightZoom = 0D;
            this.editButton.IconVisible = true;
            this.editButton.IconZoom = 40D;
            this.editButton.IsTab = true;
            this.editButton.Location = new System.Drawing.Point(446, 4);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editButton.Name = "editButton";
            this.editButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.editButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.editButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.editButton.selected = false;
            this.editButton.Size = new System.Drawing.Size(63, 28);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editButton.Textcolor = System.Drawing.Color.White;
            this.editButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.BorderRadius = 5;
            this.deleteBtn.ButtonText = "Delete";
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.DisabledColor = System.Drawing.Color.Gray;
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.deleteBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteBtn.Iconimage = null;
            this.deleteBtn.Iconimage_right = null;
            this.deleteBtn.Iconimage_right_Selected = null;
            this.deleteBtn.Iconimage_Selected = null;
            this.deleteBtn.IconMarginLeft = 0;
            this.deleteBtn.IconMarginRight = 0;
            this.deleteBtn.IconRightVisible = true;
            this.deleteBtn.IconRightZoom = 0D;
            this.deleteBtn.IconVisible = true;
            this.deleteBtn.IconZoom = 40D;
            this.deleteBtn.IsTab = true;
            this.deleteBtn.Location = new System.Drawing.Point(515, 4);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.deleteBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.deleteBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.deleteBtn.selected = false;
            this.deleteBtn.Size = new System.Drawing.Size(77, 28);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBtn.Textcolor = System.Drawing.Color.White;
            this.deleteBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // category_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.categoryName);
            this.Name = "category_view";
            this.Size = new System.Drawing.Size(595, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton editButton;
        private Bunifu.Framework.UI.BunifuFlatButton deleteBtn;
    }
}
