﻿namespace QLPKNK_App
{
    partial class EditMedicine
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
            this.Edit = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.Label();
            this.NewPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.op = new System.Windows.Forms.TextBox();
            this.on = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(309, 211);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 0;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(285, 65);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 1;
            this.Id.Text = "Id";
            // 
            // NewName
            // 
            this.NewName.AutoSize = true;
            this.NewName.Location = new System.Drawing.Point(427, 108);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(57, 13);
            this.NewName.TabIndex = 1;
            this.NewName.Text = "NewName";
            // 
            // NewPrice
            // 
            this.NewPrice.AutoSize = true;
            this.NewPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.NewPrice.Location = new System.Drawing.Point(427, 157);
            this.NewPrice.Name = "NewPrice";
            this.NewPrice.Size = new System.Drawing.Size(53, 13);
            this.NewPrice.TabIndex = 1;
            this.NewPrice.Text = "NewPrice";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(490, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(490, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // op
            // 
            this.op.Location = new System.Drawing.Point(201, 150);
            this.op.Name = "op";
            this.op.ReadOnly = true;
            this.op.Size = new System.Drawing.Size(100, 20);
            this.op.TabIndex = 5;
            this.op.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // on
            // 
            this.on.Location = new System.Drawing.Point(201, 105);
            this.on.Name = "on";
            this.on.ReadOnly = true;
            this.on.Size = new System.Drawing.Size(100, 20);
            this.on.TabIndex = 6;
            this.on.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(138, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Old Price";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Old Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EditMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.op);
            this.Controls.Add(this.on);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NewPrice);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Edit);
            this.Name = "EditMedicine";
            this.Text = "EditMedicine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label NewName;
        private System.Windows.Forms.Label NewPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox op;
        private System.Windows.Forms.TextBox on;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}