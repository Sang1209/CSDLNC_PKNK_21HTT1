namespace QLPKNK_App
{
    partial class ViewStaff_Admin
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
            this.NameSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffRole = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.StaffList = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // NameSearch
            // 
            this.NameSearch.Location = new System.Drawing.Point(144, 25);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(133, 22);
            this.NameSearch.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Role";
            // 
            // StaffRole
            // 
            this.StaffRole.FormattingEnabled = true;
            this.StaffRole.Items.AddRange(new object[] {
            "All",
            "Staff",
            "Admin"});
            this.StaffRole.Location = new System.Drawing.Point(577, 25);
            this.StaffRole.Name = "StaffRole";
            this.StaffRole.Size = new System.Drawing.Size(100, 24);
            this.StaffRole.TabIndex = 9;
            this.StaffRole.SelectedIndexChanged += new System.EventHandler(this.StaffRole_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(335, 402);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(142, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Account";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // StaffList
            // 
            this.StaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffList.Location = new System.Drawing.Point(2, 69);
            this.StaffList.Name = "StaffList";
            this.StaffList.RowHeadersWidth = 51;
            this.StaffList.RowTemplate.Height = 24;
            this.StaffList.Size = new System.Drawing.Size(797, 317);
            this.StaffList.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(311, 23);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ViewStaff_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StaffRole);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StaffList);
            this.Name = "ViewStaff_Admin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewStaff_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StaffRole;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView StaffList;
        private System.Windows.Forms.Button SearchButton;
    }
}