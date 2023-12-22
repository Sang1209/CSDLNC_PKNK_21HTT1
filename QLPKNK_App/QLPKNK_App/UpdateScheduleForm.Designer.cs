namespace QLPKNK_App
{
    partial class UpdateScheduleForm
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
            this.newDate = new System.Windows.Forms.DateTimePicker();
            this.oldDate = new System.Windows.Forms.TextBox();
            this.oldToTime = new System.Windows.Forms.TextBox();
            this.oldFromTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newToTime = new System.Windows.Forms.TextBox();
            this.newFromTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newShiftID = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.oldShiftID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dentistName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newShiftID)).BeginInit();
            this.SuspendLayout();
            // 
            // newDate
            // 
            this.newDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.newDate.Location = new System.Drawing.Point(152, 213);
            this.newDate.Name = "newDate";
            this.newDate.Size = new System.Drawing.Size(200, 20);
            this.newDate.TabIndex = 0;
            // 
            // oldDate
            // 
            this.oldDate.Location = new System.Drawing.Point(152, 153);
            this.oldDate.Name = "oldDate";
            this.oldDate.ReadOnly = true;
            this.oldDate.Size = new System.Drawing.Size(200, 20);
            this.oldDate.TabIndex = 1;
            // 
            // oldToTime
            // 
            this.oldToTime.Location = new System.Drawing.Point(274, 336);
            this.oldToTime.Name = "oldToTime";
            this.oldToTime.ReadOnly = true;
            this.oldToTime.Size = new System.Drawing.Size(78, 20);
            this.oldToTime.TabIndex = 21;
            // 
            // oldFromTime
            // 
            this.oldFromTime.Location = new System.Drawing.Point(152, 337);
            this.oldFromTime.Name = "oldFromTime";
            this.oldFromTime.ReadOnly = true;
            this.oldFromTime.Size = new System.Drawing.Size(83, 20);
            this.oldFromTime.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Old Shift ID";
            // 
            // newToTime
            // 
            this.newToTime.Location = new System.Drawing.Point(274, 458);
            this.newToTime.Name = "newToTime";
            this.newToTime.ReadOnly = true;
            this.newToTime.Size = new System.Drawing.Size(78, 20);
            this.newToTime.TabIndex = 27;
            // 
            // newFromTime
            // 
            this.newFromTime.Location = new System.Drawing.Point(152, 459);
            this.newFromTime.Name = "newFromTime";
            this.newFromTime.ReadOnly = true;
            this.newFromTime.Size = new System.Drawing.Size(83, 20);
            this.newFromTime.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "New Shift ID";
            // 
            // newShiftID
            // 
            this.newShiftID.Location = new System.Drawing.Point(152, 409);
            this.newShiftID.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.newShiftID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.newShiftID.Name = "newShiftID";
            this.newShiftID.Size = new System.Drawing.Size(200, 20);
            this.newShiftID.TabIndex = 22;
            this.newShiftID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Update schedule";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldShiftID
            // 
            this.oldShiftID.Location = new System.Drawing.Point(152, 287);
            this.oldShiftID.Name = "oldShiftID";
            this.oldShiftID.ReadOnly = true;
            this.oldShiftID.Size = new System.Drawing.Size(200, 20);
            this.oldShiftID.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Old date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "New date";
            // 
            // dentistName
            // 
            this.dentistName.Location = new System.Drawing.Point(152, 90);
            this.dentistName.Name = "dentistName";
            this.dentistName.ReadOnly = true;
            this.dentistName.Size = new System.Drawing.Size(200, 20);
            this.dentistName.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(152, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Dentist";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 29);
            this.button1.TabIndex = 34;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dentistName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.oldShiftID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.newToTime);
            this.Controls.Add(this.newFromTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newShiftID);
            this.Controls.Add(this.oldToTime);
            this.Controls.Add(this.oldFromTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldDate);
            this.Controls.Add(this.newDate);
            this.Name = "UpdateScheduleForm";
            this.Text = "UpdateScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.newShiftID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker newDate;
        private System.Windows.Forms.TextBox oldDate;
        private System.Windows.Forms.TextBox oldToTime;
        private System.Windows.Forms.TextBox oldFromTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newToTime;
        private System.Windows.Forms.TextBox newFromTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown newShiftID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox oldShiftID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dentistName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}