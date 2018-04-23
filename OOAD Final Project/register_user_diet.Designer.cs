namespace OOAD_Final_Project
{
    partial class register_user_diet
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
            this.top_container = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.relatedSuggetionsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // top_container
            // 
            this.top_container.Location = new System.Drawing.Point(15, 57);
            this.top_container.Name = "top_container";
            this.top_container.Size = new System.Drawing.Size(597, 137);
            this.top_container.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hi, Muhammad Numair You Should Have This Today";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Related Suggetions";
            // 
            // relatedSuggetionsContainer
            // 
            this.relatedSuggetionsContainer.Location = new System.Drawing.Point(13, 237);
            this.relatedSuggetionsContainer.Name = "relatedSuggetionsContainer";
            this.relatedSuggetionsContainer.Size = new System.Drawing.Size(599, 144);
            this.relatedSuggetionsContainer.TabIndex = 5;
            // 
            // register_user_diet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.relatedSuggetionsContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.top_container);
            this.Name = "register_user_diet";
            this.Size = new System.Drawing.Size(633, 409);
            this.Load += new System.EventHandler(this.register_user_diet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_container;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel relatedSuggetionsContainer;
    }
}
