namespace OOAD_Final_Project
{
    partial class search_bottom_grid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search_bottom_grid));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.recipeTitle = new System.Windows.Forms.Label();
            this.recipeImage = new System.Windows.Forms.PictureBox();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.recipeTitle);
            this.bunifuCards1.Controls.Add(this.recipeImage);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(185, 146);
            this.bunifuCards1.TabIndex = 1;
            // 
            // recipeTitle
            // 
            this.recipeTitle.AutoSize = true;
            this.recipeTitle.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.recipeTitle.Location = new System.Drawing.Point(3, 119);
            this.recipeTitle.Name = "recipeTitle";
            this.recipeTitle.Size = new System.Drawing.Size(174, 19);
            this.recipeTitle.TabIndex = 2;
            this.recipeTitle.Text = "Receipie Title Goes Here";
            // 
            // recipeImage
            // 
            this.recipeImage.Image = ((System.Drawing.Image)(resources.GetObject("recipeImage.Image")));
            this.recipeImage.Location = new System.Drawing.Point(3, 8);
            this.recipeImage.Name = "recipeImage";
            this.recipeImage.Size = new System.Drawing.Size(179, 108);
            this.recipeImage.TabIndex = 1;
            this.recipeImage.TabStop = false;
            // 
            // search_bottom_grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "search_bottom_grid";
            this.Size = new System.Drawing.Size(185, 142);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label recipeTitle;
        private System.Windows.Forms.PictureBox recipeImage;
    }
}
