namespace QLPKNK_App
{
    partial class AddMedDep
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
            this.DepAddr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.medAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.MedCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.medAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new medicine";
            // 
            // DepAddr
            // 
            this.DepAddr.Location = new System.Drawing.Point(96, 171);
            this.DepAddr.Name = "DepAddr";
            this.DepAddr.ReadOnly = true;
            this.DepAddr.Size = new System.Drawing.Size(338, 22);
            this.DepAddr.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Medicine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Department";
            // 
            // medAmount
            // 
            this.medAmount.Location = new System.Drawing.Point(96, 238);
            this.medAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.medAmount.Name = "medAmount";
            this.medAmount.Size = new System.Drawing.Size(338, 22);
            this.medAmount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount";
            // 
            // MedCB
            // 
            this.MedCB.FormattingEnabled = true;
            this.MedCB.Location = new System.Drawing.Point(96, 106);
            this.MedCB.Name = "MedCB";
            this.MedCB.Size = new System.Drawing.Size(338, 24);
            this.MedCB.TabIndex = 10;
            // 
            // AddMedDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 354);
            this.Controls.Add(this.MedCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.medAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DepAddr);
            this.Controls.Add(this.label1);
            this.Name = "AddMedDep";
            this.Text = "AddEditMedDep";
            this.Load += new System.EventHandler(this.AddMedDep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DepAddr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown medAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MedCB;
    }
}