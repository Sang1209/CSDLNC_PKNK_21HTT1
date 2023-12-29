namespace QLPKNK_App
{
    partial class AddContradicated
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
            this.PatientCB = new System.Windows.Forms.ComboBox();
            this.MedicineCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicine";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PatientCB
            // 
            this.PatientCB.FormattingEnabled = true;
            this.PatientCB.Location = new System.Drawing.Point(138, 201);
            this.PatientCB.Name = "PatientCB";
            this.PatientCB.Size = new System.Drawing.Size(121, 24);
            this.PatientCB.TabIndex = 2;
            this.PatientCB.SelectedIndexChanged += new System.EventHandler(this.PatientCB_SelectedIndexChanged);
            // 
            // MedicineCB
            // 
            this.MedicineCB.FormattingEnabled = true;
            this.MedicineCB.Location = new System.Drawing.Point(348, 201);
            this.MedicineCB.Name = "MedicineCB";
            this.MedicineCB.Size = new System.Drawing.Size(121, 24);
            this.MedicineCB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label3.Location = new System.Drawing.Point(261, 20);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(263, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Contradicated";
            // 
            // AddContradicated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MedicineCB);
            this.Controls.Add(this.PatientCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddContradicated";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PatientCB;
        private System.Windows.Forms.ComboBox MedicineCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}