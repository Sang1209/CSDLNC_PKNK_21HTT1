namespace QLPKNK_App
{
    partial class AddPayment
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
            this.TreatmentCB = new System.Windows.Forms.ComboBox();
            this.MethodCB = new System.Windows.Forms.ComboBox();
            this.datePayment = new System.Windows.Forms.DateTimePicker();
            this.Payer = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.moneyPayment = new System.Windows.Forms.NumericUpDown();
            this.changePayment = new System.Windows.Forms.NumericUpDown();
            this.notePayment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePayment)).BeginInit();
            this.SuspendLayout();
            // 
            // TreatmentCB
            // 
            this.TreatmentCB.FormattingEnabled = true;
            this.TreatmentCB.Location = new System.Drawing.Point(129, 112);
            this.TreatmentCB.Name = "TreatmentCB";
            this.TreatmentCB.Size = new System.Drawing.Size(185, 24);
            this.TreatmentCB.TabIndex = 0;
            this.TreatmentCB.SelectedIndexChanged += new System.EventHandler(this.TreatmentCB_SelectedIndexChanged);
            // 
            // MethodCB
            // 
            this.MethodCB.FormattingEnabled = true;
            this.MethodCB.Location = new System.Drawing.Point(129, 163);
            this.MethodCB.Name = "MethodCB";
            this.MethodCB.Size = new System.Drawing.Size(185, 24);
            this.MethodCB.TabIndex = 1;
            // 
            // datePayment
            // 
            this.datePayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePayment.Location = new System.Drawing.Point(126, 323);
            this.datePayment.Name = "datePayment";
            this.datePayment.Size = new System.Drawing.Size(188, 22);
            this.datePayment.TabIndex = 4;
            // 
            // Payer
            // 
            this.Payer.Location = new System.Drawing.Point(447, 113);
            this.Payer.Name = "Payer";
            this.Payer.Size = new System.Drawing.Size(100, 22);
            this.Payer.TabIndex = 5;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(447, 325);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 7;
            this.add.Text = "OK";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Treatment No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Money";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Change";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Payer";
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Location = new System.Drawing.Point(447, 141);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(36, 16);
            this.Note.TabIndex = 14;
            this.Note.Text = "Note";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label7.Location = new System.Drawing.Point(248, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 36);
            this.label7.TabIndex = 15;
            this.label7.Text = "Add Payment";
            // 
            // moneyPayment
            // 
            this.moneyPayment.DecimalPlaces = 3;
            this.moneyPayment.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.moneyPayment.Location = new System.Drawing.Point(129, 213);
            this.moneyPayment.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.moneyPayment.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.moneyPayment.Name = "moneyPayment";
            this.moneyPayment.Size = new System.Drawing.Size(185, 22);
            this.moneyPayment.TabIndex = 16;
            this.moneyPayment.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // changePayment
            // 
            this.changePayment.DecimalPlaces = 3;
            this.changePayment.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.changePayment.Location = new System.Drawing.Point(129, 264);
            this.changePayment.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.changePayment.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.changePayment.Name = "changePayment";
            this.changePayment.Size = new System.Drawing.Size(185, 22);
            this.changePayment.TabIndex = 17;
            this.changePayment.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // notePayment
            // 
            this.notePayment.Location = new System.Drawing.Point(447, 164);
            this.notePayment.Multiline = true;
            this.notePayment.Name = "notePayment";
            this.notePayment.Size = new System.Drawing.Size(231, 122);
            this.notePayment.TabIndex = 18;
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 459);
            this.Controls.Add(this.notePayment);
            this.Controls.Add(this.changePayment);
            this.Controls.Add(this.moneyPayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Payer);
            this.Controls.Add(this.datePayment);
            this.Controls.Add(this.MethodCB);
            this.Controls.Add(this.TreatmentCB);
            this.Name = "AddPayment";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.moneyPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TreatmentCB;
        private System.Windows.Forms.ComboBox MethodCB;
        private System.Windows.Forms.DateTimePicker datePayment;
        private System.Windows.Forms.TextBox Payer;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown moneyPayment;
        private System.Windows.Forms.NumericUpDown changePayment;
        private System.Windows.Forms.TextBox notePayment;
    }
}