namespace Harrison.Inventory.WinForm
{
    partial class ConfirmBox
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
            this.Messagelbl = new System.Windows.Forms.Label();
            this.ybtn = new System.Windows.Forms.Button();
            this.nbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Messagelbl
            // 
            this.Messagelbl.AutoSize = true;
            this.Messagelbl.Location = new System.Drawing.Point(67, 56);
            this.Messagelbl.Name = "Messagelbl";
            this.Messagelbl.Size = new System.Drawing.Size(0, 17);
            this.Messagelbl.TabIndex = 0;
            // 
            // ybtn
            // 
            this.ybtn.Location = new System.Drawing.Point(70, 152);
            this.ybtn.Name = "ybtn";
            this.ybtn.Size = new System.Drawing.Size(93, 40);
            this.ybtn.TabIndex = 1;
            this.ybtn.Text = "Yes";
            this.ybtn.UseVisualStyleBackColor = true;
           
            // 
            // nbtn
            // 
            this.nbtn.Location = new System.Drawing.Point(260, 152);
            this.nbtn.Name = "nbtn";
            this.nbtn.Size = new System.Drawing.Size(93, 40);
            this.nbtn.TabIndex = 2;
            this.nbtn.Text = "No";
            this.nbtn.UseVisualStyleBackColor = true;
            // 
            // ConfirmBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 238);
            this.Controls.Add(this.nbtn);
            this.Controls.Add(this.ybtn);
            this.Controls.Add(this.Messagelbl);
            this.Name = "ConfirmBox";
            this.Text = "ConfirmBox";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Messagelbl;
        private System.Windows.Forms.Button ybtn;
        private System.Windows.Forms.Button nbtn;
    }
}