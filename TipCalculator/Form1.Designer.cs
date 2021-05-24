
namespace TipCalculator
{
    partial class Form1
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
            this.labelbill = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.labeltip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtPersons = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelbill
            // 
            this.labelbill.AutoSize = true;
            this.labelbill.Location = new System.Drawing.Point(75, 63);
            this.labelbill.Name = "labelbill";
            this.labelbill.Size = new System.Drawing.Size(26, 17);
            this.labelbill.TabIndex = 0;
            this.labelbill.Text = "Bill";
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(78, 83);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(165, 22);
            this.txtBill.TabIndex = 1;
            this.txtBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBill.TextChanged += new System.EventHandler(this.txtBill_TextChanged);
            // 
            // labeltip
            // 
            this.labeltip.AutoSize = true;
            this.labeltip.Location = new System.Drawing.Point(78, 121);
            this.labeltip.Name = "labeltip";
            this.labeltip.Size = new System.Drawing.Size(44, 17);
            this.labeltip.TabIndex = 2;
            this.labeltip.Text = "Tip %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of people";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "per person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "per person";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 22);
            this.button2.TabIndex = 11;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(99, 143);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(124, 22);
            this.txtTip.TabIndex = 12;
            this.txtTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTip.TextChanged += new System.EventHandler(this.txtTip_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 22);
            this.button3.TabIndex = 13;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(220, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 22);
            this.button5.TabIndex = 17;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtPersons
            // 
            this.txtPersons.Location = new System.Drawing.Point(99, 212);
            this.txtPersons.Name = "txtPersons";
            this.txtPersons.Size = new System.Drawing.Size(124, 22);
            this.txtPersons.TabIndex = 16;
            this.txtPersons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPersons.TextChanged += new System.EventHandler(this.txtPersons_TextChanged_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(78, 212);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 22);
            this.button6.TabIndex = 15;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtResult1
            // 
            this.txtResult1.Location = new System.Drawing.Point(436, 115);
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.ReadOnly = true;
            this.txtResult1.Size = new System.Drawing.Size(100, 22);
            this.txtResult1.TabIndex = 20;
            this.txtResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(436, 176);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.ReadOnly = true;
            this.txtResult2.Size = new System.Drawing.Size(100, 22);
            this.txtResult2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.txtResult1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtPersons);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeltip);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.labelbill);
            this.Name = "Form1";
            this.Text = "TipCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelbill;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label labeltip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtPersons;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtResult1;
        private System.Windows.Forms.TextBox txtResult2;
    }
}

