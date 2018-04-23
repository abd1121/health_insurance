namespace OOAD_Final_Project
{
    partial class registeredSuccessUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registeredSuccessUC));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resgiterButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(176, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registered Successfully!";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(112, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(617, 49);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dear User, You Are Successfully Logged In To Foodies. You Can Now Login To Your A" +
    "ccount And Can Access More Features.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // resgiterButton
            // 
            this.resgiterButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.resgiterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.resgiterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resgiterButton.BorderRadius = 7;
            this.resgiterButton.ButtonText = "  Login To Your Account";
            this.resgiterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resgiterButton.DisabledColor = System.Drawing.Color.Gray;
            this.resgiterButton.Iconcolor = System.Drawing.Color.Transparent;
            this.resgiterButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("resgiterButton.Iconimage")));
            this.resgiterButton.Iconimage_right = null;
            this.resgiterButton.Iconimage_right_Selected = null;
            this.resgiterButton.Iconimage_Selected = null;
            this.resgiterButton.IconMarginLeft = 0;
            this.resgiterButton.IconMarginRight = 0;
            this.resgiterButton.IconRightVisible = true;
            this.resgiterButton.IconRightZoom = 0D;
            this.resgiterButton.IconVisible = true;
            this.resgiterButton.IconZoom = 40D;
            this.resgiterButton.IsTab = false;
            this.resgiterButton.Location = new System.Drawing.Point(289, 230);
            this.resgiterButton.Name = "resgiterButton";
            this.resgiterButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.resgiterButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.resgiterButton.OnHoverTextColor = System.Drawing.Color.White;
            this.resgiterButton.selected = false;
            this.resgiterButton.Size = new System.Drawing.Size(269, 50);
            this.resgiterButton.TabIndex = 17;
            this.resgiterButton.Text = "  Login To Your Account";
            this.resgiterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resgiterButton.Textcolor = System.Drawing.Color.White;
            this.resgiterButton.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.resgiterButton.Click += new System.EventHandler(this.resgiterButton_Click);
            // 
            // registeredSuccessUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.resgiterButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "registeredSuccessUC";
            this.Size = new System.Drawing.Size(835, 415);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton resgiterButton;
    }
}
