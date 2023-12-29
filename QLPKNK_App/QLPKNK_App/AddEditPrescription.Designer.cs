namespace QLPKNK_App
{
    partial class AddEditPrescription
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
            this.MedicineNameCB = new System.Windows.Forms.ComboBox();
            this.MedicineQuantity = new System.Windows.Forms.NumericUpDown();
            this.MedicineNote = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updatedMedName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineNameCB
            // 
            this.MedicineNameCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MedicineNameCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MedicineNameCB.FormattingEnabled = true;
            this.MedicineNameCB.IntegralHeight = false;
            this.MedicineNameCB.Location = new System.Drawing.Point(76, 126);
            this.MedicineNameCB.Margin = new System.Windows.Forms.Padding(4);
            this.MedicineNameCB.Name = "MedicineNameCB";
            this.MedicineNameCB.Size = new System.Drawing.Size(273, 21);
            this.MedicineNameCB.Sorted = true;
            this.MedicineNameCB.TabIndex = 5;
            // 
            // MedicineQuantity
            // 
            this.MedicineQuantity.Location = new System.Drawing.Point(76, 220);
            this.MedicineQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.MedicineQuantity.Name = "MedicineQuantity";
            this.MedicineQuantity.Size = new System.Drawing.Size(273, 20);
            this.MedicineQuantity.TabIndex = 6;
            this.MedicineQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MedicineNote
            // 
            this.MedicineNote.Location = new System.Drawing.Point(76, 308);
            this.MedicineNote.Margin = new System.Windows.Forms.Padding(4);
            this.MedicineNote.Multiline = true;
            this.MedicineNote.Name = "MedicineNote";
            this.MedicineNote.Size = new System.Drawing.Size(273, 60);
            this.MedicineNote.TabIndex = 7;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(417, 64);
            this.Title.TabIndex = 9;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Medicine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Note";
            // 
            // updatedMedName
            // 
            this.updatedMedName.Location = new System.Drawing.Point(76, 127);
            this.updatedMedName.Margin = new System.Windows.Forms.Padding(4);
            this.updatedMedName.Name = "updatedMedName";
            this.updatedMedName.Size = new System.Drawing.Size(273, 20);
            this.updatedMedName.TabIndex = 13;
            this.updatedMedName.TextChanged += new System.EventHandler(this.updatedMedName_TextChanged);
            // 
            // AddEditPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 443);
            this.Controls.Add(this.updatedMedName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MedicineNote);
            this.Controls.Add(this.MedicineQuantity);
            this.Controls.Add(this.MedicineNameCB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEditPrescription";
            this.Text = "AddEditPrescription";
            this.Load += new System.EventHandler(this.AddEditPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MedicineNameCB;
        private System.Windows.Forms.NumericUpDown MedicineQuantity;
        private System.Windows.Forms.TextBox MedicineNote;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox updatedMedName;
    }
}