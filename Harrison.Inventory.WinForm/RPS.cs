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
        object ID;
        public RPSdetails()
        {
            InitializeComponent();
            rpspresenter = new RPSPresenter(this, new RPSServices(new RPSData()));
            rpspresenter.setVendorNames();
            rpspresenter.DefaultRPSOrder();
            this.rpsgrid.Columns[0].Visible = false;
            this.rpsgrid.Columns[1].Visible = false;
        }

        private void RPS_Load(object sender, EventArgs e)
        {

        }
        private void rpsgrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            edtbtn.Enabled = true;
            rmvbtn.Enabled = true;
            ID = rpsgrid.Rows[e.RowIndex].Cells[0].Value;
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
            VendorNameCombo.DisplayMember = "VENDOR NAME";
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

        private void edtbtn_Click(object sender, EventArgs e)
        {
            rpspresenter.UpdateRPS(int.Parse(ID.ToString()),int.Parse(VendorNameCombo.SelectedValue.ToString()), rpsNametxt.Text, contactNametxt.Text, contactNotxt.Text, routeDetlstxt.Text, remarktxt.Text);
            rpspresenter.DefaultRPSOrder();
        }

        private void rmvbtn_Click(object sender, EventArgs e)
        {
            rpspresenter.DeleteRPS(ID);
            rpspresenter.DefaultRPSOrder();
        }
    }
}
