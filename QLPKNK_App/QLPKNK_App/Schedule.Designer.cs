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
            this.Accepted = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Accepted,
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
            this.DepAddress});
            this.scheduleTable.Location = new System.Drawing.Point(23, 300);
            this.scheduleTable.Margin = new System.Windows.Forms.Padding(4);
            this.scheduleTable.Name = "scheduleTable";
            this.scheduleTable.RowHeadersWidth = 51;
            this.scheduleTable.Size = new System.Drawing.Size(1977, 448);
            this.scheduleTable.TabIndex = 0;
            this.scheduleTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scheduleTable_CellContentClick);
            // 
            // Accepted
            // 
            this.Accepted.HeaderText = "Accepted";
            this.Accepted.MinimumWidth = 6;
            this.Accepted.Name = "Accepted";
            this.Accepted.ReadOnly = true;
            this.Accepted.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.ToolTipText = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 125;
            // 
            // Reserve
            // 
            this.Reserve.HeaderText = "Reserve";
            this.Reserve.MinimumWidth = 6;
            this.Reserve.Name = "Reserve";
            this.Reserve.Text = "Reserve";
            this.Reserve.ToolTipText = "Reserve";
            this.Reserve.UseColumnTextForButtonValue = true;
            this.Reserve.Width = 125;
            // 
            // Cancel
            // 
            this.Cancel.HeaderText = "Cancel";
            this.Cancel.MinimumWidth = 6;
            this.Cancel.Name = "Cancel";
            this.Cancel.Text = "Cancel";
            this.Cancel.ToolTipText = "Cancel";
            this.Cancel.UseColumnTextForButtonValue = true;
            this.Cancel.Width = 125;
            // 
            // Accept
            // 
            this.Accept.HeaderText = "Accept";
            this.Accept.MinimumWidth = 6;
            this.Accept.Name = "Accept";
            this.Accept.Text = "Accept";
            this.Accept.ToolTipText = "Accept";
            this.Accept.UseColumnTextForButtonValue = true;
            this.Accept.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // Shift
            // 
            this.Shift.HeaderText = "Shift";
            this.Shift.MinimumWidth = 6;
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            this.Shift.Width = 125;
            // 
            // Start
            // 
            this.Start.HeaderText = "Start";
            this.Start.MinimumWidth = 6;
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.Width = 125;
            // 
            // Finish
            // 
            this.Finish.HeaderText = "Finish";
            this.Finish.MinimumWidth = 6;
            this.Finish.Name = "Finish";
            this.Finish.ReadOnly = true;
            this.Finish.Width = 125;
            // 
            // Dentist
            // 
            this.Dentist.HeaderText = "Dentist username";
            this.Dentist.MinimumWidth = 6;
            this.Dentist.Name = "Dentist";
            this.Dentist.ReadOnly = true;
            this.Dentist.Width = 125;
            // 
            // DentistName
            // 
            this.DentistName.HeaderText = "Dentist name";
            this.DentistName.MinimumWidth = 6;
            this.DentistName.Name = "DentistName";
            this.DentistName.ReadOnly = true;
            this.DentistName.Width = 125;
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.MinimumWidth = 6;
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 125;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Patient name";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Width = 125;
            // 
            // Assistant
            // 
            this.Assistant.HeaderText = "Assistant username";
            this.Assistant.MinimumWidth = 6;
            this.Assistant.Name = "Assistant";
            this.Assistant.ReadOnly = true;
            this.Assistant.Width = 125;
            // 
            // AssistantName
            // 
            this.AssistantName.HeaderText = "Assistant name";
            this.AssistantName.MinimumWidth = 6;
            this.AssistantName.Name = "AssistantName";
            this.AssistantName.ReadOnly = true;
            this.AssistantName.Width = 125;
            // 
            // ReTreatID
            // 
            this.ReTreatID.HeaderText = "Re-exam Treatment ID";
            this.ReTreatID.MinimumWidth = 6;
            this.ReTreatID.Name = "ReTreatID";
            this.ReTreatID.ReadOnly = true;
            this.ReTreatID.Width = 125;
            // 
            // DepID
            // 
            this.DepID.HeaderText = "Department ID";
            this.DepID.MinimumWidth = 6;
            this.DepID.Name = "DepID";
            this.DepID.ReadOnly = true;
            this.DepID.Width = 125;
            // 
            // DepAddress
            // 
            this.DepAddress.HeaderText = "Department address";
            this.DepAddress.MinimumWidth = 6;
            this.DepAddress.Name = "DepAddress";
            this.DepAddress.ReadOnly = true;
            this.DepAddress.Width = 125;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1984, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schedule list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBy
            // 
            this.searchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBy.FormattingEnabled = true;
            this.searchBy.Location = new System.Drawing.Point(889, 89);
            this.searchBy.Margin = new System.Windows.Forms.Padding(4);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(236, 24);
            this.searchBy.TabIndex = 2;
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(941, 229);
            this.FilterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(136, 37);
            this.FilterBtn.TabIndex = 3;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(712, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter by";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createSchedule
            // 
            this.createSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSchedule.Location = new System.Drawing.Point(1811, 26);
            this.createSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.createSchedule.Name = "createSchedule";
            this.createSchedule.Size = new System.Drawing.Size(189, 43);
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
            this.DentistCB.Location = new System.Drawing.Point(200, 164);
            this.DentistCB.Margin = new System.Windows.Forms.Padding(4);
            this.DentistCB.Name = "DentistCB";
            this.DentistCB.Size = new System.Drawing.Size(235, 24);
            this.DentistCB.TabIndex = 9;
            // 
            // PatientCB
            // 
            this.PatientCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PatientCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PatientCB.FormattingEnabled = true;
            this.PatientCB.Location = new System.Drawing.Point(549, 167);
            this.PatientCB.Margin = new System.Windows.Forms.Padding(4);
            this.PatientCB.Name = "PatientCB";
            this.PatientCB.Size = new System.Drawing.Size(228, 24);
            this.PatientCB.TabIndex = 10;
            this.PatientCB.SelectedIndexChanged += new System.EventHandler(this.PatientCB_SelectedIndexChanged);
            // 
            // DepartmentCB
            // 
            this.DepartmentCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DepartmentCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DepartmentCB.FormattingEnabled = true;
            this.DepartmentCB.Location = new System.Drawing.Point(897, 164);
            this.DepartmentCB.Margin = new System.Windows.Forms.Padding(4);
            this.DepartmentCB.Name = "DepartmentCB";
            this.DepartmentCB.Size = new System.Drawing.Size(219, 24);
            this.DepartmentCB.TabIndex = 11;
            // 
            // DatePicker
            // 
            this.DatePicker.Enabled = false;
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(1255, 164);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(265, 22);
            this.DatePicker.TabIndex = 12;
            // 
            // dentistLabel
            // 
            this.dentistLabel.AutoSize = true;
            this.dentistLabel.Location = new System.Drawing.Point(200, 140);
            this.dentistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dentistLabel.Name = "dentistLabel";
            this.dentistLabel.Size = new System.Drawing.Size(48, 16);
            this.dentistLabel.TabIndex = 13;
            this.dentistLabel.Text = "Dentist";
            // 
            // PatientLabel
            // 
            this.PatientLabel.AutoSize = true;
            this.PatientLabel.Location = new System.Drawing.Point(545, 140);
            this.PatientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientLabel.Name = "PatientLabel";
            this.PatientLabel.Size = new System.Drawing.Size(48, 16);
            this.PatientLabel.TabIndex = 14;
            this.PatientLabel.Text = "Patient";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(897, 140);
            this.DepartmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(77, 16);
            this.DepartmentLabel.TabIndex = 15;
            this.DepartmentLabel.Text = "Department";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(1255, 140);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(36, 16);
            this.DateLabel.TabIndex = 16;
            this.DateLabel.Text = "Date";
            // 
            // treatmentID
            // 
            this.treatmentID.Location = new System.Drawing.Point(1617, 164);
            this.treatmentID.Margin = new System.Windows.Forms.Padding(4);
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
            this.treatmentID.Size = new System.Drawing.Size(207, 22);
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
            this.TreatmentLabel.Location = new System.Drawing.Point(1613, 140);
            this.TreatmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TreatmentLabel.Name = "TreatmentLabel";
            this.TreatmentLabel.Size = new System.Drawing.Size(68, 16);
            this.TreatmentLabel.TabIndex = 18;
            this.TreatmentLabel.Text = "Treatment";
            // 
            // enableDate
            // 
            this.enableDate.AutoSize = true;
            this.enableDate.Location = new System.Drawing.Point(1304, 140);
            this.enableDate.Margin = new System.Windows.Forms.Padding(4);
            this.enableDate.Name = "enableDate";
            this.enableDate.Size = new System.Drawing.Size(153, 20);
            this.enableDate.TabIndex = 19;
            this.enableDate.Text = "Check to find by date";
            this.enableDate.UseVisualStyleBackColor = true;
            this.enableDate.CheckedChanged += new System.EventHandler(this.enableDate_CheckedChanged);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 764);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Accepted;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
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
    }
}