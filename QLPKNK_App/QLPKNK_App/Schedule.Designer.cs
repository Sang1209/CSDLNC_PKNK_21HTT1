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
            this.label1 = new System.Windows.Forms.Label();
            this.searchBy = new System.Windows.Forms.ComboBox();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.searchUsername = new System.Windows.Forms.TextBox();
            this.searchID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.filterTitle = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dentist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TreatmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchID)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleTable
            // 
            this.scheduleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Shift,
            this.Start,
            this.Finish,
            this.Dentist,
            this.PatientID,
            this.Assistant,
            this.TreatmentID,
            this.DepID,
            this.DepAddress});
            this.scheduleTable.Location = new System.Drawing.Point(17, 244);
            this.scheduleTable.Name = "scheduleTable";
            this.scheduleTable.Size = new System.Drawing.Size(925, 364);
            this.scheduleTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(930, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Today Schedule";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBy
            // 
            this.searchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBy.FormattingEnabled = true;
            this.searchBy.Location = new System.Drawing.Point(389, 66);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(178, 21);
            this.searchBy.TabIndex = 2;
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(430, 161);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(102, 30);
            this.FilterBtn.TabIndex = 3;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // searchUsername
            // 
            this.searchUsername.Location = new System.Drawing.Point(389, 110);
            this.searchUsername.Name = "searchUsername";
            this.searchUsername.Size = new System.Drawing.Size(178, 20);
            this.searchUsername.TabIndex = 4;
            // 
            // searchID
            // 
            this.searchID.Location = new System.Drawing.Point(389, 110);
            this.searchID.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(178, 20);
            this.searchID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter by";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterTitle
            // 
            this.filterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTitle.Location = new System.Drawing.Point(256, 107);
            this.filterTitle.Name = "filterTitle";
            this.filterTitle.Size = new System.Drawing.Size(127, 23);
            this.filterTitle.TabIndex = 7;
            this.filterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // PatientID
            // 
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            // 
            // Assistant
            // 
            this.Assistant.HeaderText = "Assistant username";
            this.Assistant.Name = "Assistant";
            this.Assistant.ReadOnly = true;
            // 
            // TreatmentID
            // 
            this.TreatmentID.HeaderText = "Treatment ID";
            this.TreatmentID.Name = "TreatmentID";
            this.TreatmentID.ReadOnly = true;
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
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 620);
            this.Controls.Add(this.filterTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.searchUsername);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.searchBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduleTable);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scheduleTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchBy;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.TextBox searchUsername;
        private System.Windows.Forms.NumericUpDown searchID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label filterTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dentist;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreatmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepAddress;
    }
}