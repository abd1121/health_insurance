namespace OOAD_Final_Project
{
    partial class recipe_details_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recipe_details_view));
            this.recipeDescription = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.recipeTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.exitMenuButton = new System.Windows.Forms.PictureBox();
            this.recipeImage = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.recipeAuthorLabel = new System.Windows.Forms.Label();
            this.recipeURLLabel = new System.Windows.Forms.Label();
            this.recipeAuthor = new System.Windows.Forms.Label();
            this.recipeURL = new System.Windows.Forms.Label();
            this.dateAddedLabel = new System.Windows.Forms.Label();
            this.dateAdded = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeDescription
            // 
            this.recipeDescription.AutoSize = true;
            this.recipeDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeDescription.Location = new System.Drawing.Point(29, 249);
            this.recipeDescription.MaximumSize = new System.Drawing.Size(500, 100);
            this.recipeDescription.Name = "recipeDescription";
            this.recipeDescription.Size = new System.Drawing.Size(494, 100);
            this.recipeDescription.TabIndex = 27;
            this.recipeDescription.Text = resources.GetString("recipeDescription.Text");
            this.recipeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-10, 38);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(589, 26);
            this.bunifuSeparator1.TabIndex = 26;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // recipeTitle
            // 
            this.recipeTitle.AutoSize = true;
            this.recipeTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recipeTitle.Location = new System.Drawing.Point(5, 8);
            this.recipeTitle.Name = "recipeTitle";
            this.recipeTitle.Size = new System.Drawing.Size(312, 33);
            this.recipeTitle.TabIndex = 25;
            this.recipeTitle.Text = "Recipe Title Goes Here";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(-9, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 10);
            this.panel1.TabIndex = 23;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // exitMenuButton
            // 
            this.exitMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("exitMenuButton.Image")));
            this.exitMenuButton.Location = new System.Drawing.Point(544, 19);
            this.exitMenuButton.Name = "exitMenuButton";
            this.exitMenuButton.Size = new System.Drawing.Size(12, 13);
            this.exitMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitMenuButton.TabIndex = 28;
            this.exitMenuButton.TabStop = false;
            this.exitMenuButton.Click += new System.EventHandler(this.exitMenuButton_Click);
            // 
            // recipeImage
            // 
            this.recipeImage.Image = ((System.Drawing.Image)(resources.GetObject("recipeImage.Image")));
            this.recipeImage.Location = new System.Drawing.Point(133, 70);
            this.recipeImage.Name = "recipeImage";
            this.recipeImage.Size = new System.Drawing.Size(312, 167);
            this.recipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recipeImage.TabIndex = 29;
            this.recipeImage.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.recipeImage;
            // 
            // recipeAuthorLabel
            // 
            this.recipeAuthorLabel.AutoSize = true;
            this.recipeAuthorLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeAuthorLabel.Location = new System.Drawing.Point(12, 350);
            this.recipeAuthorLabel.MaximumSize = new System.Drawing.Size(500, 100);
            this.recipeAuthorLabel.Name = "recipeAuthorLabel";
            this.recipeAuthorLabel.Size = new System.Drawing.Size(68, 19);
            this.recipeAuthorLabel.TabIndex = 31;
            this.recipeAuthorLabel.Text = "Author: ";
            this.recipeAuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recipeURLLabel
            // 
            this.recipeURLLabel.AutoSize = true;
            this.recipeURLLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeURLLabel.Location = new System.Drawing.Point(12, 379);
            this.recipeURLLabel.MaximumSize = new System.Drawing.Size(500, 100);
            this.recipeURLLabel.Name = "recipeURLLabel";
            this.recipeURLLabel.Size = new System.Drawing.Size(101, 19);
            this.recipeURLLabel.TabIndex = 31;
            this.recipeURLLabel.Text = "Recipe URL: ";
            this.recipeURLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recipeAuthor
            // 
            this.recipeAuthor.AutoSize = true;
            this.recipeAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeAuthor.Location = new System.Drawing.Point(130, 350);
            this.recipeAuthor.MaximumSize = new System.Drawing.Size(500, 100);
            this.recipeAuthor.Name = "recipeAuthor";
            this.recipeAuthor.Size = new System.Drawing.Size(168, 21);
            this.recipeAuthor.TabIndex = 31;
            this.recipeAuthor.Text = "Muhammad Numair";
            this.recipeAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recipeURL
            // 
            this.recipeURL.AutoSize = true;
            this.recipeURL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeURL.Location = new System.Drawing.Point(130, 379);
            this.recipeURL.MaximumSize = new System.Drawing.Size(500, 100);
            this.recipeURL.Name = "recipeURL";
            this.recipeURL.Size = new System.Drawing.Size(399, 21);
            this.recipeURL.TabIndex = 31;
            this.recipeURL.Text = "https://www.youtube.com/watch?v=LfjjmPOYlsM";
            this.recipeURL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateAddedLabel
            // 
            this.dateAddedLabel.AutoSize = true;
            this.dateAddedLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAddedLabel.Location = new System.Drawing.Point(12, 412);
            this.dateAddedLabel.MaximumSize = new System.Drawing.Size(500, 100);
            this.dateAddedLabel.Name = "dateAddedLabel";
            this.dateAddedLabel.Size = new System.Drawing.Size(112, 19);
            this.dateAddedLabel.TabIndex = 31;
            this.dateAddedLabel.Text = "Date Added: ";
            this.dateAddedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateAdded
            // 
            this.dateAdded.AutoSize = true;
            this.dateAdded.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAdded.Location = new System.Drawing.Point(130, 412);
            this.dateAdded.MaximumSize = new System.Drawing.Size(500, 100);
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.Size = new System.Drawing.Size(96, 21);
            this.dateAdded.TabIndex = 31;
            this.dateAdded.Text = "27/04/2018";
            this.dateAdded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // recipe_details_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 442);
            this.Controls.Add(this.recipeURLLabel);
            this.Controls.Add(this.recipeURL);
            this.Controls.Add(this.dateAdded);
            this.Controls.Add(this.dateAddedLabel);
            this.Controls.Add(this.recipeAuthor);
            this.Controls.Add(this.recipeAuthorLabel);
            this.Controls.Add(this.recipeImage);
            this.Controls.Add(this.recipeDescription);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.recipeTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitMenuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "recipe_details_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "recipe_details_view";
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recipeDescription;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label recipeTitle;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox exitMenuButton;
        private System.Windows.Forms.PictureBox recipeImage;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label recipeAuthorLabel;
        private System.Windows.Forms.Label recipeURLLabel;
        private System.Windows.Forms.Label recipeAuthor;
        private System.Windows.Forms.Label recipeURL;
        private System.Windows.Forms.Label dateAdded;
        private System.Windows.Forms.Label dateAddedLabel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}