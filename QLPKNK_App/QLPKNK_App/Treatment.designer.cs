namespace buhbuhlmao
{
    partial class Treatment
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
            this.TreatmentTable = new System.Windows.Forms.DataGridView();
            this.ViewPrescription = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DentistID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssistantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToothName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDSearch = new System.Windows.Forms.NumericUpDown();
            this.searchPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TreatmentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientIDSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // TreatmentTable
            // 
            this.TreatmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TreatmentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewPrescription,
            this.ID,
            this.Department,
            this.PatientID,
            this.DentistID,
            this.AssistantID,
            this.Column5,
            this.Date,
            this.Note,
            this.Method,
            this.ToothName,
            this.State,
            this.Total});
            this.TreatmentTable.Location = new System.Drawing.Point(12, 149);
            this.TreatmentTable.Name = "TreatmentTable";
            this.TreatmentTable.Size = new System.Drawing.Size(1060, 435);
            this.TreatmentTable.TabIndex = 0;
            this.TreatmentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewPrescription
            // 
            this.ViewPrescription.HeaderText = "View Prescription";
            this.ViewPrescription.Name = "ViewPrescription";
            this.ViewPrescription.ReadOnly = true;
            this.ViewPrescription.Text = "View";
            this.ViewPrescription.ToolTipText = "View";
            this.ViewPrescription.UseColumnTextForButtonValue = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 79;
            // 
            // DentistID
            // 
            this.DentistID.HeaderText = "Dentist ID";
            this.DentistID.Name = "DentistID";
            this.DentistID.ReadOnly = true;
            this.DentistID.Width = 79;
            // 
            // AssistantID
            // 
            this.AssistantID.HeaderText = "Assistant ID";
            this.AssistantID.Name = "AssistantID";
            this.AssistantID.ReadOnly = true;
            this.AssistantID.Width = 88;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Method
            // 
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            this.Method.Width = 75;
            // 
            // ToothName
            // 
            this.ToothName.HeaderText = "Tooth name";
            this.ToothName.Name = "ToothName";
            this.ToothName.ReadOnly = true;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 57;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // patientIDSearch
            // 
            this.patientIDSearch.Location = new System.Drawing.Point(446, 93);
            this.patientIDSearch.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.patientIDSearch.Name = "patientIDSearch";
            this.patientIDSearch.Size = new System.Drawing.Size(120, 20);
            this.patientIDSearch.TabIndex = 5;
            // 
            // searchPatient
            // 
            this.searchPatient.Location = new System.Drawing.Point(593, 90);
            this.searchPatient.Name = "searchPatient";
            this.searchPatient.Size = new System.Drawing.Size(75, 23);
            this.searchPatient.TabIndex = 6;
            this.searchPatient.Text = "Search";
            this.searchPatient.UseVisualStyleBackColor = true;
            this.searchPatient.Click += new System.EventHandler(this.searchPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1042, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Treatment list";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 596);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchPatient);
            this.Controls.Add(this.patientIDSearch);
            this.Controls.Add(this.TreatmentTable);
            this.Name = "Treatment";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TreatmentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientIDSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TreatmentTable;
        private System.Windows.Forms.NumericUpDown patientIDSearch;
        private System.Windows.Forms.Button searchPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn ViewPrescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DentistID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssistantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToothName;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label2;
    }
}

