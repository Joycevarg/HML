namespace Harrison.Inventory.WinForm
{
    partial class FinancialYear
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
            this.finYeartxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Fin_Year_Bttn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.FinancialYear_Grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialYear_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // finYeartxt
            // 
            this.finYeartxt.Location = new System.Drawing.Point(128, 41);
            this.finYeartxt.Margin = new System.Windows.Forms.Padding(4);
            this.finYeartxt.Name = "finYeartxt";
            this.finYeartxt.Size = new System.Drawing.Size(227, 22);
            this.finYeartxt.TabIndex = 0;            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Financial Year:";
            // 
            // Add_Fin_Year_Bttn
            // 
            this.Add_Fin_Year_Bttn.Location = new System.Drawing.Point(26, 85);
            this.Add_Fin_Year_Bttn.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Fin_Year_Bttn.Name = "Add_Fin_Year_Bttn";
            this.Add_Fin_Year_Bttn.Size = new System.Drawing.Size(94, 37);
            this.Add_Fin_Year_Bttn.TabIndex = 2;
            this.Add_Fin_Year_Bttn.Text = "Add";
            this.Add_Fin_Year_Bttn.UseVisualStyleBackColor = true;
            this.Add_Fin_Year_Bttn.Click += new System.EventHandler(this.Add_Fin_Year_Bttn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(267, 85);
            this.editbtn.Margin = new System.Windows.Forms.Padding(4);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(91, 37);
            this.editbtn.TabIndex = 3;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(150, 85);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(91, 37);
            this.Cancelbtn.TabIndex = 4;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // FinancialYear_Grid
            // 
            this.FinancialYear_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FinancialYear_Grid.Location = new System.Drawing.Point(26, 140);
            this.FinancialYear_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.FinancialYear_Grid.Name = "FinancialYear_Grid";
            this.FinancialYear_Grid.Size = new System.Drawing.Size(332, 152);
            this.FinancialYear_Grid.TabIndex = 5;
            this.FinancialYear_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FinancialYear_Grid_CellContentClick);
            // 
            // FinancialYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(386, 318);
            this.Controls.Add(this.FinancialYear_Grid);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.Add_Fin_Year_Bttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finYeartxt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinancialYear";
            this.Text = "FinancialYear";
            this.Load += new System.EventHandler(this.FinancialYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FinancialYear_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox finYeartxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Fin_Year_Bttn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.DataGridView FinancialYear_Grid;
    }
}