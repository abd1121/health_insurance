namespace OOAD_Final_Project
{
    partial class HomeControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.headingText = new System.Windows.Forms.Label();
            this.whatEatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.eclipseHeading = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.nameTextPanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.namePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headingText
            // 
            this.headingText.AutoSize = true;
            this.headingText.BackColor = System.Drawing.Color.Transparent;
            this.headingText.Font = new System.Drawing.Font("Century Gothic", 35.75F, System.Drawing.FontStyle.Bold);
            this.headingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headingText.Location = new System.Drawing.Point(269, 77);
            this.headingText.Name = "headingText";
            this.headingText.Size = new System.Drawing.Size(518, 56);
            this.headingText.TabIndex = 15;
            this.headingText.Text = "It\'s the food you love,";
            // 
            // whatEatButton
            // 
            this.whatEatButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.whatEatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.whatEatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whatEatButton.BorderRadius = 7;
            this.whatEatButton.ButtonText = "   What i should Eat Today?";
            this.whatEatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whatEatButton.DisabledColor = System.Drawing.Color.Gray;
            this.whatEatButton.Iconcolor = System.Drawing.Color.Transparent;
            this.whatEatButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("whatEatButton.Iconimage")));
            this.whatEatButton.Iconimage_right = null;
            this.whatEatButton.Iconimage_right_Selected = null;
            this.whatEatButton.Iconimage_Selected = null;
            this.whatEatButton.IconMarginLeft = 0;
            this.whatEatButton.IconMarginRight = 0;
            this.whatEatButton.IconRightVisible = true;
            this.whatEatButton.IconRightZoom = 0D;
            this.whatEatButton.IconVisible = true;
            this.whatEatButton.IconZoom = 40D;
            this.whatEatButton.IsTab = false;
            this.whatEatButton.Location = new System.Drawing.Point(279, 270);
            this.whatEatButton.Name = "whatEatButton";
            this.whatEatButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.whatEatButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.whatEatButton.OnHoverTextColor = System.Drawing.Color.White;
            this.whatEatButton.selected = false;
            this.whatEatButton.Size = new System.Drawing.Size(469, 48);
            this.whatEatButton.TabIndex = 11;
            this.whatEatButton.Text = "   What i should Eat Today?";
            this.whatEatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.whatEatButton.Textcolor = System.Drawing.Color.White;
            this.whatEatButton.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.whatEatButton.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.White;
            this.namePanel.Controls.Add(this.nameTxtBox);
            this.namePanel.Location = new System.Drawing.Point(279, 210);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(469, 54);
            this.namePanel.TabIndex = 14;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.nameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.nameTxtBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.nameTxtBox.HintText = "Enter Your Name";
            this.nameTxtBox.isPassword = false;
            this.nameTxtBox.LineFocusedColor = System.Drawing.Color.White;
            this.nameTxtBox.LineIdleColor = System.Drawing.Color.White;
            this.nameTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.nameTxtBox.LineThickness = 1;
            this.nameTxtBox.Location = new System.Drawing.Point(14, 10);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(450, 41);
            this.nameTxtBox.TabIndex = 1;
            this.nameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // eclipseHeading
            // 
            this.eclipseHeading.ElipseRadius = 15;
            this.eclipseHeading.TargetControl = this;
            // 
            // nameTextPanel
            // 
            this.nameTextPanel.ElipseRadius = 7;
            this.nameTextPanel.TargetControl = this.namePanel;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 40.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(268, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 66);
            this.label1.TabIndex = 16;
            this.label1.Text = "delivered!";
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headingText);
            this.Controls.Add(this.whatEatButton);
            this.Controls.Add(this.namePanel);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(835, 415);
            this.namePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingText;
        private Bunifu.Framework.UI.BunifuFlatButton whatEatButton;
        private System.Windows.Forms.Panel namePanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTxtBox;
        private Bunifu.Framework.UI.BunifuElipse eclipseHeading;
        private Bunifu.Framework.UI.BunifuElipse nameTextPanel;
        private System.Windows.Forms.Label label1;
    }
}
