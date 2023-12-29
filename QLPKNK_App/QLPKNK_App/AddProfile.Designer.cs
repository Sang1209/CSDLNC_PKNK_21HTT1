namespace QLPKNK_App
{
    partial class AddProfile
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.PatientBirth = new System.Windows.Forms.DateTimePicker();
            this.PatientPhone = new System.Windows.Forms.TextBox();
            this.PatientEmail = new System.Windows.Forms.TextBox();
            this.PatientAddress = new System.Windows.Forms.TextBox();
            this.PatientGender = new System.Windows.Forms.ComboBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gender";
            // 
            // PatientName
            // 
            this.PatientName.Location = new System.Drawing.Point(221, 52);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(100, 22);
            this.PatientName.TabIndex = 2;
            // 
            // PatientBirth
            // 
            this.PatientBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PatientBirth.Location = new System.Drawing.Point(221, 101);
            this.PatientBirth.Name = "PatientBirth";
            this.PatientBirth.Size = new System.Drawing.Size(121, 22);
            this.PatientBirth.TabIndex = 3;
            // 
            // PatientPhone
            // 
            this.PatientPhone.Location = new System.Drawing.Point(221, 155);
            this.PatientPhone.Name = "PatientPhone";
            this.PatientPhone.Size = new System.Drawing.Size(100, 22);
            this.PatientPhone.TabIndex = 2;
            // 
            // PatientEmail
            // 
            this.PatientEmail.Location = new System.Drawing.Point(221, 206);
            this.PatientEmail.Name = "PatientEmail";
            this.PatientEmail.Size = new System.Drawing.Size(100, 22);
            this.PatientEmail.TabIndex = 2;
            // 
            // PatientAddress
            // 
            this.PatientAddress.Location = new System.Drawing.Point(221, 260);
            this.PatientAddress.Name = "PatientAddress";
            this.PatientAddress.Size = new System.Drawing.Size(100, 22);
            this.PatientAddress.TabIndex = 2;
            // 
            // PatientGender
            // 
            this.PatientGender.FormattingEnabled = true;
            this.PatientGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PatientGender.Location = new System.Drawing.Point(221, 320);
            this.PatientGender.Name = "PatientGender";
            this.PatientGender.Size = new System.Drawing.Size(121, 24);
            this.PatientGender.TabIndex = 4;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(183, 390);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // AddProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.PatientGender);
            this.Controls.Add(this.PatientBirth);
            this.Controls.Add(this.PatientAddress);
            this.Controls.Add(this.PatientEmail);
            this.Controls.Add(this.PatientPhone);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProfile";
            this.Text = "Add Patient Profile";
            this.Load += new System.EventHandler(this.AddProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.DateTimePicker PatientBirth;
        private System.Windows.Forms.TextBox PatientPhone;
        private System.Windows.Forms.TextBox PatientEmail;
        private System.Windows.Forms.TextBox PatientAddress;
        private System.Windows.Forms.ComboBox PatientGender;
        private System.Windows.Forms.Button CreateButton;
    }
}