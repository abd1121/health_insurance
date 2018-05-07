namespace OOAD_Final_Project
{
    partial class load_recipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(load_recipe));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.recipeTitle = new System.Windows.Forms.Label();
            this.recipeVideo = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recipeDescription = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.exitMenuButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.recipeVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-10, 38);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(589, 26);
            this.bunifuSeparator1.TabIndex = 19;
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
            this.recipeTitle.Size = new System.Drawing.Size(201, 33);
            this.recipeTitle.TabIndex = 18;
            this.recipeTitle.Text = "Add New User";
            // 
            // recipeVideo
            // 
            this.recipeVideo.Enabled = true;
            this.recipeVideo.Location = new System.Drawing.Point(19, 67);
            this.recipeVideo.Name = "recipeVideo";
            this.recipeVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("recipeVideo.OcxState")));
            this.recipeVideo.Size = new System.Drawing.Size(534, 269);
            this.recipeVideo.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(-9, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 10);
            this.panel1.TabIndex = 16;
            // 
            // recipeDescription
            // 
            this.recipeDescription.AutoSize = true;
            this.recipeDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeDescription.Location = new System.Drawing.Point(33, 339);
            this.recipeDescription.MaximumSize = new System.Drawing.Size(500, 200);
            this.recipeDescription.Name = "recipeDescription";
            this.recipeDescription.Size = new System.Drawing.Size(132, 21);
            this.recipeDescription.TabIndex = 21;
            this.recipeDescription.Text = "Desc Goes Here";
            this.recipeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // exitMenuButton
            // 
            this.exitMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("exitMenuButton.Image")));
            this.exitMenuButton.Location = new System.Drawing.Point(540, 20);
            this.exitMenuButton.Name = "exitMenuButton";
            this.exitMenuButton.Size = new System.Drawing.Size(12, 13);
            this.exitMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitMenuButton.TabIndex = 22;
            this.exitMenuButton.TabStop = false;
            this.exitMenuButton.Click += new System.EventHandler(this.exitMenuButton_Click);
            // 
            // load_recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 442);
            this.Controls.Add(this.exitMenuButton);
            this.Controls.Add(this.recipeDescription);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.recipeTitle);
            this.Controls.Add(this.recipeVideo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "load_recipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "load_recipe";
            ((System.ComponentModel.ISupportInitialize)(this.recipeVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitMenuButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label recipeTitle;
        private AxShockwaveFlashObjects.AxShockwaveFlash recipeVideo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label recipeDescription;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox exitMenuButton;
    }
}