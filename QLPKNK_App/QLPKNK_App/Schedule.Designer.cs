namespace QLPKNK_App
{
    partial class Schedule
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
            this.scheduleTable = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Reserve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Accept = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dentist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DentistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssistantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReTreatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accepted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBy = new System.Windows.Forms.ComboBox();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.createSchedule = new System.Windows.Forms.Button();
            this.DentistCB = new System.Windows.Forms.ComboBox();
            this.PatientCB = new System.Windows.Forms.ComboBox();
            this.DepartmentCB = new System.Windows.Forms.ComboBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.dentistLabel = new System.Windows.Forms.Label();
            this.PatientLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.treatmentID = new System.Windows.Forms.NumericUpDown();
            this.TreatmentLabel = new System.Windows.Forms.Label();
            this.enableDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentID)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleTable
            // 
            this.scheduleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Update,
            this.Reserve,
            this.Cancel,
            this.Accept,
            this.Date,
            this.Shift,
            this.Start,
            this.Finish,
            this.Dentist,
            this.DentistName,
            this.PatientID,
            this.PatientName,
            this.Assistant,
            this.AssistantName,
            this.ReTreatID,
            this.DepID,
            this.DepAddress,
            this.Accepted});
            this.scheduleTable.Location = new System.Drawing.Point(17, 244);
            this.scheduleTable.Name = "scheduleTable";
            this.scheduleTable.Size = new System.Drawing.Size(1483, 364);
            this.scheduleTable.TabIndex = 0;
            this.scheduleTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scheduleTable_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.ToolTipText = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Reserve
            // 
            this.Reserve.HeaderText = "Reserve";
            this.Reserve.Name = "Reserve";
            this.Reserve.Text = "Reserve";
            this.Reserve.ToolTipText = "Reserve";
            this.Reserve.UseColumnTextForButtonValue = true;
            // 
            // Cancel
            // 
            this.Cancel.HeaderText = "Cancel";
            this.Cancel.Name = "Cancel";
            this.Cancel.Text = "Cancel";
            this.Cancel.ToolTipText = "Cancel";
            this.Cancel.UseColumnTextForButtonValue = true;
            // 
            // Accept
            // 
            this.Accept.HeaderText = "Accept";
            this.Accept.Name = "Accept";
            this.Accept.Text = "Accept";
            this.Accept.ToolTipText = "Accept";
            this.Accept.UseColumnTextForButtonValue = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Shift
            // 
            this.Shift.HeaderText = "Shift";
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            // 
            // Start
            // 
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            // 
            // Finish
            // 
            this.Finish.HeaderText = "Finish";
            this.Finish.Name = "Finish";
            this.Finish.ReadOnly = true;
            // 
            // Dentist
            // 
            this.Dentist.HeaderText = "Dentist username";
            this.Dentist.Name = "Dentist";
            this.Dentist.ReadOnly = true;
            // 
            // DentistName
            // 
            this.DentistName.HeaderText = "Dentist name";
            this.DentistName.Name = "DentistName";
            this.DentistName.ReadOnly = true;
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Patient name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // Assistant
            // 
            this.Assistant.HeaderText = "Assistant username";
            this.Assistant.Name = "Assistant";
            this.Assistant.ReadOnly = true;
            // 
            // AssistantName
            // 
            this.AssistantName.HeaderText = "Assistant name";
            this.AssistantName.Name = "AssistantName";
            this.AssistantName.ReadOnly = true;
            // 
            // ReTreatID
            // 
            this.ReTreatID.HeaderText = "Re-exam Treatment ID";
            this.ReTreatID.Name = "ReTreatID";
            this.ReTreatID.ReadOnly = true;
            // 
            // DepID
            // 
            this.DepID.HeaderText = "Department ID";
            this.DepID.Name = "DepID";
            this.DepID.ReadOnly = true;
            // 
            // DepAddress
            // 
            this.DepAddress.HeaderText = "Department address";
            this.DepAddress.Name = "DepAddress";
            this.DepAddress.ReadOnly = true;
            // 
            // Accepted
            // 
            this.Accepted.HeaderText = "Accepted";
            this.Accepted.Name = "Accepted";
            this.Accepted.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1488, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schedule list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBy
            // 
            this.searchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBy.FormattingEnabled = true;
            this.searchBy.Location = new System.Drawing.Point(667, 72);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(178, 21);
            this.searchBy.TabIndex = 2;
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(706, 186);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(102, 30);
            this.FilterBtn.TabIndex = 3;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter by";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createSchedule
            // 
            this.createSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSchedule.Location = new System.Drawing.Point(1358, 21);
            this.createSchedule.Name = "createSchedule";
            this.createSchedule.Size = new System.Drawing.Size(142, 35);
            this.createSchedule.TabIndex = 8;
            this.createSchedule.Text = "Create a schedule";
            this.createSchedule.UseVisualStyleBackColor = true;
            this.createSchedule.Click += new System.EventHandler(this.createSchedule_Click);
            // 
            // DentistCB
            // 
            this.DentistCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DentistCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DentistCB.FormattingEnabled = true;
            this.DentistCB.Location = new System.Drawing.Point(150, 133);
            this.DentistCB.Name = "DentistCB";
            this.DentistCB.Size = new System.Drawing.Size(177, 21);
            this.DentistCB.TabIndex = 9;
            // 
            // PatientCB
            // 
            this.PatientCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PatientCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PatientCB.FormattingEnabled = true;
            this.PatientCB.Location = new System.Drawing.Point(412, 136);
            this.PatientCB.Name = "PatientCB";
            this.PatientCB.Size = new System.Drawing.Size(172, 21);
            this.PatientCB.TabIndex = 10;
            // 
            // DepartmentCB
            // 
            this.DepartmentCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DepartmentCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DepartmentCB.FormattingEnabled = true;
            this.DepartmentCB.Location = new System.Drawing.Point(673, 133);
            this.DepartmentCB.Name = "DepartmentCB";
            this.DepartmentCB.Size = new System.Drawing.Size(165, 21);
            this.DepartmentCB.TabIndex = 11;
            // 
            // DatePicker
            // 
            this.DatePicker.Enabled = false;
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(941, 133);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 12;
            // 
            // dentistLabel
            // 
            this.dentistLabel.AutoSize = true;
            this.dentistLabel.Location = new System.Drawing.Point(150, 114);
            this.dentistLabel.Name = "dentistLabel";
            this.dentistLabel.Size = new System.Drawing.Size(40, 13);
            this.dentistLabel.TabIndex = 13;
            this.dentistLabel.Text = "Dentist";
            // 
            // PatientLabel
            // 
            this.PatientLabel.AutoSize = true;
            this.PatientLabel.Location = new System.Drawing.Point(409, 114);
            this.PatientLabel.Name = "PatientLabel";
            this.PatientLabel.Size = new System.Drawing.Size(40, 13);
            this.PatientLabel.TabIndex = 14;
            this.PatientLabel.Text = "Patient";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(673, 114);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(62, 13);
            this.DepartmentLabel.TabIndex = 15;
            this.DepartmentLabel.Text = "Department";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(941, 114);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 16;
            this.DateLabel.Text = "Date";
            // 
            // treatmentID
            // 
            this.treatmentID.Location = new System.Drawing.Point(1213, 133);
            this.treatmentID.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.treatmentID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.treatmentID.Name = "treatmentID";
            this.treatmentID.Size = new System.Drawing.Size(155, 20);
            this.treatmentID.TabIndex = 17;
            this.treatmentID.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // TreatmentLabel
            // 
            this.TreatmentLabel.AutoSize = true;
            this.TreatmentLabel.Location = new System.Drawing.Point(1210, 114);
            this.TreatmentLabel.Name = "TreatmentLabel";
            this.TreatmentLabel.Size = new System.Drawing.Size(55, 13);
            this.TreatmentLabel.TabIndex = 18;
            this.TreatmentLabel.Text = "Treatment";
            // 
            // enableDate
            // 
            this.enableDate.AutoSize = true;
            this.enableDate.Location = new System.Drawing.Point(978, 114);
            this.enableDate.Name = "enableDate";
            this.enableDate.Size = new System.Drawing.Size(127, 17);
            this.enableDate.TabIndex = 19;
            this.enableDate.Text = "Check to find by date";
            this.enableDate.UseVisualStyleBackColor = true;
            this.enableDate.CheckedChanged += new System.EventHandler(this.enableDate_CheckedChanged);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 621);
            this.Controls.Add(this.enableDate);
            this.Controls.Add(this.TreatmentLabel);
            this.Controls.Add(this.treatmentID);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.PatientLabel);
            this.Controls.Add(this.dentistLabel);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.DepartmentCB);
            this.Controls.Add(this.PatientCB);
            this.Controls.Add(this.DentistCB);
            this.Controls.Add(this.createSchedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.searchBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduleTable);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scheduleTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchBy;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createSchedule;
        private System.Windows.Forms.ComboBox DentistCB;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.DataGridViewButtonColumn Update;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.DataGridViewButtonColumn Reserve;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
        private System.Windows.Forms.DataGridViewButtonColumn Accept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dentist;
        private System.Windows.Forms.DataGridViewTextBoxColumn DentistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssistantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReTreatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accepted;
        private System.Windows.Forms.ComboBox PatientCB;
        private System.Windows.Forms.ComboBox DepartmentCB;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label dentistLabel;
        private System.Windows.Forms.Label PatientLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.NumericUpDown treatmentID;
        private System.Windows.Forms.Label TreatmentLabel;
        private System.Windows.Forms.CheckBox enableDate;
    }
}