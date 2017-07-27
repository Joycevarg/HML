using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;
using Harrison.Inventory.Presenter;

namespace Harrison.Inventory.WinForm
{
    public partial class VendorReportForm : Form,IVendorReportView
    {
        IVendorReportPresenter vendorreportpresenter;
        public VendorReportForm()
        {
            InitializeComponent();
            vendorreportpresenter = new VendorReportPresenter(this);
            vendorreportpresenter.SetVendorNames();

        }

        private void VendorReportForm_Load(object sender, EventArgs e)
        {

        }

        public void SetVendorValues(DataTable vendors)
        {
            VendorNameCombo.ValueMember = "VENDOR_ID";
            VendorNameCombo.DisplayMember = "VENDOR_NAME";
            VendorNameCombo.DataSource = vendors;
        }

        private void AllDateschkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AllDateschkbox.Checked == true)
            {
                FromDatetxt.Enabled = false;
                ToDatetxt.Enabled = false;
            }
            else
            {
                FromDatetxt.Enabled = true;
                ToDatetxt.Enabled = true;
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Generbtn_Click(object sender, EventArgs e)
        {
            if (AllDateschkbox.Checked == false)
                vendorreportpresenter.GenerateReport(VendorNameCombo.SelectedValue, FromDatetxt.Value, ToDatetxt.Value);
            else
                vendorreportpresenter.GenerateReport(VendorNameCombo.SelectedValue);
        }
    }
}
