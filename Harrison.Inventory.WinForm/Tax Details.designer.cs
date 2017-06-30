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
            this.vattxt = new System.Windows.Forms.TextBox();
            this.cesstxt = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // finYeartxt
            // 
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
            this.label3.Location = new System.Drawing.Point(63, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "VAT in(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cess in (%)";
            // 
            // vattxt
            // 
            this.vattxt.Location = new System.Drawing.Point(147, 106);
            this.vattxt.Margin = new System.Windows.Forms.Padding(4);
            this.vattxt.Name = "vattxt";
            this.vattxt.Size = new System.Drawing.Size(307, 22);
            this.vattxt.TabIndex = 6;
            // 
            // cesstxt
            // 
            this.cesstxt.Location = new System.Drawing.Point(147, 145);
            this.cesstxt.Margin = new System.Windows.Forms.Padding(4);
            this.cesstxt.Name = "cesstxt";
            this.cesstxt.Size = new System.Drawing.Size(307, 22);
            this.cesstxt.TabIndex = 7;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(159, 196);
            this.savebtn.Margin = new System.Windows.Forms.Padding(4);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(83, 28);
            this.savebtn.TabIndex = 8;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 196);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 196);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Tax_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 268);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.cesstxt);
            this.Controls.Add(this.vattxt);
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
        private System.Windows.Forms.TextBox vattxt;
        private System.Windows.Forms.TextBox cesstxt;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}