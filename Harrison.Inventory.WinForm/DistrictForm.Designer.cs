namespace Harrison.Inventory.WinForm
{
    partial class DistrictForm
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
            this.addbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.districttxt = new System.Windows.Forms.TextBox();
            this.districtgrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.statecombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.districtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "District Name:";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(27, 106);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(105, 35);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(300, 106);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(105, 35);
            this.editbtn.TabIndex = 3;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(162, 106);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(105, 35);
            this.cancelbtn.TabIndex = 4;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // districttxt
            // 
            this.districttxt.Location = new System.Drawing.Point(124, 24);
            this.districttxt.Name = "districttxt";
            this.districttxt.Size = new System.Drawing.Size(268, 22);
            this.districttxt.TabIndex = 5;
            // 
            // districtgrid
            // 
            this.districtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.districtgrid.Location = new System.Drawing.Point(27, 156);
            this.districtgrid.Name = "districtgrid";
            this.districtgrid.RowTemplate.Height = 24;
            this.districtgrid.Size = new System.Drawing.Size(378, 123);
            this.districtgrid.TabIndex = 6;
            this.districtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DistrictGrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "State:";
            // 
            // statecombo
            // 
            this.statecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statecombo.FormattingEnabled = true;
            this.statecombo.Location = new System.Drawing.Point(124, 66);
            this.statecombo.Name = "statecombo";
            this.statecombo.Size = new System.Drawing.Size(268, 24);
            this.statecombo.TabIndex = 8;
            // 
            // DistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 301);
            this.Controls.Add(this.statecombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.districtgrid);
            this.Controls.Add(this.districttxt);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label1);
            this.Name = "DistrictForm";
            this.Text = "Districts";
            this.Load += new System.EventHandler(this.DistrictForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.districtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.TextBox districttxt;
        private System.Windows.Forms.DataGridView districtgrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statecombo;
    }
}