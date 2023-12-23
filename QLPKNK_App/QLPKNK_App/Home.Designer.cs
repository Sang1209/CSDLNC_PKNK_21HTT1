namespace QLPKNK_App
{
    partial class Home
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
            this.treatmentBtn = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Button();
            this.ScheduleBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treatmentBtn
            // 
            this.treatmentBtn.Location = new System.Drawing.Point(83, 79);
            this.treatmentBtn.Name = "treatmentBtn";
            this.treatmentBtn.Size = new System.Drawing.Size(75, 23);
            this.treatmentBtn.TabIndex = 0;
            this.treatmentBtn.Text = "Treatment";
            this.treatmentBtn.UseVisualStyleBackColor = true;
            this.treatmentBtn.Click += new System.EventHandler(this.treatmentBtn_Click);
            // 
            // Payment
            // 
            this.Payment.Location = new System.Drawing.Point(238, 79);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(75, 23);
            this.Payment.TabIndex = 1;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = true;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // ScheduleBtn
            // 
            this.ScheduleBtn.Location = new System.Drawing.Point(395, 79);
            this.ScheduleBtn.Name = "ScheduleBtn";
            this.ScheduleBtn.Size = new System.Drawing.Size(75, 23);
            this.ScheduleBtn.TabIndex = 2;
            this.ScheduleBtn.Text = "Schedule";
            this.ScheduleBtn.UseVisualStyleBackColor = true;
            this.ScheduleBtn.Click += new System.EventHandler(this.ScheduleBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(543, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Manage";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 47);
            this.label1.TabIndex = 17;
            this.label1.Text = "Home page";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ScheduleBtn);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.treatmentBtn);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button treatmentBtn;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Button ScheduleBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}