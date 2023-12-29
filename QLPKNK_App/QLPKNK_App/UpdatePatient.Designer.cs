namespace QLPKNK_App
{
    partial class UpdatePatient
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
            this.ProfileID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.PatientBirth = new System.Windows.Forms.DateTimePicker();
            this.PatientPhone = new System.Windows.Forms.TextBox();
            this.PatientEmail = new System.Windows.Forms.TextBox();
            this.PatientAddress = new System.Windows.Forms.TextBox();
            this.PatientGender = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // ProfileID
            // 
            this.ProfileID.Location = new System.Drawing.Point(154, 34);
            this.ProfileID.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ProfileID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProfileID.Name = "ProfileID";
            this.ProfileID.ReadOnly = true;
            this.ProfileID.Size = new System.Drawing.Size(120, 22);
            this.ProfileID.TabIndex = 1;
            this.ProfileID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProfileID.ValueChanged += new System.EventHandler(this.ProfileID_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gender";
            // 
            // PatientName
            // 
            this.PatientName.Location = new System.Drawing.Point(154, 79);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(100, 22);
            this.PatientName.TabIndex = 2;
            this.PatientName.TextChanged += new System.EventHandler(this.PatientName_TextChanged);
            // 
            // PatientBirth
            // 
            this.PatientBirth.CustomFormat = "";
            this.PatientBirth.Location = new System.Drawing.Point(154, 126);
            this.PatientBirth.Name = "PatientBirth";
            this.PatientBirth.Size = new System.Drawing.Size(225, 22);
            this.PatientBirth.TabIndex = 3;
            this.PatientBirth.ValueChanged += new System.EventHandler(this.PatientBirth_ValueChanged);
            // 
            // PatientPhone
            // 
            this.PatientPhone.Location = new System.Drawing.Point(154, 182);
            this.PatientPhone.Name = "PatientPhone";
            this.PatientPhone.Size = new System.Drawing.Size(152, 22);
            this.PatientPhone.TabIndex = 4;
            this.PatientPhone.TextChanged += new System.EventHandler(this.PatientPhone_TextChanged);
            // 
            // PatientEmail
            // 
            this.PatientEmail.Location = new System.Drawing.Point(154, 234);
            this.PatientEmail.Name = "PatientEmail";
            this.PatientEmail.Size = new System.Drawing.Size(152, 22);
            this.PatientEmail.TabIndex = 5;
            this.PatientEmail.TextChanged += new System.EventHandler(this.PatientEmail_TextChanged);
            // 
            // PatientAddress
            // 
            this.PatientAddress.Location = new System.Drawing.Point(154, 287);
            this.PatientAddress.Name = "PatientAddress";
            this.PatientAddress.Size = new System.Drawing.Size(225, 22);
            this.PatientAddress.TabIndex = 6;
            this.PatientAddress.TextChanged += new System.EventHandler(this.PatientAddress_TextChanged);
            // 
            // PatientGender
            // 
            this.PatientGender.FormattingEnabled = true;
            this.PatientGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PatientGender.Location = new System.Drawing.Point(154, 343);
            this.PatientGender.Name = "PatientGender";
            this.PatientGender.Size = new System.Drawing.Size(121, 24);
            this.PatientGender.TabIndex = 7;
            this.PatientGender.SelectedIndexChanged += new System.EventHandler(this.PatientGender_SelectedIndexChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(154, 398);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PatientGender);
            this.Controls.Add(this.PatientAddress);
            this.Controls.Add(this.PatientEmail);
            this.Controls.Add(this.PatientPhone);
            this.Controls.Add(this.PatientBirth);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.ProfileID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePatient";
            this.Text = "Update Patient Profile";
            this.Load += new System.EventHandler(this.UpdatePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ProfileID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.DateTimePicker PatientBirth;
        private System.Windows.Forms.TextBox PatientPhone;
        private System.Windows.Forms.TextBox PatientEmail;
        private System.Windows.Forms.TextBox PatientAddress;
        private System.Windows.Forms.ComboBox PatientGender;
        private System.Windows.Forms.Button UpdateButton;
    }
}