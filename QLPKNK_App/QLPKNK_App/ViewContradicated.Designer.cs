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
            this.PatientCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contraTable = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contraTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(944, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraindicated list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientCB
            // 
            this.PatientCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PatientCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PatientCB.FormattingEnabled = true;
            this.PatientCB.Location = new System.Drawing.Point(323, 190);
            this.PatientCB.Margin = new System.Windows.Forms.Padding(4);
            this.PatientCB.Name = "PatientCB";
            this.PatientCB.Size = new System.Drawing.Size(337, 24);
            this.PatientCB.TabIndex = 1;
            this.PatientCB.SelectedIndexChanged += new System.EventHandler(this.PatientCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
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
            this.UpdateBtn,
            this.Delete});
            this.contraTable.Location = new System.Drawing.Point(57, 300);
            this.contraTable.Margin = new System.Windows.Forms.Padding(4);
            this.contraTable.Name = "contraTable";
            this.contraTable.RowHeadersWidth = 51;
            this.contraTable.Size = new System.Drawing.Size(873, 383);
            this.contraTable.TabIndex = 3;
            this.contraTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contraTable_CellContentClick);
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
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Width = 125;
            // 
            // MedicineID
            // 
            this.MedicineID.HeaderText = "Medicine ID";
            this.MedicineID.MinimumWidth = 6;
            this.MedicineID.Name = "MedicineID";
            this.MedicineID.ReadOnly = true;
            this.MedicineID.Width = 125;
            // 
            // MedicineName
            // 
            this.MedicineName.HeaderText = "Medicine Name";
            this.MedicineName.MinimumWidth = 6;
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.ReadOnly = true;
            this.MedicineName.Width = 125;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.HeaderText = "Update";
            this.UpdateBtn.MinimumWidth = 6;
            this.UpdateBtn.Name = "Update";
            this.UpdateBtn.ReadOnly = true;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.ToolTipText = "Update";
            this.UpdateBtn.UseColumnTextForButtonValue = true;
            this.UpdateBtn.Width = 125;
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
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(831, 79);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 28);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add contradicated";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ViewContradicated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 740);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.contraTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatientCB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewContradicated";
            this.Text = "ViewContradicated";
            this.Load += new System.EventHandler(this.Contradicated_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contraTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PatientCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView contraTable;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateBtn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}