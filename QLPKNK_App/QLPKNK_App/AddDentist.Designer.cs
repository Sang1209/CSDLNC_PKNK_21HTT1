namespace QLPKNK_App
{
    partial class AddDentist
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
            this.label1 = new System.Windows.Forms.Label();
            this.DentistDepartment = new System.Windows.Forms.ComboBox();
            this.DentistName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DentistUsername = new System.Windows.Forms.TextBox();
            this.DentistGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DentistEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DentistAddress = new System.Windows.Forms.TextBox();
            this.DentistPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DentistPassword = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DentistDepartment
            // 
            this.DentistDepartment.FormattingEnabled = true;
            this.DentistDepartment.Location = new System.Drawing.Point(188, 223);
            this.DentistDepartment.Name = "DentistDepartment";
            this.DentistDepartment.Size = new System.Drawing.Size(263, 24);
            this.DentistDepartment.TabIndex = 1;
            this.DentistDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DentistName
            // 
            this.DentistName.Location = new System.Drawing.Point(188, 121);
            this.DentistName.Name = "DentistName";
            this.DentistName.Size = new System.Drawing.Size(254, 22);
            this.DentistName.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username";
            // 
            // DentistUsername
            // 
            this.DentistUsername.Location = new System.Drawing.Point(188, 12);
            this.DentistUsername.Name = "DentistUsername";
            this.DentistUsername.Size = new System.Drawing.Size(254, 22);
            this.DentistUsername.TabIndex = 15;
            this.DentistUsername.TextChanged += new System.EventHandler(this.DentistUsername_TextChanged);
            // 
            // DentistGender
            // 
            this.DentistGender.FormattingEnabled = true;
            this.DentistGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.DentistGender.Location = new System.Drawing.Point(188, 172);
            this.DentistGender.Name = "DentistGender";
            this.DentistGender.Size = new System.Drawing.Size(121, 24);
            this.DentistGender.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gender";
            // 
            // DentistEmail
            // 
            this.DentistEmail.Location = new System.Drawing.Point(190, 381);
            this.DentistEmail.Name = "DentistEmail";
            this.DentistEmail.Size = new System.Drawing.Size(254, 22);
            this.DentistEmail.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Email";
            // 
            // DentistAddress
            // 
            this.DentistAddress.Location = new System.Drawing.Point(190, 330);
            this.DentistAddress.Name = "DentistAddress";
            this.DentistAddress.Size = new System.Drawing.Size(254, 22);
            this.DentistAddress.TabIndex = 27;
            // 
            // DentistPhone
            // 
            this.DentistPhone.Location = new System.Drawing.Point(190, 276);
            this.DentistPhone.Name = "DentistPhone";
            this.DentistPhone.Size = new System.Drawing.Size(156, 22);
            this.DentistPhone.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Phone";
            // 
            // DentistPassword
            // 
            this.DentistPassword.Location = new System.Drawing.Point(188, 64);
            this.DentistPassword.Name = "DentistPassword";
            this.DentistPassword.Size = new System.Drawing.Size(254, 22);
            this.DentistPassword.TabIndex = 30;
            this.DentistPassword.TextChanged += new System.EventHandler(this.DentistPassword_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(188, 415);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 31;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddDentist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.DentistPassword);
            this.Controls.Add(this.DentistEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DentistAddress);
            this.Controls.Add(this.DentistPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DentistGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DentistName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DentistUsername);
            this.Controls.Add(this.DentistDepartment);
            this.Controls.Add(this.label1);
            this.Name = "AddDentist";
            this.Text = "Add Dentist Account";
            this.Load += new System.EventHandler(this.AddDentist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DentistDepartment;
        private System.Windows.Forms.TextBox DentistName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DentistUsername;
        private System.Windows.Forms.ComboBox DentistGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DentistEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DentistAddress;
        private System.Windows.Forms.TextBox DentistPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DentistPassword;
        private System.Windows.Forms.Button Submit;
    }
}