namespace Harrison.Inventory.WinForm
{
    partial class RPSdetails
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
            this.rpsNamelbl = new System.Windows.Forms.Label();
            this.rpsNametxt = new System.Windows.Forms.ComboBox();
            this.contactNamelbl = new System.Windows.Forms.Label();
            this.contactNametxt = new System.Windows.Forms.TextBox();
            this.contactNolbl = new System.Windows.Forms.Label();
            this.contactNotxt = new System.Windows.Forms.TextBox();
            this.routeDetlslbl = new System.Windows.Forms.Label();
            this.routeDetlstxt = new System.Windows.Forms.TextBox();
            this.remarklbl = new System.Windows.Forms.Label();
            this.remarktxt = new System.Windows.Forms.TextBox();
            this.donebtn = new System.Windows.Forms.Button();
            this.gridbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ventorIDlst = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rpsNamelbl
            // 
            this.rpsNamelbl.AutoSize = true;
            this.rpsNamelbl.Location = new System.Drawing.Point(33, 82);
            this.rpsNamelbl.Name = "rpsNamelbl";
            this.rpsNamelbl.Size = new System.Drawing.Size(81, 17);
            this.rpsNamelbl.TabIndex = 0;
            this.rpsNamelbl.Text = "RPS Name:";
            // 
            // rpsNametxt
            // 
            this.rpsNametxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.rpsNametxt.FormattingEnabled = true;
            this.rpsNametxt.Location = new System.Drawing.Point(160, 79);
            this.rpsNametxt.Name = "rpsNametxt";
            this.rpsNametxt.Size = new System.Drawing.Size(426, 24);
            this.rpsNametxt.TabIndex = 4;
            // 
            // contactNamelbl
            // 
            this.contactNamelbl.AutoSize = true;
            this.contactNamelbl.Location = new System.Drawing.Point(33, 130);
            this.contactNamelbl.Name = "contactNamelbl";
            this.contactNamelbl.Size = new System.Drawing.Size(101, 17);
            this.contactNamelbl.TabIndex = 2;
            this.contactNamelbl.Text = "Contact Name:";
            // 
            // contactNametxt
            // 
            this.contactNametxt.Location = new System.Drawing.Point(160, 127);
            this.contactNametxt.Name = "contactNametxt";
            this.contactNametxt.Size = new System.Drawing.Size(309, 22);
            this.contactNametxt.TabIndex = 5;
            // 
            // contactNolbl
            // 
            this.contactNolbl.AutoSize = true;
            this.contactNolbl.Location = new System.Drawing.Point(33, 176);
            this.contactNolbl.Name = "contactNolbl";
            this.contactNolbl.Size = new System.Drawing.Size(114, 17);
            this.contactNolbl.TabIndex = 4;
            this.contactNolbl.Text = "Contact Number:";
            // 
            // contactNotxt
            // 
            this.contactNotxt.Location = new System.Drawing.Point(160, 176);
            this.contactNotxt.Name = "contactNotxt";
            this.contactNotxt.Size = new System.Drawing.Size(261, 22);
            this.contactNotxt.TabIndex = 6;
            // 
            // routeDetlslbl
            // 
            this.routeDetlslbl.AutoSize = true;
            this.routeDetlslbl.Location = new System.Drawing.Point(33, 222);
            this.routeDetlslbl.Name = "routeDetlslbl";
            this.routeDetlslbl.Size = new System.Drawing.Size(97, 17);
            this.routeDetlslbl.TabIndex = 6;
            this.routeDetlslbl.Text = "Route Details:";
            // 
            // routeDetlstxt
            // 
            this.routeDetlstxt.Location = new System.Drawing.Point(160, 222);
            this.routeDetlstxt.Multiline = true;
            this.routeDetlstxt.Name = "routeDetlstxt";
            this.routeDetlstxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.routeDetlstxt.Size = new System.Drawing.Size(426, 82);
            this.routeDetlstxt.TabIndex = 7;
            // 
            // remarklbl
            // 
            this.remarklbl.AutoSize = true;
            this.remarklbl.Location = new System.Drawing.Point(33, 328);
            this.remarklbl.Name = "remarklbl";
            this.remarklbl.Size = new System.Drawing.Size(112, 17);
            this.remarklbl.TabIndex = 8;
            this.remarklbl.Text = "Remarks(if any):";
            // 
            // remarktxt
            // 
            this.remarktxt.Location = new System.Drawing.Point(160, 328);
            this.remarktxt.Multiline = true;
            this.remarktxt.Name = "remarktxt";
            this.remarktxt.Size = new System.Drawing.Size(426, 56);
            this.remarktxt.TabIndex = 8;
            // 
            // donebtn
            // 
            this.donebtn.Location = new System.Drawing.Point(36, 413);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(161, 44);
            this.donebtn.TabIndex = 10;
            this.donebtn.Text = "Save";
            this.donebtn.UseVisualStyleBackColor = true;
            // 
            // gridbtn
            // 
            this.gridbtn.BackColor = System.Drawing.SystemColors.Control;
            this.gridbtn.Location = new System.Drawing.Point(442, 414);
            this.gridbtn.Name = "gridbtn";
            this.gridbtn.Size = new System.Drawing.Size(144, 43);
            this.gridbtn.TabIndex = 16;
            this.gridbtn.Text = "View Grid";
            this.gridbtn.UseVisualStyleBackColor = true;
            this.gridbtn.Click += new System.EventHandler(this.gridbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(241, 413);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(144, 44);
            this.cancelbtn.TabIndex = 17;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ventor Name:";
            // 
            // ventorIDlst
            // 
            this.ventorIDlst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ventorIDlst.FormattingEnabled = true;
            this.ventorIDlst.Location = new System.Drawing.Point(160, 30);
            this.ventorIDlst.Name = "ventorIDlst";
            this.ventorIDlst.Size = new System.Drawing.Size(309, 24);
            this.ventorIDlst.TabIndex = 19;
            // 
            // RPSdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 490);
            this.Controls.Add(this.ventorIDlst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.gridbtn);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.remarktxt);
            this.Controls.Add(this.remarklbl);
            this.Controls.Add(this.routeDetlstxt);
            this.Controls.Add(this.routeDetlslbl);
            this.Controls.Add(this.contactNotxt);
            this.Controls.Add(this.contactNolbl);
            this.Controls.Add(this.contactNametxt);
            this.Controls.Add(this.contactNamelbl);
            this.Controls.Add(this.rpsNametxt);
            this.Controls.Add(this.rpsNamelbl);
            this.Name = "RPSdetails";
            this.Text = "RPS";
            this.Load += new System.EventHandler(this.RPS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rpsNamelbl;
        private System.Windows.Forms.ComboBox rpsNametxt;
        private System.Windows.Forms.Label contactNamelbl;
        private System.Windows.Forms.TextBox contactNametxt;
        private System.Windows.Forms.Label contactNolbl;
        private System.Windows.Forms.TextBox contactNotxt;
        private System.Windows.Forms.Label routeDetlslbl;
        private System.Windows.Forms.TextBox routeDetlstxt;
        private System.Windows.Forms.Label remarklbl;
        private System.Windows.Forms.TextBox remarktxt;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Button gridbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ventorIDlst;

    }
}