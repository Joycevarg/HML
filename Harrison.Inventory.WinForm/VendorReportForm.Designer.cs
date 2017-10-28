namespace Harrison.Inventory.WinForm
{
    partial class VendorReportForm
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
            this.FromDatetxt = new System.Windows.Forms.DateTimePicker();
            this.ToDatetxt = new System.Windows.Forms.DateTimePicker();
            this.AllDateschkbox = new System.Windows.Forms.CheckBox();
            this.Generbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VendorNameCombo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FromDatetxt
            // 
            this.FromDatetxt.Location = new System.Drawing.Point(102, 19);
            this.FromDatetxt.Name = "FromDatetxt";
            this.FromDatetxt.Size = new System.Drawing.Size(243, 22);
            this.FromDatetxt.TabIndex = 2;
            // 
            // ToDatetxt
            // 
            this.ToDatetxt.Location = new System.Drawing.Point(102, 56);
            this.ToDatetxt.Name = "ToDatetxt";
            this.ToDatetxt.Size = new System.Drawing.Size(243, 22);
            this.ToDatetxt.TabIndex = 3;
            // 
            // AllDateschkbox
            // 
            this.AllDateschkbox.AutoSize = true;
            this.AllDateschkbox.Location = new System.Drawing.Point(374, 44);
            this.AllDateschkbox.Name = "AllDateschkbox";
            this.AllDateschkbox.Size = new System.Drawing.Size(111, 21);
            this.AllDateschkbox.TabIndex = 4;
            this.AllDateschkbox.Text = "All Payments";
            this.AllDateschkbox.UseVisualStyleBackColor = true;
            this.AllDateschkbox.CheckedChanged += new System.EventHandler(this.AllDateschkbox_CheckedChanged);
            // 
            // Generbtn
            // 
            this.Generbtn.Location = new System.Drawing.Point(49, 194);
            this.Generbtn.Name = "Generbtn";
            this.Generbtn.Size = new System.Drawing.Size(155, 35);
            this.Generbtn.TabIndex = 4;
            this.Generbtn.Text = "Generate Report";
            this.Generbtn.UseVisualStyleBackColor = true;
            this.Generbtn.Click += new System.EventHandler(this.Generbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(333, 194);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(137, 35);
            this.Cancelbtn.TabIndex = 5;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vendor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Generate Reports";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FromDatetxt);
            this.panel1.Controls.Add(this.AllDateschkbox);
            this.panel1.Controls.Add(this.ToDatetxt);
            this.panel1.Location = new System.Drawing.Point(35, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 91);
            this.panel1.TabIndex = 2;
            // 
            // VendorNameCombo
            // 
            this.VendorNameCombo.FormattingEnabled = true;
            this.VendorNameCombo.Location = new System.Drawing.Point(150, 19);
            this.VendorNameCombo.Name = "VendorNameCombo";
            this.VendorNameCombo.Size = new System.Drawing.Size(231, 24);
            this.VendorNameCombo.TabIndex = 1;
            // 
            // VendorReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 250);
            this.Controls.Add(this.VendorNameCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Generbtn);
            this.Name = "VendorReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor Report ";
            this.Load += new System.EventHandler(this.VendorReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FromDatetxt;
        private System.Windows.Forms.DateTimePicker ToDatetxt;
        private System.Windows.Forms.CheckBox AllDateschkbox;
        private System.Windows.Forms.Button Generbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox VendorNameCombo;
    }
}