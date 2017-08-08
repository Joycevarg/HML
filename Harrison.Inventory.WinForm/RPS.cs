using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;
using Harrison.Inventory.Presenter;
using Harrison.Inventory.Service;

namespace Harrison.Inventory.WinForm
{
    public partial class RPSdetails : Form, IRPSView
    {
        private IRPSPresenter rpspresenter;
        GridForm gridfrm;
        public RPSdetails()
        {
            InitializeComponent();
            rpspresenter = new RPSPresenter(this, new RPSServices(new RPSData()));
            rpspresenter.setVendorNames();
            rpspresenter.DefaultRPSOrder();
        }

        private void RPS_Load(object sender, EventArgs e)
        {

        }
        private void rpsgrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            VendorNameCombo.SelectedValue=rpsgrid.Rows[e.RowIndex].Cells[1].Value;
            rpsNametxt.Text = rpsgrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            contactNametxt.Text=rpsgrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            contactNotxt.Text= rpsgrid.Rows[e.RowIndex].Cells[4].Value.ToString(); 
            routeDetlstxt.Text= rpsgrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            remarktxt.Text=rpsgrid.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        public void setVendorValues(DataTable vendors)
        {
            VendorNameCombo.ValueMember = "VENDOR_ID";
            VendorNameCombo.DisplayMember = "VENDOR_NAME";
            VendorNameCombo.DataSource = vendors;

        }
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }

        public void givearrdata(DataTable rpss)
        {
            rpsgrid.DataSource = rpss;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void donebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rpsNametxt.Text))
                MessageBox.Show("Enter a name");
            else
            {
                rpspresenter.AddRPS(int.Parse(VendorNameCombo.SelectedValue.ToString()), rpsNametxt.Text, contactNametxt.Text, contactNotxt.Text, routeDetlstxt.Text, remarktxt.Text);
                MessageBox.Show("RPS added");
                FormFunctions func = new FormFunctions();
                func.ClearTextBoxes(this);
            }



        }
    }
}
