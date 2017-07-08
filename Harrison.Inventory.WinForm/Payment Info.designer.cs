namespace Harrison.Inventory.WinForm
{
    partial class paymentInfo
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
            this.paidDatelbl = new System.Windows.Forms.Label();
            this.invoicedatetxt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.namecombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.paidFromlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.previousDuelbl = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.invoicenotxt = new System.Windows.Forms.Label();
            this.donebtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paidDatelbl
            // 
            this.paidDatelbl.AutoSize = true;
            this.paidDatelbl.Location = new System.Drawing.Point(105, 81);
            this.paidDatelbl.Name = "paidDatelbl";
            this.paidDatelbl.Size = new System.Drawing.Size(74, 17);
            this.paidDatelbl.TabIndex = 0;
            this.paidDatelbl.Text = "Paid Date:";
            // 
            // invoicedatetxt
            // 
            this.invoicedatetxt.Location = new System.Drawing.Point(196, 76);
            this.invoicedatetxt.Name = "invoicedatetxt";
            this.invoicedatetxt.Size = new System.Drawing.Size(200, 22);
            this.invoicedatetxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor Name:";
            // 
            // namecombo
            // 
            this.namecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.namecombo.FormattingEnabled = true;
            this.namecombo.Location = new System.Drawing.Point(196, 121);
            this.namecombo.Name = "namecombo";
            this.namecombo.Size = new System.Drawing.Size(257, 24);
            this.namecombo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = " Total Amount to be paid:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(196, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // paidFromlbl
            // 
            this.paidFromlbl.AutoSize = true;
            this.paidFromlbl.Location = new System.Drawing.Point(424, 215);
            this.paidFromlbl.Name = "paidFromlbl";
            this.paidFromlbl.Size = new System.Drawing.Size(76, 17);
            this.paidFromlbl.TabIndex = 6;
            this.paidFromlbl.Text = "Paid From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Amount Paid:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Payment Mode:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(196, 256);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Due:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Remarks:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(196, 298);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 22);
            this.textBox5.TabIndex = 15;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(185, 344);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(479, 67);
            this.textBox6.TabIndex = 16;
            // 
            // previousDuelbl
            // 
            this.previousDuelbl.AutoSize = true;
            this.previousDuelbl.Location = new System.Drawing.Point(82, 171);
            this.previousDuelbl.Name = "previousDuelbl";
            this.previousDuelbl.Size = new System.Drawing.Size(97, 17);
            this.previousDuelbl.TabIndex = 18;
            this.previousDuelbl.Text = "Previous Due:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(196, 171);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(172, 22);
            this.textBox8.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(519, 212);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(245, 24);
            this.comboBox2.TabIndex = 20;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(519, 261);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(245, 24);
            this.comboBox3.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Invoice no:";
            // 
            // invoicenotxt
            // 
            this.invoicenotxt.AutoSize = true;
            this.invoicenotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicenotxt.Location = new System.Drawing.Point(193, 34);
            this.invoicenotxt.Name = "invoicenotxt";
            this.invoicenotxt.Size = new System.Drawing.Size(53, 20);
            this.invoicenotxt.TabIndex = 23;
            this.invoicenotxt.Text = "label4";
            // 
            // donebtn
            // 
            this.donebtn.Location = new System.Drawing.Point(185, 439);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(125, 23);
            this.donebtn.TabIndex = 24;
            this.donebtn.Text = "Save";
            this.donebtn.UseVisualStyleBackColor = true;
            // 
            // clrbtn
            // 
            this.clrbtn.Location = new System.Drawing.Point(397, 439);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(119, 23);
            this.clrbtn.TabIndex = 25;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(600, 439);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(122, 23);
            this.cancelbtn.TabIndex = 26;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // paymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 507);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.invoicenotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.previousDuelbl);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paidFromlbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namecombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invoicedatetxt);
            this.Controls.Add(this.paidDatelbl);
            this.Name = "paymentInfo";
            this.Text = "Payment Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paidDatelbl;
        private System.Windows.Forms.DateTimePicker invoicedatetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox namecombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label paidFromlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label previousDuelbl;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label invoicenotxt;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}