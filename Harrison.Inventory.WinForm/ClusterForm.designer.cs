﻿namespace Harrison.Inventory.WinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.statecombo = new System.Windows.Forms.ComboBox();
            this.editbtn = new System.Windows.Forms.Button();
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
            this.clustertxt.Size = new System.Drawing.Size(273, 22);
            this.clustertxt.TabIndex = 3;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(15, 96);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(94, 29);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(155, 96);
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
            // statecombo
            // 
            this.statecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statecombo.FormattingEnabled = true;
            this.statecombo.Location = new System.Drawing.Point(115, 66);
            this.statecombo.Name = "statecombo";
            this.statecombo.Size = new System.Drawing.Size(273, 24);
            this.statecombo.TabIndex = 11;
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(294, 96);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(94, 29);
            this.editbtn.TabIndex = 12;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            // 
            // clustergrid
            // 
            this.clustergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clustergrid.Location = new System.Drawing.Point(15, 147);
            this.clustergrid.Name = "clustergrid";
            this.clustergrid.RowTemplate.Height = 24;
            this.clustergrid.Size = new System.Drawing.Size(373, 139);
            this.clustergrid.TabIndex = 13;
            // 
            // clusterMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 295);
            this.Controls.Add(this.clustergrid);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.statecombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.addbtn);
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
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statecombo;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.DataGridView clustergrid;
    }
}