﻿namespace Harrison.Inventory.WinForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.districtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clustersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clusterDistrictMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateVendorReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.transationsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1009, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorsToolStripMenuItem,
            this.rPSToolStripMenuItem,
            this.bankToolStripMenuItem,
            this.branchsToolStripMenuItem,
            this.stateToolStripMenuItem,
            this.districtsToolStripMenuItem,
            this.financialYearToolStripMenuItem,
            this.taxDetailsToolStripMenuItem,
            this.clustersToolStripMenuItem,
            this.clusterDistrictMappingToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // vendorsToolStripMenuItem
            // 
            this.vendorsToolStripMenuItem.Name = "vendorsToolStripMenuItem";
            this.vendorsToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.vendorsToolStripMenuItem.Text = "Vendors";
            this.vendorsToolStripMenuItem.Click += new System.EventHandler(this.vendorsToolStripMenuItem_Click);
            // 
            // rPSToolStripMenuItem
            // 
            this.rPSToolStripMenuItem.Name = "rPSToolStripMenuItem";
            this.rPSToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.rPSToolStripMenuItem.Text = "RPS";
            this.rPSToolStripMenuItem.Click += new System.EventHandler(this.rPSToolStripMenuItem_Click);
            // 
            // bankToolStripMenuItem
            // 
            this.bankToolStripMenuItem.Name = "bankToolStripMenuItem";
            this.bankToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.bankToolStripMenuItem.Text = "Bank";
            this.bankToolStripMenuItem.Click += new System.EventHandler(this.bankToolStripMenuItem_Click);
            // 
            // branchsToolStripMenuItem
            // 
            this.branchsToolStripMenuItem.Name = "branchsToolStripMenuItem";
            this.branchsToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.branchsToolStripMenuItem.Text = "Branches";
            this.branchsToolStripMenuItem.Click += new System.EventHandler(this.branchsToolStripMenuItem_Click);
            // 
            // stateToolStripMenuItem
            // 
            this.stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.stateToolStripMenuItem.Text = "State";
            this.stateToolStripMenuItem.Click += new System.EventHandler(this.stateToolStripMenuItem_Click);
            // 
            // districtsToolStripMenuItem
            // 
            this.districtsToolStripMenuItem.Name = "districtsToolStripMenuItem";
            this.districtsToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.districtsToolStripMenuItem.Text = "Districts";
            this.districtsToolStripMenuItem.Click += new System.EventHandler(this.districtsToolStripMenuItem_Click);
            // 
            // financialYearToolStripMenuItem
            // 
            this.financialYearToolStripMenuItem.Name = "financialYearToolStripMenuItem";
            this.financialYearToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.financialYearToolStripMenuItem.Text = "Financial Year";
            this.financialYearToolStripMenuItem.Click += new System.EventHandler(this.financialYearToolStripMenuItem_Click);
            // 
            // taxDetailsToolStripMenuItem
            // 
            this.taxDetailsToolStripMenuItem.Name = "taxDetailsToolStripMenuItem";
            this.taxDetailsToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.taxDetailsToolStripMenuItem.Text = "Tax Details";
            this.taxDetailsToolStripMenuItem.Click += new System.EventHandler(this.taxDetailsToolStripMenuItem_Click);
            // 
            // clustersToolStripMenuItem
            // 
            this.clustersToolStripMenuItem.Name = "clustersToolStripMenuItem";
            this.clustersToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.clustersToolStripMenuItem.Text = "Clusters";
            this.clustersToolStripMenuItem.Click += new System.EventHandler(this.clustersToolStripMenuItem_Click);
            // 
            // clusterDistrictMappingToolStripMenuItem
            // 
            this.clusterDistrictMappingToolStripMenuItem.Name = "clusterDistrictMappingToolStripMenuItem";
            this.clusterDistrictMappingToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.clusterDistrictMappingToolStripMenuItem.Text = "Cluster-District Mapping";
            this.clusterDistrictMappingToolStripMenuItem.Click += new System.EventHandler(this.clusterDistrictMappingToolStripMenuItem_Click);
            // 
            // transationsToolStripMenuItem
            // 
            this.transationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.transationToolStripMenuItem});
            this.transationsToolStripMenuItem.Name = "transationsToolStripMenuItem";
            this.transationsToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.transationsToolStripMenuItem.Text = "Transations";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.invoiceToolStripMenuItem.Text = "Invoice Details";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // transationToolStripMenuItem
            // 
            this.transationToolStripMenuItem.Name = "transationToolStripMenuItem";
            this.transationToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.transationToolStripMenuItem.Text = "Transportation&Barrel  Issue & Recipt";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateVendorReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // GenerateVendorReportToolStripMenuItem
            // 
            this.GenerateVendorReportToolStripMenuItem.Name = "GenerateVendorReportToolStripMenuItem";
            this.GenerateVendorReportToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.GenerateVendorReportToolStripMenuItem.Text = "Generate vendor report";
            this.GenerateVendorReportToolStripMenuItem.Click += new System.EventHandler(this.GenerateVendorReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 641);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem districtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clustersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clusterDistrictMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rPSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GenerateVendorReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchsToolStripMenuItem;
    }
}