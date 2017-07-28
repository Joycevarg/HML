namespace Harrison.Inventory.WinForm
{
    partial class ClusterDistrictMap
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
            this.label2 = new System.Windows.Forms.Label();
            this.DistrictCombo = new System.Windows.Forms.ComboBox();
            this.ClusterCombo = new System.Windows.Forms.ComboBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.clusterdistrictgrid = new System.Windows.Forms.DataGridView();
            this.edtbtn = new System.Windows.Forms.Button();
            this.dltbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clusterdistrictgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "District:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cluster:";
            // 
            // DistrictCombo
            // 
            this.DistrictCombo.FormattingEnabled = true;
            this.DistrictCombo.Location = new System.Drawing.Point(178, 91);
            this.DistrictCombo.Name = "DistrictCombo";
            this.DistrictCombo.Size = new System.Drawing.Size(301, 24);
            this.DistrictCombo.TabIndex = 2;
            // 
            // ClusterCombo
            // 
            this.ClusterCombo.FormattingEnabled = true;
            this.ClusterCombo.Location = new System.Drawing.Point(178, 37);
            this.ClusterCombo.Name = "ClusterCombo";
            this.ClusterCombo.Size = new System.Drawing.Size(301, 24);
            this.ClusterCombo.TabIndex = 1;
            this.ClusterCombo.SelectedIndexChanged += new System.EventHandler(this.ClusterCombo_SelectedIndexChanged);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(25, 136);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(103, 40);
            this.Addbtn.TabIndex = 3;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(159, 136);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(102, 40);
            this.Cancelbtn.TabIndex = 4;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // clusterdistrictgrid
            // 
            this.clusterdistrictgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clusterdistrictgrid.Location = new System.Drawing.Point(31, 197);
            this.clusterdistrictgrid.Name = "clusterdistrictgrid";
            this.clusterdistrictgrid.RowTemplate.Height = 24;
            this.clusterdistrictgrid.Size = new System.Drawing.Size(484, 190);
            this.clusterdistrictgrid.TabIndex = 6;
            // 
            // edtbtn
            // 
            this.edtbtn.Location = new System.Drawing.Point(295, 136);
            this.edtbtn.Name = "edtbtn";
            this.edtbtn.Size = new System.Drawing.Size(102, 40);
            this.edtbtn.TabIndex = 5;
            this.edtbtn.Text = "Edit";
            this.edtbtn.UseVisualStyleBackColor = true;
            // 
            // dltbtn
            // 
            this.dltbtn.Location = new System.Drawing.Point(427, 136);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(102, 40);
            this.dltbtn.TabIndex = 6;
            this.dltbtn.Text = "Remove";
            this.dltbtn.UseVisualStyleBackColor = true;
            // 
            // ClusterDistrictMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 399);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.edtbtn);
            this.Controls.Add(this.clusterdistrictgrid);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.ClusterCombo);
            this.Controls.Add(this.DistrictCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClusterDistrictMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cluster District Mapping";
            this.Load += new System.EventHandler(this.ClusterDistrictMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clusterdistrictgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DistrictCombo;
        private System.Windows.Forms.ComboBox ClusterCombo;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.DataGridView clusterdistrictgrid;
        private System.Windows.Forms.Button edtbtn;
        private System.Windows.Forms.Button dltbtn;
    }
}