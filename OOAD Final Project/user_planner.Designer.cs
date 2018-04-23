namespace OOAD_Final_Project
{
    partial class user_planner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_planner));
            this.dietPlanBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dietPlanContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dietPlanBtn
            // 
            this.dietPlanBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.dietPlanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dietPlanBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dietPlanBtn.BorderRadius = 5;
            this.dietPlanBtn.ButtonText = "Generate Diet Plan";
            this.dietPlanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dietPlanBtn.DisabledColor = System.Drawing.Color.Gray;
            this.dietPlanBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.dietPlanBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.dietPlanBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("dietPlanBtn.Iconimage")));
            this.dietPlanBtn.Iconimage_right = null;
            this.dietPlanBtn.Iconimage_right_Selected = null;
            this.dietPlanBtn.Iconimage_Selected = null;
            this.dietPlanBtn.IconMarginLeft = 0;
            this.dietPlanBtn.IconMarginRight = 0;
            this.dietPlanBtn.IconRightVisible = true;
            this.dietPlanBtn.IconRightZoom = 0D;
            this.dietPlanBtn.IconVisible = true;
            this.dietPlanBtn.IconZoom = 40D;
            this.dietPlanBtn.IsTab = true;
            this.dietPlanBtn.Location = new System.Drawing.Point(23, 17);
            this.dietPlanBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dietPlanBtn.Name = "dietPlanBtn";
            this.dietPlanBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dietPlanBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.dietPlanBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dietPlanBtn.selected = false;
            this.dietPlanBtn.Size = new System.Drawing.Size(176, 30);
            this.dietPlanBtn.TabIndex = 6;
            this.dietPlanBtn.Text = "Generate Diet Plan";
            this.dietPlanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dietPlanBtn.Textcolor = System.Drawing.Color.White;
            this.dietPlanBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dietPlanBtn.Click += new System.EventHandler(this.dietPlanBtn_Click);
            // 
            // dietPlanContainer
            // 
            this.dietPlanContainer.Location = new System.Drawing.Point(23, 79);
            this.dietPlanContainer.Name = "dietPlanContainer";
            this.dietPlanContainer.Size = new System.Drawing.Size(587, 301);
            this.dietPlanContainer.TabIndex = 7;
            // 
            // user_planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dietPlanContainer);
            this.Controls.Add(this.dietPlanBtn);
            this.Name = "user_planner";
            this.Size = new System.Drawing.Size(633, 406);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton dietPlanBtn;
        private System.Windows.Forms.Panel dietPlanContainer;
    }
}
