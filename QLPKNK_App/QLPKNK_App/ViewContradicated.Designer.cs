namespace QLPKNK_App
{
    partial class ViewContradicated
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
            this.patient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contraTable = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contraTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraindicated list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patient
            // 
            this.patient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.patient.FormattingEnabled = true;
            this.patient.Location = new System.Drawing.Point(242, 154);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(254, 21);
            this.patient.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient";
            // 
            // contraTable
            // 
            this.contraTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contraTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.PatientName,
            this.MedicineID,
            this.MedicineName,
            this.Update,
            this.Delete});
            this.contraTable.Location = new System.Drawing.Point(43, 244);
            this.contraTable.Name = "contraTable";
            this.contraTable.Size = new System.Drawing.Size(655, 311);
            this.contraTable.TabIndex = 3;
            this.contraTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contraTable_CellContentClick);
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // MedicineID
            // 
            this.MedicineID.HeaderText = "Medicine ID";
            this.MedicineID.Name = "MedicineID";
            this.MedicineID.ReadOnly = true;
            // 
            // MedicineName
            // 
            this.MedicineName.HeaderText = "Medicine Name";
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.ToolTipText = "Update";
            this.Update.UseColumnTextForButtonValue = true;
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
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(623, 64);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add contradicated";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // ViewContradicated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 601);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.contraTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patient);
            this.Controls.Add(this.label1);
            this.Name = "ViewContradicated";
            this.Text = "ViewContradicated";
            this.Load += new System.EventHandler(this.ViewContradicated_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contraTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox patient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView contraTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button addBtn;
    }
}