namespace QLPKNK_App
{
    partial class ViewDentist
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
            this.DentistList = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.DentistDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameSearch = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DentistList)).BeginInit();
            this.SuspendLayout();
            // 
            // DentistList
            // 
            this.DentistList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DentistList.Location = new System.Drawing.Point(12, 82);
            this.DentistList.Name = "DentistList";
            this.DentistList.RowHeadersWidth = 51;
            this.DentistList.RowTemplate.Height = 24;
            this.DentistList.Size = new System.Drawing.Size(797, 317);
            this.DentistList.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(345, 415);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(142, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add Account";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DentistDepartment
            // 
            this.DentistDepartment.FormattingEnabled = true;
            this.DentistDepartment.Location = new System.Drawing.Point(587, 38);
            this.DentistDepartment.Name = "DentistDepartment";
            this.DentistDepartment.Size = new System.Drawing.Size(195, 24);
            this.DentistDepartment.TabIndex = 2;
            this.DentistDepartment.SelectedIndexChanged += new System.EventHandler(this.DentistDepartment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // NameSearch
            // 
            this.NameSearch.Location = new System.Drawing.Point(154, 38);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(133, 22);
            this.NameSearch.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(305, 38);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ViewDentist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DentistDepartment);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DentistList);
            this.Name = "ViewDentist";
            this.Text = "View Dentist Account";
            this.Load += new System.EventHandler(this.ViewDentist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DentistList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DentistList;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox DentistDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameSearch;
        private System.Windows.Forms.Button SearchButton;
    }
}