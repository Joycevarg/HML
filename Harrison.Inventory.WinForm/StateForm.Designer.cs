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
            this.savebtn = new System.Windows.Forms.Button();
            this.rmvbtn = new System.Windows.Forms.Button();
            this.cnclbtn = new System.Windows.Forms.Button();
            this.stategrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.statetxt = new System.Windows.Forms.TextBox();
            this.edtbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stategrid)).BeginInit();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(30, 76);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(99, 38);
            this.savebtn.TabIndex = 1;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // rmvbtn
            // 
            this.rmvbtn.Enabled = false;
            this.rmvbtn.Location = new System.Drawing.Point(395, 77);
            this.rmvbtn.Name = "rmvbtn";
            this.rmvbtn.Size = new System.Drawing.Size(98, 37);
            this.rmvbtn.TabIndex = 5;
            this.rmvbtn.Text = "Remove";
            this.rmvbtn.UseVisualStyleBackColor = true;
            this.rmvbtn.Click += new System.EventHandler(this.rmvbtn_Click);
            // 
            // cnclbtn
            // 
            this.cnclbtn.Location = new System.Drawing.Point(157, 76);
            this.cnclbtn.Name = "cnclbtn";
            this.cnclbtn.Size = new System.Drawing.Size(92, 38);
            this.cnclbtn.TabIndex = 3;
            this.cnclbtn.Text = "Cancel";
            this.cnclbtn.UseVisualStyleBackColor = true;
            this.cnclbtn.Click += new System.EventHandler(this.cnclbtn_Click);
            // 
            // stategrid
            // 
            this.stategrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stategrid.Location = new System.Drawing.Point(45, 138);
            this.stategrid.Name = "stategrid";
            this.stategrid.RowTemplate.Height = 24;
            this.stategrid.Size = new System.Drawing.Size(423, 126);
            this.stategrid.TabIndex = 6;
            this.stategrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stategrid_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "State Name:";
            // 
            // statetxt
            // 
            this.statetxt.Location = new System.Drawing.Point(179, 27);
            this.statetxt.Name = "statetxt";
            this.statetxt.Size = new System.Drawing.Size(303, 22);
            this.statetxt.TabIndex = 1;
            // 
            // edtbtn
            // 
            this.edtbtn.Enabled = false;
            this.edtbtn.Location = new System.Drawing.Point(276, 77);
            this.edtbtn.Name = "edtbtn";
            this.edtbtn.Size = new System.Drawing.Size(92, 37);
            this.edtbtn.TabIndex = 4;
            this.edtbtn.Text = "Edit";
            this.edtbtn.UseVisualStyleBackColor = true;
            this.edtbtn.Click += new System.EventHandler(this.edtbtn_Click);
            // 
            // StateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 312);
            this.Controls.Add(this.edtbtn);
            this.Controls.Add(this.statetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stategrid);
            this.Controls.Add(this.cnclbtn);
            this.Controls.Add(this.rmvbtn);
            this.Controls.Add(this.savebtn);
            this.Name = "StateForm";
            this.Text = "StateForm";
            this.Load += new System.EventHandler(this.StateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stategrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button rmvbtn;
        private System.Windows.Forms.Button cnclbtn;
        private System.Windows.Forms.DataGridView stategrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox statetxt;
        private System.Windows.Forms.Button edtbtn;
    }
}