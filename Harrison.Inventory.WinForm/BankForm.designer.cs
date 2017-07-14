namespace Harrison.Inventory.WinForm
{
    partial class bankDetails
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
            this.BankNamelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bankNametxt = new System.Windows.Forms.ComboBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.edtbtn = new System.Windows.Forms.Button();
            this.bankgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bankgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BankNamelbl
            // 
            this.BankNamelbl.AutoSize = true;
            this.BankNamelbl.Location = new System.Drawing.Point(12, 31);
            this.BankNamelbl.Name = "BankNamelbl";
            this.BankNamelbl.Size = new System.Drawing.Size(85, 17);
            this.BankNamelbl.TabIndex = 3;
            this.BankNamelbl.Text = "Bank Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            // 
            // bankNametxt
            // 
            this.bankNametxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bankNametxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bankNametxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.bankNametxt.FormattingEnabled = true;
            this.bankNametxt.Location = new System.Drawing.Point(103, 28);
            this.bankNametxt.Name = "bankNametxt";
            this.bankNametxt.Size = new System.Drawing.Size(344, 24);
            this.bankNametxt.TabIndex = 4;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(15, 275);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(150, 41);
            this.savebtn.TabIndex = 12;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.donebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(213, 275);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(143, 41);
            this.cancelbtn.TabIndex = 14;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(454, 28);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(91, 22);
            this.addbtn.TabIndex = 15;
            this.addbtn.Text = "Add Branch";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // edtbtn
            // 
            this.edtbtn.Location = new System.Drawing.Point(396, 275);
            this.edtbtn.Name = "edtbtn";
            this.edtbtn.Size = new System.Drawing.Size(136, 41);
            this.edtbtn.TabIndex = 16;
            this.edtbtn.Text = "Edit";
            this.edtbtn.UseVisualStyleBackColor = true;
            // 
            // bankgrid
            // 
            this.bankgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bankgrid.Location = new System.Drawing.Point(75, 82);
            this.bankgrid.Name = "bankgrid";
            this.bankgrid.RowTemplate.Height = 24;
            this.bankgrid.Size = new System.Drawing.Size(410, 150);
            this.bankgrid.TabIndex = 17;
            // 
            // bankDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 348);
            this.Controls.Add(this.bankgrid);
            this.Controls.Add(this.edtbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.bankNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BankNamelbl);
            this.Name = "bankDetails";
            this.Text = "Bank Master";
            this.Load += new System.EventHandler(this.bankDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BankNamelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bankNametxt;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button edtbtn;
        private System.Windows.Forms.DataGridView bankgrid;
    }
}