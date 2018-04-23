namespace OOAD_Final_Project
{
    partial class RegisterControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterControl));
            this.emailPanelrgstr = new System.Windows.Forms.Panel();
            this.emailTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passPanelrgstr = new System.Windows.Forms.Panel();
            this.passwordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginBtn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resgiterButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.phonePanelrgstr = new System.Windows.Forms.Panel();
            this.phoneTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.namePanelrgstr = new System.Windows.Forms.Panel();
            this.nameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameRound = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.phoneRound = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.emailRound = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.passwordRound = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.errorRequiredFields = new System.Windows.Forms.Label();
            this.errorAlreadyExists = new System.Windows.Forms.Label();
            this.emailPanelrgstr.SuspendLayout();
            this.passPanelrgstr.SuspendLayout();
            this.phonePanelrgstr.SuspendLayout();
            this.namePanelrgstr.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailPanelrgstr
            // 
            this.emailPanelrgstr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.emailPanelrgstr.Controls.Add(this.emailTextBox);
            this.emailPanelrgstr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.emailPanelrgstr.Location = new System.Drawing.Point(437, 179);
            this.emailPanelrgstr.Name = "emailPanelrgstr";
            this.emailPanelrgstr.Size = new System.Drawing.Size(342, 54);
            this.emailPanelrgstr.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.emailTextBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.emailTextBox.HintText = "Email";
            this.emailTextBox.isPassword = false;
            this.emailTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.emailTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.emailTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.emailTextBox.LineThickness = 1;
            this.emailTextBox.Location = new System.Drawing.Point(14, 10);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(323, 41);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTextBox.OnValueChanged += new System.EventHandler(this.emailTextBox_OnValueChanged);
            // 
            // passPanelrgstr
            // 
            this.passPanelrgstr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.passPanelrgstr.Controls.Add(this.passwordTextBox);
            this.passPanelrgstr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.passPanelrgstr.Location = new System.Drawing.Point(437, 245);
            this.passPanelrgstr.Name = "passPanelrgstr";
            this.passPanelrgstr.Size = new System.Drawing.Size(342, 54);
            this.passPanelrgstr.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.passwordTextBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.passwordTextBox.HintText = "Password";
            this.passwordTextBox.isPassword = false;
            this.passwordTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.passwordTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.passwordTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.passwordTextBox.LineThickness = 1;
            this.passwordTextBox.Location = new System.Drawing.Point(14, 10);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(323, 41);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.OnValueChanged += new System.EventHandler(this.passwordTextBox_OnValueChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.AutoSize = true;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 11.75F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.loginBtn.Location = new System.Drawing.Point(276, 321);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(91, 19);
            this.loginBtn.TabIndex = 15;
            this.loginBtn.Text = "Login Here";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(40, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Already Have an Acccount..?";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 138);
            this.label2.TabIndex = 13;
            this.label2.Text = "Get Yourself Login To Foodies To Get Access To Daily Diet Plans, Food Receipes, a" +
    "nd For Getting Best Deal in Your Area. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "Register To Foodies";
            // 
            // resgiterButton
            // 
            this.resgiterButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.resgiterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.resgiterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resgiterButton.BorderRadius = 7;
            this.resgiterButton.ButtonText = "  Resgiter";
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
            this.resgiterButton.Location = new System.Drawing.Point(437, 310);
            this.resgiterButton.Name = "resgiterButton";
            this.resgiterButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.resgiterButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.resgiterButton.OnHoverTextColor = System.Drawing.Color.White;
            this.resgiterButton.selected = false;
            this.resgiterButton.Size = new System.Drawing.Size(342, 50);
            this.resgiterButton.TabIndex = 4;
            this.resgiterButton.Text = "  Resgiter";
            this.resgiterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resgiterButton.Textcolor = System.Drawing.Color.White;
            this.resgiterButton.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.resgiterButton.Click += new System.EventHandler(this.resgiterButton_Click);
            // 
            // phonePanelrgstr
            // 
            this.phonePanelrgstr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.phonePanelrgstr.Controls.Add(this.phoneTextBox);
            this.phonePanelrgstr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.phonePanelrgstr.Location = new System.Drawing.Point(437, 114);
            this.phonePanelrgstr.Name = "phonePanelrgstr";
            this.phonePanelrgstr.Size = new System.Drawing.Size(342, 54);
            this.phonePanelrgstr.TabIndex = 11;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.phoneTextBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.phoneTextBox.HintText = "Phone";
            this.phoneTextBox.isPassword = false;
            this.phoneTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.phoneTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.phoneTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.phoneTextBox.LineThickness = 1;
            this.phoneTextBox.Location = new System.Drawing.Point(14, 10);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(323, 41);
            this.phoneTextBox.TabIndex = 1;
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneTextBox.OnValueChanged += new System.EventHandler(this.phoneTextBox_OnValueChanged);
            // 
            // namePanelrgstr
            // 
            this.namePanelrgstr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.namePanelrgstr.Controls.Add(this.nameTextBox);
            this.namePanelrgstr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.namePanelrgstr.Location = new System.Drawing.Point(437, 50);
            this.namePanelrgstr.Name = "namePanelrgstr";
            this.namePanelrgstr.Size = new System.Drawing.Size(342, 54);
            this.namePanelrgstr.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.nameTextBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.nameTextBox.HintText = "Name";
            this.nameTextBox.isPassword = false;
            this.nameTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.nameTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.nameTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.nameTextBox.LineThickness = 1;
            this.nameTextBox.Location = new System.Drawing.Point(14, 10);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(323, 41);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTextBox.OnValueChanged += new System.EventHandler(this.nameTextBox_OnValueChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(40, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 49);
            this.label5.TabIndex = 13;
            this.label5.Text = "You Will Get Latest Diet Plans Direct On Your Desktop.";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(40, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 49);
            this.label6.TabIndex = 13;
            this.label6.Text = "Maintaing your health is not an issue anymore.";
            // 
            // nameRound
            // 
            this.nameRound.ElipseRadius = 5;
            this.nameRound.TargetControl = this.namePanelrgstr;
            // 
            // phoneRound
            // 
            this.phoneRound.ElipseRadius = 5;
            this.phoneRound.TargetControl = this.phonePanelrgstr;
            // 
            // emailRound
            // 
            this.emailRound.ElipseRadius = 5;
            this.emailRound.TargetControl = this.emailPanelrgstr;
            // 
            // passwordRound
            // 
            this.passwordRound.ElipseRadius = 5;
            this.passwordRound.TargetControl = this.passPanelrgstr;
            // 
            // errorRequiredFields
            // 
            this.errorRequiredFields.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.errorRequiredFields.Location = new System.Drawing.Point(449, 378);
            this.errorRequiredFields.Name = "errorRequiredFields";
            this.errorRequiredFields.Size = new System.Drawing.Size(344, 49);
            this.errorRequiredFields.TabIndex = 17;
            this.errorRequiredFields.Text = "Required (*) Fields Must Not Be Empty";
            // 
            // errorAlreadyExists
            // 
            this.errorAlreadyExists.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAlreadyExists.ForeColor = System.Drawing.Color.Red;
            this.errorAlreadyExists.Location = new System.Drawing.Point(449, 378);
            this.errorAlreadyExists.Name = "errorAlreadyExists";
            this.errorAlreadyExists.Size = new System.Drawing.Size(344, 49);
            this.errorAlreadyExists.TabIndex = 18;
            this.errorAlreadyExists.Text = "User With Same Email Already Exists";
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.errorAlreadyExists);
            this.Controls.Add(this.errorRequiredFields);
            this.Controls.Add(this.namePanelrgstr);
            this.Controls.Add(this.phonePanelrgstr);
            this.Controls.Add(this.emailPanelrgstr);
            this.Controls.Add(this.passPanelrgstr);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resgiterButton);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(835, 415);
            this.Load += new System.EventHandler(this.RegisterControl_Load);
            this.emailPanelrgstr.ResumeLayout(false);
            this.passPanelrgstr.ResumeLayout(false);
            this.phonePanelrgstr.ResumeLayout(false);
            this.namePanelrgstr.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel emailPanelrgstr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTextBox;
        private System.Windows.Forms.Panel passPanelrgstr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextBox;
        private System.Windows.Forms.Label loginBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton resgiterButton;
        private System.Windows.Forms.Panel phonePanelrgstr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneTextBox;
        private System.Windows.Forms.Panel namePanelrgstr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse nameRound;
        private Bunifu.Framework.UI.BunifuElipse phoneRound;
        private Bunifu.Framework.UI.BunifuElipse emailRound;
        private Bunifu.Framework.UI.BunifuElipse passwordRound;
        private System.Windows.Forms.Label errorRequiredFields;
        private System.Windows.Forms.Label errorAlreadyExists;
    }
}
