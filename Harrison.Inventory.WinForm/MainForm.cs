using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Harrison.Inventory.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void taxDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tax_Details taxForm = new Tax_Details();
            taxForm.Show();

        }

        private void clustersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clusterMaster clusterForm = new clusterMaster();
            clusterForm.Show();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bankDetails bankForm = new bankDetails();
            bankForm.Show();
        }

        private void rPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPSdetails rpsform = new RPSdetails();
            rpsform.Show();
        }

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendorsForm vendorform = new VendorsForm();
            vendorform.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm invoice = new InvoiceForm();
            invoice.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateFrrReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  testreportform report = new testreportform();
          //  report.Show();
        }

        private void financialYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialYear finyear = new FinancialYear();
            finyear.Show();
        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StateForm statefrm = new StateForm();
            statefrm.Show();
        }

        private void districtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistrictForm district = new DistrictForm();
            district.Show();
        }

        private void branchsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            branchDetails branchform = new branchDetails();
            branchform.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }       
    }
}
