namespace Harrison.Inventory.WinForm
{
    partial class Tax_Details
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
            this.finYeartxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.effectDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CGSTtxt = new System.Windows.Forms.TextBox();
            this.SGSTtxt = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.gridview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // finYeartxt
            // 
            this.finYeartxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finYeartxt.FormattingEnabled = true;
            this.finYeartxt.Location = new System.Drawing.Point(147, 31);
            this.finYeartxt.Margin = new System.Windows.Forms.Padding(4);
            this.finYeartxt.Name = "finYeartxt";
            this.finYeartxt.Size = new System.Drawing.Size(307, 24);
            this.finYeartxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Financial Year";
            // 
            // effectDate
            // 
            this.effectDate.CustomFormat = "yyyy-MM-dd";
            this.effectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.effectDate.Location = new System.Drawing.Point(147, 64);
            this.effectDate.Margin = new System.Windows.Forms.Padding(4);
            this.effectDate.Name = "effectDate";
            this.effectDate.Size = new System.Drawing.Size(307, 22);
            this.effectDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "With Effect From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "CGST in(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "SGST in(%)";
            // 
            // CGSTtxt
            // 
            this.CGSTtxt.Location = new System.Drawing.Point(147, 108);
            this.CGSTtxt.Margin = new System.Windows.Forms.Padding(4);
            this.CGSTtxt.Name = "CGSTtxt";
            this.CGSTtxt.Size = new System.Drawing.Size(307, 22);
            this.CGSTtxt.TabIndex = 6;
            // 
            // SGSTtxt
            // 
            this.SGSTtxt.Location = new System.Drawing.Point(147, 145);
            this.SGSTtxt.Margin = new System.Windows.Forms.Padding(4);
            this.SGSTtxt.Name = "SGSTtxt";
            this.SGSTtxt.Size = new System.Drawing.Size(307, 22);
            this.SGSTtxt.TabIndex = 7;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(13, 196);
            this.savebtn.Margin = new System.Windows.Forms.Padding(4);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(95, 48);
            this.savebtn.TabIndex = 8;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(287, 196);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(85, 48);
            this.cancelbtn.TabIndex = 9;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(398, 196);
            this.editbtn.Margin = new System.Windows.Forms.Padding(4);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(88, 48);
            this.editbtn.TabIndex = 11;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            // 
            // gridview
            // 
            this.gridview.Location = new System.Drawing.Point(136, 196);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(121, 48);
            this.gridview.TabIndex = 13;
            this.gridview.Text = "Previous Tax Details";
            this.gridview.UseVisualStyleBackColor = true;
            this.gridview.Click += new System.EventHandler(this.gridview_Click);
            // 
            // Tax_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 268);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.SGSTtxt);
            this.Controls.Add(this.CGSTtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.effectDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finYeartxt);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tax_Details";
            this.Text = "Tax Details";
            this.Load += new System.EventHandler(this.Tax_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox finYeartxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker effectDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CGSTtxt;
        private System.Windows.Forms.TextBox SGSTtxt;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button gridview;
    }
}