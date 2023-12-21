namespace QLPKNK_App
{
    partial class Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.searchPatient = new System.Windows.Forms.Button();
            this.patientIDSearch = new System.Windows.Forms.NumericUpDown();
            this.PaymentTable = new System.Windows.Forms.DataGridView();
            this.TreatmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noneyPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patientIDSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Patient ID";
            // 
            // searchPatient
            // 
            this.searchPatient.Location = new System.Drawing.Point(463, 88);
            this.searchPatient.Name = "searchPatient";
            this.searchPatient.Size = new System.Drawing.Size(75, 23);
            this.searchPatient.TabIndex = 9;
            this.searchPatient.Text = "Search";
            this.searchPatient.UseVisualStyleBackColor = true;
            this.searchPatient.Click += new System.EventHandler(this.searchPatient_Click);
            // 
            // patientIDSearch
            // 
            this.patientIDSearch.Location = new System.Drawing.Point(316, 91);
            this.patientIDSearch.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.patientIDSearch.Name = "patientIDSearch";
            this.patientIDSearch.Size = new System.Drawing.Size(120, 20);
            this.patientIDSearch.TabIndex = 8;
            // 
            // PaymentTable
            // 
            this.PaymentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TreatmentID,
            this.Times,
            this.Total,
            this.noneyPaid,
            this.Method,
            this.date,
            this.Payer,
            this.Note});
            this.PaymentTable.Location = new System.Drawing.Point(13, 159);
            this.PaymentTable.Name = "PaymentTable";
            this.PaymentTable.Size = new System.Drawing.Size(841, 456);
            this.PaymentTable.TabIndex = 11;
            // 
            // TreatmentID
            // 
            this.TreatmentID.HeaderText = "Treatment ID";
            this.TreatmentID.Name = "TreatmentID";
            this.TreatmentID.ReadOnly = true;
            // 
            // Times
            // 
            this.Times.HeaderText = "Times";
            this.Times.Name = "Times";
            this.Times.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // noneyPaid
            // 
            this.noneyPaid.HeaderText = "Money paid";
            this.noneyPaid.Name = "noneyPaid";
            this.noneyPaid.ReadOnly = true;
            // 
            // Method
            // 
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Payer
            // 
            this.Payer.HeaderText = "Payer";
            this.Payer.Name = "Payer";
            this.Payer.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 627);
            this.Controls.Add(this.PaymentTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchPatient);
            this.Controls.Add(this.patientIDSearch);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.patientIDSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchPatient;
        private System.Windows.Forms.NumericUpDown patientIDSearch;
        private System.Windows.Forms.DataGridView PaymentTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreatmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Times;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn noneyPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}