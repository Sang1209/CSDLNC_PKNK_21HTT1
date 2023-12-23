namespace QLPKNK_App
{
    partial class PatientProfile
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
            this.PatientList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientList
            // 
            this.PatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientList.Location = new System.Drawing.Point(12, 90);
            this.PatientList.Name = "PatientList";
            this.PatientList.RowHeadersWidth = 51;
            this.PatientList.RowTemplate.Height = 24;
            this.PatientList.Size = new System.Drawing.Size(776, 348);
            this.PatientList.TabIndex = 0;
            this.PatientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientList_CellContentClick);
            // 
            // PatientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PatientList);
            this.Name = "PatientProfile";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PatientProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientList;
    }
}