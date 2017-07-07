namespace Harrison.Inventory.WinForm
{
    partial class branchDetails
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newbranchtxt = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.banklst = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gridbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add new branch:";
            // 
            // newbranchtxt
            // 
            this.newbranchtxt.Location = new System.Drawing.Point(123, 54);
            this.newbranchtxt.Name = "newbranchtxt";
            this.newbranchtxt.Size = new System.Drawing.Size(245, 22);
            this.newbranchtxt.TabIndex = 5;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(17, 229);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(104, 33);
            this.savebtn.TabIndex = 7;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(144, 229);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(104, 33);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // banklst
            // 
            this.banklst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banklst.FormattingEnabled = true;
            this.banklst.Location = new System.Drawing.Point(123, 23);
            this.banklst.Name = "banklst";
            this.banklst.Size = new System.Drawing.Size(245, 24);
            this.banklst.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "IFSC Code:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bank Address:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 114);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 75);
            this.textBox2.TabIndex = 13;
            // 
            // gridbtn
            // 
            this.gridbtn.Location = new System.Drawing.Point(275, 229);
            this.gridbtn.Name = "gridbtn";
            this.gridbtn.Size = new System.Drawing.Size(104, 33);
            this.gridbtn.TabIndex = 14;
            this.gridbtn.Text = "View Grid";
            this.gridbtn.UseVisualStyleBackColor = true;
            this.gridbtn.Click += new System.EventHandler(this.gridbtn_Click);
            // 
            // branchDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 366);
            this.Controls.Add(this.gridbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.banklst);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.newbranchtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "branchDetails";
            this.Text = "Branch Details";
            this.Load += new System.EventHandler(this.branchDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newbranchtxt;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.ComboBox banklst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button gridbtn;
    }
}