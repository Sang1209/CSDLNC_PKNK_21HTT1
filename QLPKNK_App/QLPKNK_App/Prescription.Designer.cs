namespace QLPKNK_App
{
    partial class Prescription
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
            this.PrescriptionTable = new System.Windows.Forms.DataGridView();
            this.MedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateMedicine = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteMedicine = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addMedicine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MedicineNameCB = new System.Windows.Forms.ComboBox();
            this.MedicineQuantity = new System.Windows.Forms.NumericUpDown();
            this.MedicineNote = new System.Windows.Forms.TextBox();
            this.Medicine = new System.Windows.Forms.Label();
            this.Quan = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // PrescriptionTable
            // 
            this.PrescriptionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescriptionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedID,
            this.MedicineName,
            this.Quantity,
            this.Note,
            this.UpdateMedicine,
            this.DeleteMedicine});
            this.PrescriptionTable.Location = new System.Drawing.Point(28, 163);
            this.PrescriptionTable.Name = "PrescriptionTable";
            this.PrescriptionTable.Size = new System.Drawing.Size(666, 435);
            this.PrescriptionTable.TabIndex = 1;
            // 
            // MedID
            // 
            this.MedID.HeaderText = "Medicine ID";
            this.MedID.Name = "MedID";
            this.MedID.ReadOnly = true;
            // 
            // MedicineName
            // 
            this.MedicineName.HeaderText = "Medicine Name";
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.ReadOnly = true;
            this.MedicineName.Width = 120;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // UpdateMedicine
            // 
            this.UpdateMedicine.HeaderText = "Update Medicine";
            this.UpdateMedicine.Name = "UpdateMedicine";
            this.UpdateMedicine.ReadOnly = true;
            this.UpdateMedicine.Text = "Update";
            this.UpdateMedicine.ToolTipText = "Update";
            this.UpdateMedicine.UseColumnTextForButtonValue = true;
            // 
            // DeleteMedicine
            // 
            this.DeleteMedicine.HeaderText = "Delete Medicine";
            this.DeleteMedicine.Name = "DeleteMedicine";
            this.DeleteMedicine.ReadOnly = true;
            this.DeleteMedicine.Text = "Delete";
            this.DeleteMedicine.ToolTipText = "Delete";
            this.DeleteMedicine.UseColumnTextForButtonValue = true;
            // 
            // addMedicine
            // 
            this.addMedicine.Location = new System.Drawing.Point(587, 107);
            this.addMedicine.Name = "addMedicine";
            this.addMedicine.Size = new System.Drawing.Size(107, 23);
            this.addMedicine.TabIndex = 2;
            this.addMedicine.Text = "Add medicine";
            this.addMedicine.UseVisualStyleBackColor = true;
            this.addMedicine.Click += new System.EventHandler(this.addMedicine_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(671, 30);
            this.label1.TabIndex = 3;
            // 
            // MedicineNameCB
            // 
            this.MedicineNameCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MedicineNameCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MedicineNameCB.FormattingEnabled = true;
            this.MedicineNameCB.Location = new System.Drawing.Point(28, 109);
            this.MedicineNameCB.Name = "MedicineNameCB";
            this.MedicineNameCB.Size = new System.Drawing.Size(165, 21);
            this.MedicineNameCB.TabIndex = 4;
            // 
            // MedicineQuantity
            // 
            this.MedicineQuantity.Location = new System.Drawing.Point(216, 110);
            this.MedicineQuantity.Name = "MedicineQuantity";
            this.MedicineQuantity.Size = new System.Drawing.Size(120, 20);
            this.MedicineQuantity.TabIndex = 5;
            this.MedicineQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MedicineNote
            // 
            this.MedicineNote.Location = new System.Drawing.Point(366, 109);
            this.MedicineNote.Name = "MedicineNote";
            this.MedicineNote.Size = new System.Drawing.Size(202, 20);
            this.MedicineNote.TabIndex = 6;
            // 
            // Medicine
            // 
            this.Medicine.AutoSize = true;
            this.Medicine.Location = new System.Drawing.Point(28, 90);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(50, 13);
            this.Medicine.TabIndex = 7;
            this.Medicine.Text = "Medicine";
            // 
            // Quan
            // 
            this.Quan.AutoSize = true;
            this.Quan.Location = new System.Drawing.Point(216, 90);
            this.Quan.Name = "Quan";
            this.Quan.Size = new System.Drawing.Size(46, 13);
            this.Quan.TabIndex = 8;
            this.Quan.Text = "Quantity";
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(366, 90);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(30, 13);
            this.N.TabIndex = 9;
            this.N.Text = "Note";
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 625);
            this.Controls.Add(this.N);
            this.Controls.Add(this.Quan);
            this.Controls.Add(this.Medicine);
            this.Controls.Add(this.MedicineNote);
            this.Controls.Add(this.MedicineQuantity);
            this.Controls.Add(this.MedicineNameCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addMedicine);
            this.Controls.Add(this.PrescriptionTable);
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PrescriptionTable;
        private System.Windows.Forms.Button addMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateMedicine;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteMedicine;
        private System.Windows.Forms.ComboBox MedicineNameCB;
        private System.Windows.Forms.NumericUpDown MedicineQuantity;
        private System.Windows.Forms.TextBox MedicineNote;
        private System.Windows.Forms.Label Medicine;
        private System.Windows.Forms.Label Quan;
        private System.Windows.Forms.Label N;
    }
}