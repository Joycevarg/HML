﻿namespace Harrison.Inventory.WinForm
{
    partial class InvoiceForm
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
            this.InvoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VendorNamecombo = new System.Windows.Forms.ComboBox();
            this.RPScombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.commcombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.commCodecombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Datetxt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FrrNotxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lpcNotxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.barrelqtytxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lumpqtytxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.emptyqtytxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.wetwttxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.drctxt = new System.Windows.Forms.TextBox();
            this.ratetxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.spotContractCombo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.calbtn = new System.Windows.Forms.Button();
            this.clrfldbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tamnttxt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cesstxt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.vattxt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.amnttxt = new System.Windows.Forms.TextBox();
            this.drywttxt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Savebtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.invoicebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No:";
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.Location = new System.Drawing.Point(124, 46);
            this.InvoiceNo.Margin = new System.Windows.Forms.Padding(4);
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Size = new System.Drawing.Size(227, 22);
            this.InvoiceNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor name:";
            // 
            // VendorNamecombo
            // 
            this.VendorNamecombo.FormattingEnabled = true;
            this.VendorNamecombo.Location = new System.Drawing.Point(124, 89);
            this.VendorNamecombo.Margin = new System.Windows.Forms.Padding(4);
            this.VendorNamecombo.Name = "VendorNamecombo";
            this.VendorNamecombo.Size = new System.Drawing.Size(343, 24);
            this.VendorNamecombo.TabIndex = 3;
            this.VendorNamecombo.Text = "<select>";
            this.VendorNamecombo.SelectedIndexChanged += new System.EventHandler(this.VendorNamecombo_SelectedIndexChanged);
            // 
            // RPScombo
            // 
            this.RPScombo.FormattingEnabled = true;
            this.RPScombo.Location = new System.Drawing.Point(593, 89);
            this.RPScombo.Margin = new System.Windows.Forms.Padding(4);
            this.RPScombo.Name = "RPScombo";
            this.RPScombo.Size = new System.Drawing.Size(357, 24);
            this.RPScombo.TabIndex = 4;
            this.RPScombo.Text = "<select>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "RPS:";
            // 
            // commcombo
            // 
            this.commcombo.FormattingEnabled = true;
            this.commcombo.Location = new System.Drawing.Point(124, 134);
            this.commcombo.Margin = new System.Windows.Forms.Padding(4);
            this.commcombo.Name = "commcombo";
            this.commcombo.Size = new System.Drawing.Size(343, 24);
            this.commcombo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Commodity:";
            // 
            // commCodecombo
            // 
            this.commCodecombo.FormattingEnabled = true;
            this.commCodecombo.Location = new System.Drawing.Point(716, 134);
            this.commCodecombo.Margin = new System.Windows.Forms.Padding(4);
            this.commCodecombo.Name = "commCodecombo";
            this.commCodecombo.Size = new System.Drawing.Size(234, 24);
            this.commCodecombo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Commodity Code:";
            // 
            // Datetxt
            // 
            this.Datetxt.CustomFormat = "2012-07-18";
            this.Datetxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Datetxt.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Datetxt.Location = new System.Drawing.Point(685, 46);
            this.Datetxt.Margin = new System.Windows.Forms.Padding(4);
            this.Datetxt.Name = "Datetxt";
            this.Datetxt.Size = new System.Drawing.Size(265, 22);
            this.Datetxt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Invoice Date:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(391, 48);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Moved Receipt";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(475, 136);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 21);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Traded";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "FRRNo:";
            // 
            // FrrNotxt
            // 
            this.FrrNotxt.Location = new System.Drawing.Point(124, 193);
            this.FrrNotxt.Margin = new System.Windows.Forms.Padding(4);
            this.FrrNotxt.Name = "FrrNotxt";
            this.FrrNotxt.Size = new System.Drawing.Size(209, 22);
            this.FrrNotxt.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "LPC:";
            // 
            // lpcNotxt
            // 
            this.lpcNotxt.Location = new System.Drawing.Point(475, 193);
            this.lpcNotxt.Margin = new System.Windows.Forms.Padding(4);
            this.lpcNotxt.Name = "lpcNotxt";
            this.lpcNotxt.Size = new System.Drawing.Size(156, 22);
            this.lpcNotxt.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(723, 195);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "VFA:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(769, 192);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 22);
            this.textBox4.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Barrel Qty:";
            // 
            // barrelqtytxt
            // 
            this.barrelqtytxt.Location = new System.Drawing.Point(107, 22);
            this.barrelqtytxt.Margin = new System.Windows.Forms.Padding(4);
            this.barrelqtytxt.Name = "barrelqtytxt";
            this.barrelqtytxt.Size = new System.Drawing.Size(132, 22);
            this.barrelqtytxt.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "LumbQty:";
            // 
            // lumpqtytxt
            // 
            this.lumpqtytxt.Location = new System.Drawing.Point(396, 25);
            this.lumpqtytxt.Margin = new System.Windows.Forms.Padding(4);
            this.lumpqtytxt.Name = "lumpqtytxt";
            this.lumpqtytxt.Size = new System.Drawing.Size(132, 22);
            this.lumpqtytxt.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(647, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Empty Qty:";
            // 
            // emptyqtytxt
            // 
            this.emptyqtytxt.Location = new System.Drawing.Point(732, 25);
            this.emptyqtytxt.Margin = new System.Windows.Forms.Padding(4);
            this.emptyqtytxt.Name = "emptyqtytxt";
            this.emptyqtytxt.Size = new System.Drawing.Size(132, 22);
            this.emptyqtytxt.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 353);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Wet Weight:";
            // 
            // wetwttxt
            // 
            this.wetwttxt.Location = new System.Drawing.Point(136, 350);
            this.wetwttxt.Margin = new System.Windows.Forms.Padding(4);
            this.wetwttxt.Name = "wetwttxt";
            this.wetwttxt.Size = new System.Drawing.Size(160, 22);
            this.wetwttxt.TabIndex = 22;
            this.wetwttxt.TextChanged += new System.EventHandler(this.wetwttxt_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(333, 353);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "DRC (in %):";
            // 
            // drctxt
            // 
            this.drctxt.Location = new System.Drawing.Point(423, 350);
            this.drctxt.Margin = new System.Windows.Forms.Padding(4);
            this.drctxt.Name = "drctxt";
            this.drctxt.Size = new System.Drawing.Size(132, 22);
            this.drctxt.TabIndex = 24;
            this.drctxt.TextChanged += new System.EventHandler(this.drctxt_TextChanged);
            // 
            // ratetxt
            // 
            this.ratetxt.Location = new System.Drawing.Point(749, 346);
            this.ratetxt.Margin = new System.Windows.Forms.Padding(4);
            this.ratetxt.Name = "ratetxt";
            this.ratetxt.Size = new System.Drawing.Size(201, 22);
            this.ratetxt.TabIndex = 25;
            this.ratetxt.TextChanged += new System.EventHandler(this.ratetxt_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(629, 353);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Rate per Kg:";
            // 
            // spotContractCombo
            // 
            this.spotContractCombo.FormattingEnabled = true;
            this.spotContractCombo.Location = new System.Drawing.Point(136, 396);
            this.spotContractCombo.Margin = new System.Windows.Forms.Padding(4);
            this.spotContractCombo.Name = "spotContractCombo";
            this.spotContractCombo.Size = new System.Drawing.Size(160, 24);
            this.spotContractCombo.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 400);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Spot/Contract:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(348, 400);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "Code No:";
            // 
            // codetxt
            // 
            this.codetxt.Location = new System.Drawing.Point(423, 399);
            this.codetxt.Margin = new System.Windows.Forms.Padding(4);
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(132, 22);
            this.codetxt.TabIndex = 30;
            // 
            // calbtn
            // 
            this.calbtn.Location = new System.Drawing.Point(852, 396);
            this.calbtn.Margin = new System.Windows.Forms.Padding(4);
            this.calbtn.Name = "calbtn";
            this.calbtn.Size = new System.Drawing.Size(100, 28);
            this.calbtn.TabIndex = 31;
            this.calbtn.Text = "Calculate";
            this.calbtn.UseVisualStyleBackColor = true;
            // 
            // clrfldbtn
            // 
            this.clrfldbtn.Location = new System.Drawing.Point(744, 398);
            this.clrfldbtn.Margin = new System.Windows.Forms.Padding(4);
            this.clrfldbtn.Name = "clrfldbtn";
            this.clrfldbtn.Size = new System.Drawing.Size(100, 28);
            this.clrfldbtn.TabIndex = 32;
            this.clrfldbtn.Text = "Clear Fields";
            this.clrfldbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tamnttxt);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.cesstxt);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.vattxt);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.amnttxt);
            this.panel1.Controls.Add(this.drywttxt);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(17, 446);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 123);
            this.panel1.TabIndex = 33;
            // 
            // tamnttxt
            // 
            this.tamnttxt.Location = new System.Drawing.Point(279, 69);
            this.tamnttxt.Margin = new System.Windows.Forms.Padding(4);
            this.tamnttxt.Name = "tamnttxt";
            this.tamnttxt.Size = new System.Drawing.Size(417, 22);
            this.tamnttxt.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(159, 73);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 17);
            this.label22.TabIndex = 8;
            this.label22.Text = "Total Amount:";
            // 
            // cesstxt
            // 
            this.cesstxt.Location = new System.Drawing.Point(789, 24);
            this.cesstxt.Margin = new System.Windows.Forms.Padding(4);
            this.cesstxt.Name = "cesstxt";
            this.cesstxt.Size = new System.Drawing.Size(132, 22);
            this.cesstxt.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(738, 27);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 17);
            this.label21.TabIndex = 6;
            this.label21.Text = "Cess:";
            // 
            // vattxt
            // 
            this.vattxt.Location = new System.Drawing.Point(568, 24);
            this.vattxt.Margin = new System.Windows.Forms.Padding(4);
            this.vattxt.Name = "vattxt";
            this.vattxt.Size = new System.Drawing.Size(132, 22);
            this.vattxt.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(518, 27);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 17);
            this.label20.TabIndex = 4;
            this.label20.Text = "VAT:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(287, 27);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 17);
            this.label19.TabIndex = 3;
            this.label19.Text = "Amount:";
            // 
            // amnttxt
            // 
            this.amnttxt.Location = new System.Drawing.Point(355, 24);
            this.amnttxt.Margin = new System.Windows.Forms.Padding(4);
            this.amnttxt.Name = "amnttxt";
            this.amnttxt.Size = new System.Drawing.Size(132, 22);
            this.amnttxt.TabIndex = 2;
            // 
            // drywttxt
            // 
            this.drywttxt.Location = new System.Drawing.Point(119, 24);
            this.drywttxt.Margin = new System.Windows.Forms.Padding(4);
            this.drywttxt.Name = "drywttxt";
            this.drywttxt.Size = new System.Drawing.Size(132, 22);
            this.drywttxt.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 27);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Dry Weight Qty:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.emptyqtytxt);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.barrelqtytxt);
            this.panel2.Controls.Add(this.lumpqtytxt);
            this.panel2.Location = new System.Drawing.Point(17, 236);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 81);
            this.panel2.TabIndex = 34;
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(497, 582);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(100, 28);
            this.Savebtn.TabIndex = 35;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(607, 581);
            this.closebtn.Margin = new System.Windows.Forms.Padding(4);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(100, 28);
            this.closebtn.TabIndex = 36;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // invoicebtn
            // 
            this.invoicebtn.Location = new System.Drawing.Point(103, 584);
            this.invoicebtn.Name = "invoicebtn";
            this.invoicebtn.Size = new System.Drawing.Size(125, 41);
            this.invoicebtn.TabIndex = 37;
            this.invoicebtn.Text = "View Invoice";
            this.invoicebtn.UseVisualStyleBackColor = true;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 637);
            this.Controls.Add(this.invoicebtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clrfldbtn);
            this.Controls.Add(this.calbtn);
            this.Controls.Add(this.codetxt);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.spotContractCombo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ratetxt);
            this.Controls.Add(this.drctxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.wetwttxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lpcNotxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FrrNotxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Datetxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.commCodecombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.commcombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RPScombo);
            this.Controls.Add(this.VendorNamecombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InvoiceNo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VendorNamecombo;
        private System.Windows.Forms.ComboBox RPScombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox commcombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox commCodecombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Datetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FrrNotxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lpcNotxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox emptyqtytxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox lumpqtytxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox barrelqtytxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox wetwttxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox drctxt;
        private System.Windows.Forms.TextBox ratetxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox spotContractCombo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox codetxt;
        private System.Windows.Forms.Button calbtn;
        private System.Windows.Forms.Button clrfldbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tamnttxt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox cesstxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox vattxt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox amnttxt;
        private System.Windows.Forms.TextBox drywttxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button invoicebtn;
    }
}