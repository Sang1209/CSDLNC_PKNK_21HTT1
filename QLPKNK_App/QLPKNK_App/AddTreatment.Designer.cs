namespace QLPKNK_App
{
    partial class AddTreatment
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
            this.PatientID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DentistCB = new System.Windows.Forms.ComboBox();
            this.AssistantCB = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MethodCB = new System.Windows.Forms.ComboBox();
            this.ToothCB = new System.Windows.Forms.ComboBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DepartmentCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatientID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // PatientID
            // 
            this.PatientID.Location = new System.Drawing.Point(124, 62);
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Size = new System.Drawing.Size(120, 22);
            this.PatientID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PATIENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // PatientName
            // 
            this.PatientName.Location = new System.Drawing.Point(510, 61);
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Size = new System.Drawing.Size(116, 22);
            this.PatientName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "ASSISTANT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "DENTIST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "DESCRIPTION";
            // 
            // DentistCB
            // 
            this.DentistCB.FormattingEnabled = true;
            this.DentistCB.Location = new System.Drawing.Point(177, 175);
            this.DentistCB.Name = "DentistCB";
            this.DentistCB.Size = new System.Drawing.Size(137, 24);
            this.DentistCB.TabIndex = 5;
            // 
            // AssistantCB
            // 
            this.AssistantCB.FormattingEnabled = true;
            this.AssistantCB.Location = new System.Drawing.Point(565, 175);
            this.AssistantCB.Name = "AssistantCB";
            this.AssistantCB.Size = new System.Drawing.Size(137, 24);
            this.AssistantCB.TabIndex = 5;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(175, 253);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(488, 78);
            this.Description.TabIndex = 6;
            this.Description.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "NOTE";
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(175, 380);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(488, 78);
            this.Note.TabIndex = 6;
            this.Note.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "METHOD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "TOOTH";
            // 
            // MethodCB
            // 
            this.MethodCB.FormattingEnabled = true;
            this.MethodCB.Location = new System.Drawing.Point(175, 514);
            this.MethodCB.Name = "MethodCB";
            this.MethodCB.Size = new System.Drawing.Size(137, 24);
            this.MethodCB.TabIndex = 5;
            // 
            // ToothCB
            // 
            this.ToothCB.FormattingEnabled = true;
            this.ToothCB.Location = new System.Drawing.Point(565, 514);
            this.ToothCB.Name = "ToothCB";
            this.ToothCB.Size = new System.Drawing.Size(137, 24);
            this.ToothCB.TabIndex = 5;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(335, 582);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(118, 23);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "CREATE";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "DEPARTMENT";
            // 
            // DepartmentCB
            // 
            this.DepartmentCB.FormattingEnabled = true;
            this.DepartmentCB.Location = new System.Drawing.Point(374, 118);
            this.DepartmentCB.Name = "DepartmentCB";
            this.DepartmentCB.Size = new System.Drawing.Size(190, 24);
            this.DepartmentCB.TabIndex = 9;
            // 
            // AddTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.DepartmentCB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ToothCB);
            this.Controls.Add(this.MethodCB);
            this.Controls.Add(this.AssistantCB);
            this.Controls.Add(this.DentistCB);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatientID);
            this.Controls.Add(this.label1);
            this.Name = "AddTreatment";
            this.Text = "Add Treament";
            ((System.ComponentModel.ISupportInitialize)(this.PatientID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DentistCB;
        private System.Windows.Forms.ComboBox AssistantCB;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Note;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox MethodCB;
        private System.Windows.Forms.ComboBox ToothCB;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox DepartmentCB;
    }
}