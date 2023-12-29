namespace QLPKNK_App
{
    partial class UpdateAdmin_Staff
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.StaffRole = new System.Windows.Forms.ComboBox();
            this.StaffGender = new System.Windows.Forms.ComboBox();
            this.StaffAddress = new System.Windows.Forms.TextBox();
            this.StaffEmail = new System.Windows.Forms.TextBox();
            this.StaffPhone = new System.Windows.Forms.TextBox();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.StaffPassword = new System.Windows.Forms.TextBox();
            this.StaffUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(201, 406);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 21;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // StaffRole
            // 
            this.StaffRole.FormattingEnabled = true;
            this.StaffRole.Items.AddRange(new object[] {
            "Staff",
            "Admin"});
            this.StaffRole.Location = new System.Drawing.Point(229, 360);
            this.StaffRole.Name = "StaffRole";
            this.StaffRole.Size = new System.Drawing.Size(100, 24);
            this.StaffRole.TabIndex = 20;
            // 
            // StaffGender
            // 
            this.StaffGender.FormattingEnabled = true;
            this.StaffGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.StaffGender.Location = new System.Drawing.Point(229, 304);
            this.StaffGender.Name = "StaffGender";
            this.StaffGender.Size = new System.Drawing.Size(121, 24);
            this.StaffGender.TabIndex = 19;
            // 
            // StaffAddress
            // 
            this.StaffAddress.Location = new System.Drawing.Point(229, 251);
            this.StaffAddress.Name = "StaffAddress";
            this.StaffAddress.Size = new System.Drawing.Size(195, 22);
            this.StaffAddress.TabIndex = 17;
            // 
            // StaffEmail
            // 
            this.StaffEmail.Location = new System.Drawing.Point(229, 201);
            this.StaffEmail.Name = "StaffEmail";
            this.StaffEmail.Size = new System.Drawing.Size(153, 22);
            this.StaffEmail.TabIndex = 16;
            // 
            // StaffPhone
            // 
            this.StaffPhone.Location = new System.Drawing.Point(229, 156);
            this.StaffPhone.Name = "StaffPhone";
            this.StaffPhone.Size = new System.Drawing.Size(153, 22);
            this.StaffPhone.TabIndex = 15;
            // 
            // StaffName
            // 
            this.StaffName.Location = new System.Drawing.Point(229, 112);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(100, 22);
            this.StaffName.TabIndex = 14;
            // 
            // StaffPassword
            // 
            this.StaffPassword.Location = new System.Drawing.Point(229, 66);
            this.StaffPassword.Name = "StaffPassword";
            this.StaffPassword.Size = new System.Drawing.Size(153, 22);
            this.StaffPassword.TabIndex = 18;
            // 
            // StaffUsername
            // 
            this.StaffUsername.Location = new System.Drawing.Point(229, 21);
            this.StaffUsername.Name = "StaffUsername";
            this.StaffUsername.ReadOnly = true;
            this.StaffUsername.Size = new System.Drawing.Size(153, 22);
            this.StaffUsername.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Role";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // UpdateAdmin_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.StaffRole);
            this.Controls.Add(this.StaffGender);
            this.Controls.Add(this.StaffAddress);
            this.Controls.Add(this.StaffEmail);
            this.Controls.Add(this.StaffPhone);
            this.Controls.Add(this.StaffName);
            this.Controls.Add(this.StaffPassword);
            this.Controls.Add(this.StaffUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateAdmin_Staff";
            this.Text = "Update Staff Account";
            this.Load += new System.EventHandler(this.UpdateAdmin_Staff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ComboBox StaffRole;
        private System.Windows.Forms.ComboBox StaffGender;
        private System.Windows.Forms.TextBox StaffAddress;
        private System.Windows.Forms.TextBox StaffEmail;
        private System.Windows.Forms.TextBox StaffPhone;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.TextBox StaffPassword;
        private System.Windows.Forms.TextBox StaffUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}