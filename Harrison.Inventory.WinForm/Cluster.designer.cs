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
            this.districtselect = new System.Windows.Forms.CheckedListBox();
            this.districtlbl = new System.Windows.Forms.Label();
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
            this.donebtn.Location = new System.Drawing.Point(15, 235);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(113, 27);
            this.donebtn.TabIndex = 6;
            this.donebtn.Text = "Save";
            this.donebtn.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(217, 235);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(113, 27);
            this.cancelbtn.TabIndex = 7;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // districtselect
            // 
            this.districtselect.FormattingEnabled = true;
            this.districtselect.Items.AddRange(new object[] {
            "Thrissur",
            "Thriuvanathapuram ",
            "Kozhikode",
            "Ernakulam",
            "Kottayam"});
            this.districtselect.Location = new System.Drawing.Point(115, 81);
            this.districtselect.Name = "districtselect";
            this.districtselect.Size = new System.Drawing.Size(190, 123);
            this.districtselect.TabIndex = 8;
            // 
            // districtlbl
            // 
            this.districtlbl.AutoSize = true;
            this.districtlbl.Location = new System.Drawing.Point(12, 81);
            this.districtlbl.Name = "districtlbl";
            this.districtlbl.Size = new System.Drawing.Size(55, 17);
            this.districtlbl.TabIndex = 9;
            this.districtlbl.Text = "District:";
            // 
            // clusterMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 292);
            this.Controls.Add(this.districtlbl);
            this.Controls.Add(this.districtselect);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.clustertxt);
            this.Controls.Add(this.clusterlbl);
            this.Name = "clusterMaster";
            this.Text = "Cluster Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clusterlbl;
        private System.Windows.Forms.TextBox clustertxt;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.CheckedListBox districtselect;
        private System.Windows.Forms.Label districtlbl;
    }
}