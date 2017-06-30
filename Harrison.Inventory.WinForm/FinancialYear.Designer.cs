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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Fin_Year_Bttn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FinancialYear_Grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialYear_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Financial Year";
            // 
            // Add_Fin_Year_Bttn
            // 
            this.Add_Fin_Year_Bttn.Location = new System.Drawing.Point(69, 94);
            this.Add_Fin_Year_Bttn.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Fin_Year_Bttn.Name = "Add_Fin_Year_Bttn";
            this.Add_Fin_Year_Bttn.Size = new System.Drawing.Size(100, 28);
            this.Add_Fin_Year_Bttn.TabIndex = 2;
            this.Add_Fin_Year_Bttn.Text = "ADD";
            this.Add_Fin_Year_Bttn.UseVisualStyleBackColor = true;
            this.Add_Fin_Year_Bttn.Click += new System.EventHandler(this.Add_Fin_Year_Bttn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 94);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FinancialYear_Grid
            // 
            this.FinancialYear_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FinancialYear_Grid.Location = new System.Drawing.Point(57, 153);
            this.FinancialYear_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.FinancialYear_Grid.Name = "FinancialYear_Grid";
            this.FinancialYear_Grid.Size = new System.Drawing.Size(332, 185);
            this.FinancialYear_Grid.TabIndex = 5;
            // 
            // FinancialYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 356);
            this.Controls.Add(this.FinancialYear_Grid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add_Fin_Year_Bttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinancialYear";
            this.Text = "FinancialYear";
            this.Load += new System.EventHandler(this.FinancialYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FinancialYear_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Fin_Year_Bttn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView FinancialYear_Grid;
    }
}