namespace QLPKNK_App
{
    partial class AddShcedule
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
            System.Windows.Forms.Label label7;
            this.date = new System.Windows.Forms.DateTimePicker();
            this.ShiftID = new System.Windows.Forms.NumericUpDown();
            this.fromTime = new System.Windows.Forms.DateTimePicker();
            this.toTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dentistCB = new System.Windows.Forms.ComboBox();
            this.assistantCB = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftID)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(117, 148);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 0;
            // 
            // ShiftID
            // 
            this.ShiftID.Location = new System.Drawing.Point(117, 207);
            this.ShiftID.Name = "ShiftID";
            this.ShiftID.Size = new System.Drawing.Size(200, 20);
            this.ShiftID.TabIndex = 1;
            // 
            // fromTime
            // 
            this.fromTime.Enabled = false;
            this.fromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fromTime.Location = new System.Drawing.Point(117, 256);
            this.fromTime.Name = "fromTime";
            this.fromTime.Size = new System.Drawing.Size(77, 20);
            this.fromTime.TabIndex = 0;
            // 
            // toTime
            // 
            this.toTime.Enabled = false;
            this.toTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.toTime.Location = new System.Drawing.Point(239, 256);
            this.toTime.Name = "toTime";
            this.toTime.Size = new System.Drawing.Size(78, 20);
            this.toTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shift ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dentist";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Assistant";
            // 
            // dentistCB
            // 
            this.dentistCB.FormattingEnabled = true;
            this.dentistCB.Location = new System.Drawing.Point(117, 312);
            this.dentistCB.Name = "dentistCB";
            this.dentistCB.Size = new System.Drawing.Size(200, 21);
            this.dentistCB.TabIndex = 10;
            // 
            // assistantCB
            // 
            this.assistantCB.FormattingEnabled = true;
            this.assistantCB.Location = new System.Drawing.Point(117, 370);
            this.assistantCB.Name = "assistantCB";
            this.assistantCB.Size = new System.Drawing.Size(200, 21);
            this.assistantCB.TabIndex = 11;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(165, 435);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(91, 32);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "Add schedule";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(12, 34);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(440, 69);
            label7.TabIndex = 13;
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddShcedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 612);
            this.Controls.Add(label7);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.assistantCB);
            this.Controls.Add(this.dentistCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toTime);
            this.Controls.Add(this.fromTime);
            this.Controls.Add(this.ShiftID);
            this.Controls.Add(this.date);
            this.Name = "AddShcedule";
            this.Text = "AddShcedule";
            this.Load += new System.EventHandler(this.AddShcedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShiftID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.NumericUpDown ShiftID;
        private System.Windows.Forms.DateTimePicker fromTime;
        private System.Windows.Forms.DateTimePicker toTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dentistCB;
        private System.Windows.Forms.ComboBox assistantCB;
        private System.Windows.Forms.Button AddBtn;
    }
}