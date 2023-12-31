﻿namespace QLPKNK_App
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
            this.PaymentTable = new System.Windows.Forms.DataGridView();
            this.TreatmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noneyPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSearch = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1133, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Patient name";
            // 
            // searchPatient
            // 
            this.searchPatient.Location = new System.Drawing.Point(617, 108);
            this.searchPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchPatient.Name = "searchPatient";
            this.searchPatient.Size = new System.Drawing.Size(100, 28);
            this.searchPatient.TabIndex = 9;
            this.searchPatient.Text = "Search";
            this.searchPatient.UseVisualStyleBackColor = true;
            this.searchPatient.Click += new System.EventHandler(this.searchPatient_Click);
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
            this.PaymentTable.Location = new System.Drawing.Point(17, 196);
            this.PaymentTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PaymentTable.Name = "PaymentTable";
            this.PaymentTable.RowHeadersWidth = 51;
            this.PaymentTable.Size = new System.Drawing.Size(1121, 561);
            this.PaymentTable.TabIndex = 11;
            // 
            // TreatmentID
            // 
            this.TreatmentID.HeaderText = "Treatment ID";
            this.TreatmentID.MinimumWidth = 6;
            this.TreatmentID.Name = "TreatmentID";
            this.TreatmentID.ReadOnly = true;
            this.TreatmentID.Width = 125;
            // 
            // Times
            // 
            this.Times.HeaderText = "Times";
            this.Times.MinimumWidth = 6;
            this.Times.Name = "Times";
            this.Times.ReadOnly = true;
            this.Times.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // noneyPaid
            // 
            this.noneyPaid.HeaderText = "Money paid";
            this.noneyPaid.MinimumWidth = 6;
            this.noneyPaid.Name = "noneyPaid";
            this.noneyPaid.ReadOnly = true;
            this.noneyPaid.Width = 125;
            // 
            // Method
            // 
            this.Method.HeaderText = "Method";
            this.Method.MinimumWidth = 6;
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            this.Method.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // Payer
            // 
            this.Payer.HeaderText = "Payer";
            this.Payer.MinimumWidth = 6;
            this.Payer.Name = "Payer";
            this.Payer.ReadOnly = true;
            this.Payer.Width = 125;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 125;
            // 
            // patientSearch
            // 
            this.patientSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patientSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.patientSearch.FormattingEnabled = true;
            this.patientSearch.Location = new System.Drawing.Point(421, 112);
            this.patientSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientSearch.Name = "patientSearch";
            this.patientSearch.Size = new System.Drawing.Size(160, 24);
            this.patientSearch.TabIndex = 12;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(957, 37);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(123, 33);
            this.add.TabIndex = 13;
            this.add.Text = "Add Payment";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 772);
            this.Controls.Add(this.add);
            this.Controls.Add(this.patientSearch);
            this.Controls.Add(this.PaymentTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchPatient);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchPatient;
        private System.Windows.Forms.DataGridView PaymentTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreatmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Times;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn noneyPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.ComboBox patientSearch;
        private System.Windows.Forms.Button add;
    }
}