namespace QLPKNK_App
{
    partial class AddAdmin_Staff
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminUsername = new System.Windows.Forms.TextBox();
            this.AdminPassword = new System.Windows.Forms.TextBox();
            this.AdminName = new System.Windows.Forms.TextBox();
            this.AdminGender = new System.Windows.Forms.ComboBox();
            this.AdminPhone = new System.Windows.Forms.TextBox();
            this.AdminAddress = new System.Windows.Forms.TextBox();
            this.AdminEmail = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Username";
            // 
            // AdminUsername
            // 
            this.AdminUsername.Location = new System.Drawing.Point(224, 28);
            this.AdminUsername.Name = "AdminUsername";
            this.AdminUsername.Size = new System.Drawing.Size(100, 22);
            this.AdminUsername.TabIndex = 37;
            // 
            // AdminPassword
            // 
            this.AdminPassword.Location = new System.Drawing.Point(224, 81);
            this.AdminPassword.Name = "AdminPassword";
            this.AdminPassword.Size = new System.Drawing.Size(100, 22);
            this.AdminPassword.TabIndex = 37;
            // 
            // AdminName
            // 
            this.AdminName.Location = new System.Drawing.Point(224, 137);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(100, 22);
            this.AdminName.TabIndex = 37;
            // 
            // AdminGender
            // 
            this.AdminGender.FormattingEnabled = true;
            this.AdminGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.AdminGender.Location = new System.Drawing.Point(224, 188);
            this.AdminGender.Name = "AdminGender";
            this.AdminGender.Size = new System.Drawing.Size(121, 24);
            this.AdminGender.TabIndex = 38;
            // 
            // AdminPhone
            // 
            this.AdminPhone.Location = new System.Drawing.Point(224, 275);
            this.AdminPhone.Name = "AdminPhone";
            this.AdminPhone.Size = new System.Drawing.Size(100, 22);
            this.AdminPhone.TabIndex = 37;
            // 
            // AdminAddress
            // 
            this.AdminAddress.Location = new System.Drawing.Point(224, 329);
            this.AdminAddress.Name = "AdminAddress";
            this.AdminAddress.Size = new System.Drawing.Size(100, 22);
            this.AdminAddress.TabIndex = 37;
            // 
            // AdminEmail
            // 
            this.AdminEmail.Location = new System.Drawing.Point(224, 380);
            this.AdminEmail.Name = "AdminEmail";
            this.AdminEmail.Size = new System.Drawing.Size(100, 22);
            this.AdminEmail.TabIndex = 37;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(178, 416);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 39;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Type";
            // 
            // AdminType
            // 
            this.AdminType.FormattingEnabled = true;
            this.AdminType.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.AdminType.Location = new System.Drawing.Point(224, 230);
            this.AdminType.Name = "AdminType";
            this.AdminType.Size = new System.Drawing.Size(121, 24);
            this.AdminType.TabIndex = 41;
            // 
            // AddAdmin_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AdminGender);
            this.Controls.Add(this.AdminEmail);
            this.Controls.Add(this.AdminAddress);
            this.Controls.Add(this.AdminPhone);
            this.Controls.Add(this.AdminName);
            this.Controls.Add(this.AdminPassword);
            this.Controls.Add(this.AdminUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddAdmin_Staff";
            this.Text = "Add Admin/Staff Account";
            this.Load += new System.EventHandler(this.AddAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminUsername;
        private System.Windows.Forms.TextBox AdminPassword;
        private System.Windows.Forms.TextBox AdminName;
        private System.Windows.Forms.ComboBox AdminGender;
        private System.Windows.Forms.TextBox AdminPhone;
        private System.Windows.Forms.TextBox AdminAddress;
        private System.Windows.Forms.TextBox AdminEmail;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AdminType;
    }
}