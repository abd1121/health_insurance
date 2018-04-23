namespace OOAD_Final_Project
{
    partial class guest_user_diet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guest_user_diet));
            this.relatedSuggetionsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.top_container = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadOffersButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // relatedSuggetionsContainer
            // 
            this.relatedSuggetionsContainer.Location = new System.Drawing.Point(26, 261);
            this.relatedSuggetionsContainer.Name = "relatedSuggetionsContainer";
            this.relatedSuggetionsContainer.Size = new System.Drawing.Size(783, 144);
            this.relatedSuggetionsContainer.TabIndex = 0;
            // 
            // top_container
            // 
            this.top_container.Location = new System.Drawing.Point(26, 102);
            this.top_container.Name = "top_container";
            this.top_container.Size = new System.Drawing.Size(783, 123);
            this.top_container.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Related Suggetions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(686, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hi, Muhammad Numair You Should Have This Today";
            // 
            // loadOffersButton
            // 
            this.loadOffersButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.loadOffersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.loadOffersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadOffersButton.BorderRadius = 0;
            this.loadOffersButton.ButtonText = "Back";
            this.loadOffersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadOffersButton.DisabledColor = System.Drawing.Color.Gray;
            this.loadOffersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(184)))));
            this.loadOffersButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loadOffersButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loadOffersButton.Iconimage")));
            this.loadOffersButton.Iconimage_right = null;
            this.loadOffersButton.Iconimage_right_Selected = null;
            this.loadOffersButton.Iconimage_Selected = null;
            this.loadOffersButton.IconMarginLeft = 0;
            this.loadOffersButton.IconMarginRight = 0;
            this.loadOffersButton.IconRightVisible = true;
            this.loadOffersButton.IconRightZoom = 0D;
            this.loadOffersButton.IconVisible = true;
            this.loadOffersButton.IconZoom = 40D;
            this.loadOffersButton.IsTab = true;
            this.loadOffersButton.Location = new System.Drawing.Point(26, 12);
            this.loadOffersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadOffersButton.Name = "loadOffersButton";
            this.loadOffersButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.loadOffersButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.loadOffersButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.loadOffersButton.selected = false;
            this.loadOffersButton.Size = new System.Drawing.Size(95, 30);
            this.loadOffersButton.TabIndex = 5;
            this.loadOffersButton.Text = "Back";
            this.loadOffersButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadOffersButton.Textcolor = System.Drawing.Color.White;
            this.loadOffersButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadOffersButton.Click += new System.EventHandler(this.loadOffersButton_Click);
            // 
            // guest_user_diet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.loadOffersButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.top_container);
            this.Controls.Add(this.relatedSuggetionsContainer);
            this.Name = "guest_user_diet";
            this.Size = new System.Drawing.Size(835, 415);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel relatedSuggetionsContainer;
        private System.Windows.Forms.Panel top_container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton loadOffersButton;
    }
}
