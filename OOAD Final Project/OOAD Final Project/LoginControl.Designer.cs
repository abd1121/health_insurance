namespace OOAD_Final_Project
{
    partial class LoginControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            this.emailPanel = new System.Windows.Forms.Panel();
            this.emailTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passPanel = new System.Windows.Forms.Panel();
            this.passTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rgstrHereBtn = new System.Windows.Forms.Label();
            this.forgotPassBtn = new System.Windows.Forms.Label();
            this.emailRound = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.passwordRound = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.errorRequiredFields = new System.Windows.Forms.Label();
            this.errorInccorectDetails = new System.Windows.Forms.Label();
            this.emailPanel.SuspendLayout();
            this.passPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailPanel
            // 
            this.emailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.emailPanel.Controls.Add(this.emailTxtBox);
            this.emailPanel.Location = new System.Drawing.Point(437, 97);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(342, 54);
            this.emailPanel.TabIndex = 6;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.emailTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.emailTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.emailTxtBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.emailTxtBox.HintText = "Email";
            this.emailTxtBox.isPassword = false;
            this.emailTxtBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.emailTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.emailTxtBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.emailTxtBox.LineThickness = 1;
            this.emailTxtBox.Location = new System.Drawing.Point(12, 10);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(323, 41);
            this.emailTxtBox.TabIndex = 0;
            this.emailTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTxtBox.OnValueChanged += new System.EventHandler(this.emailTxtBox_OnValueChanged);
            // 
            // passPanel
            // 
            this.passPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.passPanel.Controls.Add(this.passTxtBox);
            this.passPanel.Location = new System.Drawing.Point(437, 160);
            this.passPanel.Name = "passPanel";
            this.passPanel.Size = new System.Drawing.Size(342, 54);
            this.passPanel.TabIndex = 6;
            // 
            // passTxtBox
            // 
            this.passTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.passTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.passTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.passTxtBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.passTxtBox.HintText = "Password";
            this.passTxtBox.isPassword = false;
            this.passTxtBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.passTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.passTxtBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.passTxtBox.LineThickness = 1;
            this.passTxtBox.Location = new System.Drawing.Point(12, 10);
            this.passTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.Size = new System.Drawing.Size(323, 41);
            this.passTxtBox.TabIndex = 1;
            this.passTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passTxtBox.OnValueChanged += new System.EventHandler(this.passTxtBox_OnValueChanged);
            // 
            // loginButton
            // 
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.BorderRadius = 7;
            this.loginButton.ButtonText = "  Login";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginButton.Iconimage")));
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = true;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = true;
            this.loginButton.IconZoom = 40D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(437, 223);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(342, 50);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "  Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(24, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 47);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login To Foodies";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(24, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 138);
            this.label2.TabIndex = 8;
            this.label2.Text = "Get Yourself Login To Foodies To Get Access To Daily Diet Plans, Food Receipes, a" +
    "nd For Getting Best Deal in Your Area. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(24, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Don\'t Have an Acccount..?";
            // 
            // rgstrHereBtn
            // 
            this.rgstrHereBtn.AutoSize = true;
            this.rgstrHereBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rgstrHereBtn.Font = new System.Drawing.Font("Century Gothic", 11.75F, System.Drawing.FontStyle.Bold);
            this.rgstrHereBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.rgstrHereBtn.Location = new System.Drawing.Point(244, 254);
            this.rgstrHereBtn.Name = "rgstrHereBtn";
            this.rgstrHereBtn.Size = new System.Drawing.Size(108, 19);
            this.rgstrHereBtn.TabIndex = 5;
            this.rgstrHereBtn.Text = "Register Here";
            this.rgstrHereBtn.Click += new System.EventHandler(this.rgstrHereBtn_Click);
            // 
            // forgotPassBtn
            // 
            this.forgotPassBtn.AutoSize = true;
            this.forgotPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassBtn.Font = new System.Drawing.Font("Century Gothic", 11.75F, System.Drawing.FontStyle.Bold);
            this.forgotPassBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.forgotPassBtn.Location = new System.Drawing.Point(547, 276);
            this.forgotPassBtn.Name = "forgotPassBtn";
            this.forgotPassBtn.Size = new System.Drawing.Size(132, 19);
            this.forgotPassBtn.TabIndex = 4;
            this.forgotPassBtn.Text = "Forget Password";
            this.forgotPassBtn.Click += new System.EventHandler(this.forgotPassBtn_Click);
            // 
            // emailRound
            // 
            this.emailRound.ElipseRadius = 5;
            this.emailRound.TargetControl = this.emailPanel;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // passwordRound
            // 
            this.passwordRound.ElipseRadius = 5;
            this.passwordRound.TargetControl = this.passPanel;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // errorRequiredFields
            // 
            this.errorRequiredFields.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.errorRequiredFields.Location = new System.Drawing.Point(476, 312);
            this.errorRequiredFields.Name = "errorRequiredFields";
            this.errorRequiredFields.Size = new System.Drawing.Size(344, 49);
            this.errorRequiredFields.TabIndex = 19;
            this.errorRequiredFields.Text = "Fill in all the required fields first";
            // 
            // errorInccorectDetails
            // 
            this.errorInccorectDetails.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.errorInccorectDetails.ForeColor = System.Drawing.Color.Red;
            this.errorInccorectDetails.Location = new System.Drawing.Point(476, 312);
            this.errorInccorectDetails.Name = "errorInccorectDetails";
            this.errorInccorectDetails.Size = new System.Drawing.Size(373, 49);
            this.errorInccorectDetails.TabIndex = 20;
            this.errorInccorectDetails.Text = "Username/Password is incorrect";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.errorInccorectDetails);
            this.Controls.Add(this.errorRequiredFields);
            this.Controls.Add(this.forgotPassBtn);
            this.Controls.Add(this.rgstrHereBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passPanel);
            this.Controls.Add(this.emailPanel);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(835, 415);
            this.emailPanel.ResumeLayout(false);
            this.passPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel emailPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTxtBox;
        private System.Windows.Forms.Panel passPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passTxtBox;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rgstrHereBtn;
        private System.Windows.Forms.Label forgotPassBtn;
        private Bunifu.Framework.UI.BunifuElipse emailRound;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse passwordRound;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label errorRequiredFields;
        private System.Windows.Forms.Label errorInccorectDetails;
    }
}
