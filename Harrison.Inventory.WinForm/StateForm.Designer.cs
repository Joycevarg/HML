namespace Harrison.Inventory.WinForm
{
    partial class StateForm
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
            this.addbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.rmvbtn = new System.Windows.Forms.Button();
            this.cnclbtn = new System.Windows.Forms.Button();
            this.stategrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.statetxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stategrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(413, 27);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(92, 23);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "Add District";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(25, 214);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(107, 38);
            this.savebtn.TabIndex = 1;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // rmvbtn
            // 
            this.rmvbtn.Location = new System.Drawing.Point(201, 214);
            this.rmvbtn.Name = "rmvbtn";
            this.rmvbtn.Size = new System.Drawing.Size(105, 38);
            this.rmvbtn.TabIndex = 2;
            this.rmvbtn.Text = "Remove";
            this.rmvbtn.UseVisualStyleBackColor = true;
            // 
            // cnclbtn
            // 
            this.cnclbtn.Location = new System.Drawing.Point(383, 214);
            this.cnclbtn.Name = "cnclbtn";
            this.cnclbtn.Size = new System.Drawing.Size(106, 38);
            this.cnclbtn.TabIndex = 3;
            this.cnclbtn.Text = "Cancel";
            this.cnclbtn.UseVisualStyleBackColor = true;
            // 
            // stategrid
            // 
            this.stategrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stategrid.Location = new System.Drawing.Point(73, 75);
            this.stategrid.Name = "stategrid";
            this.stategrid.RowTemplate.Height = 24;
            this.stategrid.Size = new System.Drawing.Size(334, 114);
            this.stategrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "State Name:";
            // 
            // statetxt
            // 
            this.statetxt.Location = new System.Drawing.Point(104, 27);
            this.statetxt.Name = "statetxt";
            this.statetxt.Size = new System.Drawing.Size(303, 22);
            this.statetxt.TabIndex = 6;
            // 
            // StateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 279);
            this.Controls.Add(this.statetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stategrid);
            this.Controls.Add(this.cnclbtn);
            this.Controls.Add(this.rmvbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.addbtn);
            this.Name = "StateForm";
            this.Text = "StateForm";
            this.Load += new System.EventHandler(this.StateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stategrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button rmvbtn;
        private System.Windows.Forms.Button cnclbtn;
        private System.Windows.Forms.DataGridView stategrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox statetxt;
    }
}