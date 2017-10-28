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
            this.addbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.clustergrid = new System.Windows.Forms.DataGridView();
            this.dltbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clustergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clusterlbl
            // 
            this.clusterlbl.AutoSize = true;
            this.clusterlbl.Location = new System.Drawing.Point(36, 52);
            this.clusterlbl.Name = "clusterlbl";
            this.clusterlbl.Size = new System.Drawing.Size(97, 17);
            this.clusterlbl.TabIndex = 2;
            this.clusterlbl.Text = "Cluster Name:";
            // 
            // clustertxt
            // 
            this.clustertxt.Location = new System.Drawing.Point(162, 47);
            this.clustertxt.Name = "clustertxt";
            this.clustertxt.Size = new System.Drawing.Size(299, 22);
            this.clustertxt.TabIndex = 1;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(39, 106);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(94, 43);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(162, 106);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(94, 43);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Enabled = false;
            this.editbtn.Location = new System.Drawing.Point(291, 106);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(94, 43);
            this.editbtn.TabIndex = 4;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // clustergrid
            // 
            this.clustergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clustergrid.Location = new System.Drawing.Point(49, 170);
            this.clustergrid.Name = "clustergrid";
            this.clustergrid.RowTemplate.Height = 24;
            this.clustergrid.Size = new System.Drawing.Size(430, 199);
            this.clustergrid.TabIndex = 13;
            this.clustergrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clustergrid_RowHeaderMouseClick);
            // 
            // dltbtn
            // 
            this.dltbtn.Enabled = false;
            this.dltbtn.Location = new System.Drawing.Point(413, 108);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(94, 41);
            this.dltbtn.TabIndex = 5;
            this.dltbtn.Text = "Delete";
            this.dltbtn.UseVisualStyleBackColor = true;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click);
            // 
            // clusterMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 401);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.clustergrid);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.clustertxt);
            this.Controls.Add(this.clusterlbl);
            this.Name = "clusterMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cluster Master";
            this.Load += new System.EventHandler(this.clusterMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clustergrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clusterlbl;
        private System.Windows.Forms.TextBox clustertxt;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.DataGridView clustergrid;
        private System.Windows.Forms.Button dltbtn;
    }
}