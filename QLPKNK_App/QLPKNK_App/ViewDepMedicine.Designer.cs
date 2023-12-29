namespace QLPKNK_App
{
    partial class ViewDepMedicine
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
            this.depAddr = new System.Windows.Forms.TextBox();
            this.depMedTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.MedId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.depMedTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // depAddr
            // 
            this.depAddr.Location = new System.Drawing.Point(240, 102);
            this.depAddr.Name = "depAddr";
            this.depAddr.ReadOnly = true;
            this.depAddr.Size = new System.Drawing.Size(297, 22);
            this.depAddr.TabIndex = 2;
            // 
            // depMedTable
            // 
            this.depMedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depMedTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedId,
            this.medName,
            this.remain});
            this.depMedTable.Location = new System.Drawing.Point(115, 170);
            this.depMedTable.Name = "depMedTable";
            this.depMedTable.RowHeadersWidth = 51;
            this.depMedTable.RowTemplate.Height = 24;
            this.depMedTable.Size = new System.Drawing.Size(556, 268);
            this.depMedTable.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(623, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add new medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MedId
            // 
            this.MedId.HeaderText = "Medicine ID";
            this.MedId.MinimumWidth = 6;
            this.MedId.Name = "MedId";
            this.MedId.ReadOnly = true;
            this.MedId.Width = 125;
            // 
            // medName
            // 
            this.medName.HeaderText = "Medicine name";
            this.medName.MinimumWidth = 6;
            this.medName.Name = "medName";
            this.medName.ReadOnly = true;
            this.medName.Width = 125;
            // 
            // remain
            // 
            this.remain.HeaderText = "Remain";
            this.remain.MaxInputLength = 6;
            this.remain.MinimumWidth = 6;
            this.remain.Name = "remain";
            this.remain.Width = 125;
            // 
            // ViewDepMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.depMedTable);
            this.Controls.Add(this.depAddr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewDepMedicine";
            this.Text = "ViewDepMedicine";
            this.Load += new System.EventHandler(this.ViewDepMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depMedTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depAddr;
        private System.Windows.Forms.DataGridView depMedTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedId;
        private System.Windows.Forms.DataGridViewTextBoxColumn medName;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain;
    }
}