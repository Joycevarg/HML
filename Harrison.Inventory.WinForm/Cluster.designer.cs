namespace Harrison.Inventory.WinForm
{
    partial class clusterMaster
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
            this.clusterlbl = new System.Windows.Forms.Label();
            this.clustertxt = new System.Windows.Forms.TextBox();
            this.donebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clustergrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clustergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clusterlbl
            // 
            this.clusterlbl.AutoSize = true;
            this.clusterlbl.Location = new System.Drawing.Point(12, 36);
            this.clusterlbl.Name = "clusterlbl";
            this.clusterlbl.Size = new System.Drawing.Size(97, 17);
            this.clusterlbl.TabIndex = 2;
            this.clusterlbl.Text = "Cluster Name:";
            // 
            // clustertxt
            // 
            this.clustertxt.Location = new System.Drawing.Point(115, 33);
            this.clustertxt.Name = "clustertxt";
            this.clustertxt.Size = new System.Drawing.Size(215, 22);
            this.clustertxt.TabIndex = 3;
            // 
            // donebtn
            // 
            this.donebtn.Location = new System.Drawing.Point(15, 101);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(94, 29);
            this.donebtn.TabIndex = 6;
            this.donebtn.Text = "Add";
            this.donebtn.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(124, 101);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(94, 29);
            this.cancelbtn.TabIndex = 7;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "State:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clustergrid
            // 
            this.clustergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clustergrid.Location = new System.Drawing.Point(15, 147);
            this.clustergrid.Name = "clustergrid";
            this.clustergrid.RowTemplate.Height = 24;
            this.clustergrid.Size = new System.Drawing.Size(315, 113);
            this.clustergrid.TabIndex = 13;
            // 
            // clusterMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 277);
            this.Controls.Add(this.clustergrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.clustertxt);
            this.Controls.Add(this.clusterlbl);
            this.Name = "clusterMaster";
            this.Text = "Cluster Master";
            this.Load += new System.EventHandler(this.clusterMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clustergrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clusterlbl;
        private System.Windows.Forms.TextBox clustertxt;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView clustergrid;
    }
}