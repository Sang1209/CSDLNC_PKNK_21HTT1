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
            this.addMedicine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateMedicine = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteMedicine = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PrescriptionTable
            // 
            this.PrescriptionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescriptionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedID,
            this.MedName,
            this.Quantity,
            this.Note,
            this.UpdateMedicine,
            this.DeleteMedicine});
            this.PrescriptionTable.Location = new System.Drawing.Point(28, 163);
            this.PrescriptionTable.Name = "PrescriptionTable";
            this.PrescriptionTable.Size = new System.Drawing.Size(666, 435);
            this.PrescriptionTable.TabIndex = 1;
            this.PrescriptionTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrescriptionTable_CellContentClick);
            // 
            // addMedicine
            // 
            this.addMedicine.Location = new System.Drawing.Point(307, 108);
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
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedID
            // 
            this.MedID.HeaderText = "Medicine ID";
            this.MedID.Name = "MedID";
            this.MedID.ReadOnly = true;
            // 
            // MedName
            // 
            this.MedName.HeaderText = "Medicine Name";
            this.MedName.Name = "MedName";
            this.MedName.ReadOnly = true;
            this.MedName.Width = 120;
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
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addMedicine);
            this.Controls.Add(this.PrescriptionTable);
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PrescriptionTable;
        private System.Windows.Forms.Button addMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateMedicine;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteMedicine;
    }
}