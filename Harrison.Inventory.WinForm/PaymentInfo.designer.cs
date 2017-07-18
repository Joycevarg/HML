namespace Harrison.Inventory.WinForm
{
    partial class PaymentInfoForm
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
            this.paymentdatetxt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotAmntPaidtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Balancetxt = new System.Windows.Forms.TextBox();
            this.Remarktxt = new System.Windows.Forms.TextBox();
            this.PaymentModeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.donebtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.HOtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OtherDebittxt = new System.Windows.Forms.TextBox();
            this.InvNoCombo = new System.Windows.Forms.ComboBox();
            this.TotaltoPaytxt = new System.Windows.Forms.TextBox();
            this.VendorNametxt = new System.Windows.Forms.TextBox();
            this.gridbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paidDatelbl
            // 
            this.paidDatelbl.AutoSize = true;
            this.paidDatelbl.Location = new System.Drawing.Point(105, 131);
            this.paidDatelbl.Name = "paidDatelbl";
            this.paidDatelbl.Size = new System.Drawing.Size(74, 17);
            this.paidDatelbl.TabIndex = 0;
            this.paidDatelbl.Text = "Paid Date:";
            // 
            // paymentdatetxt
            // 
            this.paymentdatetxt.Location = new System.Drawing.Point(185, 126);
            this.paymentdatetxt.Name = "paymentdatetxt";
            this.paymentdatetxt.Size = new System.Drawing.Size(200, 22);
            this.paymentdatetxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = " Total Amount to be paid:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Amount Paid:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Payment Mode:";
            // 
            // TotAmntPaidtxt
            // 
            this.TotAmntPaidtxt.Location = new System.Drawing.Point(185, 264);
            this.TotAmntPaidtxt.Name = "TotAmntPaidtxt";
            this.TotAmntPaidtxt.ReadOnly = true;
            this.TotAmntPaidtxt.Size = new System.Drawing.Size(172, 22);
            this.TotAmntPaidtxt.TabIndex = 10;
            this.TotAmntPaidtxt.TextChanged += new System.EventHandler(this.TotAmntPaidtxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Balance:";
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
            // Balancetxt
            // 
            this.Balancetxt.BackColor = System.Drawing.Color.GhostWhite;
            this.Balancetxt.Location = new System.Drawing.Point(185, 298);
            this.Balancetxt.Name = "Balancetxt";
            this.Balancetxt.ReadOnly = true;
            this.Balancetxt.Size = new System.Drawing.Size(172, 22);
            this.Balancetxt.TabIndex = 15;
            // 
            // Remarktxt
            // 
            this.Remarktxt.Location = new System.Drawing.Point(185, 344);
            this.Remarktxt.Multiline = true;
            this.Remarktxt.Name = "Remarktxt";
            this.Remarktxt.Size = new System.Drawing.Size(479, 67);
            this.Remarktxt.TabIndex = 16;
            // 
            // PaymentModeCombo
            // 
            this.PaymentModeCombo.FormattingEnabled = true;
            this.PaymentModeCombo.Location = new System.Drawing.Point(519, 261);
            this.PaymentModeCombo.Name = "PaymentModeCombo";
            this.PaymentModeCombo.Size = new System.Drawing.Size(245, 24);
            this.PaymentModeCombo.TabIndex = 21;
            this.PaymentModeCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
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
            // donebtn
            // 
            this.donebtn.Location = new System.Drawing.Point(232, 439);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(125, 35);
            this.donebtn.TabIndex = 24;
            this.donebtn.Text = "Save";
            this.donebtn.UseVisualStyleBackColor = true;
            this.donebtn.Click += new System.EventHandler(this.donebtn_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.Location = new System.Drawing.Point(424, 439);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(119, 35);
            this.clrbtn.TabIndex = 25;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(600, 439);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(122, 35);
            this.cancelbtn.TabIndex = 26;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "From HO:";
            // 
            // HOtxt
            // 
            this.HOtxt.Location = new System.Drawing.Point(185, 219);
            this.HOtxt.Name = "HOtxt";
            this.HOtxt.Size = new System.Drawing.Size(172, 22);
            this.HOtxt.TabIndex = 28;
            this.HOtxt.TextChanged += new System.EventHandler(this.HOtxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Other Debits:";
            // 
            // OtherDebittxt
            // 
            this.OtherDebittxt.Location = new System.Drawing.Point(519, 219);
            this.OtherDebittxt.Name = "OtherDebittxt";
            this.OtherDebittxt.Size = new System.Drawing.Size(245, 22);
            this.OtherDebittxt.TabIndex = 30;
            this.OtherDebittxt.TextChanged += new System.EventHandler(this.OtherDebittxt_TextChanged);
            // 
            // InvNoCombo
            // 
            this.InvNoCombo.FormattingEnabled = true;
            this.InvNoCombo.Location = new System.Drawing.Point(185, 31);
            this.InvNoCombo.Name = "InvNoCombo";
            this.InvNoCombo.Size = new System.Drawing.Size(200, 24);
            this.InvNoCombo.TabIndex = 32;
            // 
            // TotaltoPaytxt
            // 
            this.TotaltoPaytxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotaltoPaytxt.Location = new System.Drawing.Point(185, 181);
            this.TotaltoPaytxt.Name = "TotaltoPaytxt";
            this.TotaltoPaytxt.ReadOnly = true;
            this.TotaltoPaytxt.Size = new System.Drawing.Size(172, 22);
            this.TotaltoPaytxt.TabIndex = 33;
            // 
            // VendorNametxt
            // 
            this.VendorNametxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VendorNametxt.Location = new System.Drawing.Point(185, 76);
            this.VendorNametxt.Name = "VendorNametxt";
            this.VendorNametxt.ReadOnly = true;
            this.VendorNametxt.Size = new System.Drawing.Size(200, 22);
            this.VendorNametxt.TabIndex = 34;
            // 
            // gridbtn
            // 
            this.gridbtn.Location = new System.Drawing.Point(55, 440);
            this.gridbtn.Name = "gridbtn";
            this.gridbtn.Size = new System.Drawing.Size(124, 34);
            this.gridbtn.TabIndex = 35;
            this.gridbtn.Text = "View Grid";
            this.gridbtn.UseVisualStyleBackColor = true;
            this.gridbtn.Click += new System.EventHandler(this.gridbtn_Click);
            // 
            // PaymentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 507);
            this.Controls.Add(this.gridbtn);
            this.Controls.Add(this.VendorNametxt);
            this.Controls.Add(this.TotaltoPaytxt);
            this.Controls.Add(this.InvNoCombo);
            this.Controls.Add(this.OtherDebittxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HOtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaymentModeCombo);
            this.Controls.Add(this.Remarktxt);
            this.Controls.Add(this.Balancetxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotAmntPaidtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paymentdatetxt);
            this.Controls.Add(this.paidDatelbl);
            this.Name = "PaymentInfoForm";
            this.Text = "Payment Details";
            this.Load += new System.EventHandler(this.paymentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paidDatelbl;
        private System.Windows.Forms.DateTimePicker paymentdatetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotAmntPaidtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Balancetxt;
        private System.Windows.Forms.TextBox Remarktxt;
        private System.Windows.Forms.ComboBox PaymentModeCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HOtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OtherDebittxt;
        private System.Windows.Forms.TextBox TotaltoPaytxt;
        private System.Windows.Forms.TextBox VendorNametxt;
        private System.Windows.Forms.Button gridbtn;
        private System.Windows.Forms.ComboBox InvNoCombo;
    }
}