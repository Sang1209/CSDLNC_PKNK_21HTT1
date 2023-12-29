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
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
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
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(301, 38);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Search";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(177, 38);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(100, 22);
            this.SearchName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(570, 37);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(130, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create Profile";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // PatientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.PatientList);
            this.Name = "PatientProfile";
            this.Text = "Patient Profile";
            this.Load += new System.EventHandler(this.PatientProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientList;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
    }
}