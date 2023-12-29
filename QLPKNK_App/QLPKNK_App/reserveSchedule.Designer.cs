namespace QLPKNK_App
{
    partial class reserveSchedule
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
            this.dentist = new System.Windows.Forms.TextBox();
            this.shiftID = new System.Windows.Forms.TextBox();
            this.patientCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AddNewPatient = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dentist
            // 
            this.dentist.Location = new System.Drawing.Point(248, 274);
            this.dentist.Name = "dentist";
            this.dentist.ReadOnly = true;
            this.dentist.Size = new System.Drawing.Size(255, 20);
            this.dentist.TabIndex = 0;
            // 
            // shiftID
            // 
            this.shiftID.Location = new System.Drawing.Point(248, 170);
            this.shiftID.Name = "shiftID";
            this.shiftID.ReadOnly = true;
            this.shiftID.Size = new System.Drawing.Size(255, 20);
            this.shiftID.TabIndex = 2;
            // 
            // patientCB
            // 
            this.patientCB.FormattingEnabled = true;
            this.patientCB.Location = new System.Drawing.Point(248, 330);
            this.patientCB.Name = "patientCB";
            this.patientCB.Size = new System.Drawing.Size(255, 21);
            this.patientCB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reserve schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Shift ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "To";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(248, 214);
            this.from.Name = "from";
            this.from.ReadOnly = true;
            this.from.Size = new System.Drawing.Size(100, 20);
            this.from.TabIndex = 10;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(411, 213);
            this.to.Name = "to";
            this.to.ReadOnly = true;
            this.to.Size = new System.Drawing.Size(92, 20);
            this.to.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dentist";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reserve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewPatient
            // 
            this.AddNewPatient.Location = new System.Drawing.Point(643, 29);
            this.AddNewPatient.Name = "AddNewPatient";
            this.AddNewPatient.Size = new System.Drawing.Size(122, 41);
            this.AddNewPatient.TabIndex = 14;
            this.AddNewPatient.Text = "Add new patient";
            this.AddNewPatient.UseVisualStyleBackColor = true;
            this.AddNewPatient.Click += new System.EventHandler(this.AddNewPatient_Click);
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(248, 118);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(255, 20);
            this.date.TabIndex = 15;
            // 
            // reserveSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date);
            this.Controls.Add(this.AddNewPatient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientCB);
            this.Controls.Add(this.shiftID);
            this.Controls.Add(this.dentist);
            this.Name = "reserveSchedule";
            this.Text = "reserveSchedule";
            this.Load += new System.EventHandler(this.reserveSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dentist;
        private System.Windows.Forms.TextBox shiftID;
        private System.Windows.Forms.ComboBox patientCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddNewPatient;
        private System.Windows.Forms.DateTimePicker date;
    }
}