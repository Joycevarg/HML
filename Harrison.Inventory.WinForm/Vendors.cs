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
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Harrison.Inventory.WinForm
{
    public partial class VendorsForm : Form,IVendorView
    {
        private IVendorPresenter vendorpresenter;
        
            
            public VendorsForm()
        {
            InitializeComponent();
            vendorpresenter = new VendorPresenter(this, new VendorService(new VendorData()));
            vendorpresenter.setHstateNames();
            vendorpresenter.setEstateNames();
            vendorpresenter.setBankNames();
            vendorpresenter.DefaultVendorOrder();
            ownerNotxt.MaxLength = 10;
            tapperNotxt.MaxLength = 10;
        }

            public SortType SortDirection { get; set; }
            public SortFieldType SortField { get; set; }

            public void givearrdata(DataTable vendors)
            {
                vendorgrid.DataSource = vendors;
            }
          

        private void Vendors_Load(object sender, EventArgs e)
        {

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        public void setHStateValues(DataTable states)
        {
            hstatecombo.ValueMember = "STATE_ID";
            hstatecombo.DisplayMember = "STATE_NAME";
            hstatecombo.DataSource = states;
        }
        public void setEStateValues(DataTable states)
        {
            estatecombo.ValueMember = "STATE_ID";
            estatecombo.DisplayMember = "STATE_NAME";
            estatecombo.DataSource = states;
        }
        public void setHDistrictValues(DataTable districts)
        {
            hdistrictcombo.ValueMember = "DISTRICT_ID";
            hdistrictcombo.DisplayMember = "DISTRICT_NAME";
            hdistrictcombo.DataSource = districts;
        }
        public void setEDistrictValues(DataTable districts)
        {
            edistrictcombo.ValueMember = "DISTRICT_ID";
            edistrictcombo.DisplayMember = "DISTRICT_NAME";
            edistrictcombo.DataSource = districts;
            
        }
        public void setBankValues(DataTable banks)
        {
            Bankcombo.ValueMember = "BANK_ID";
            Bankcombo.DisplayMember = "BANK_NAME";
            Bankcombo.DataSource = banks;

        }
        public void setBranchValues(DataTable branchs)
        {
            Branchcombo.ValueMember = "BRANCH_ID";
            Branchcombo.DisplayMember = "BRANCH_NAME";
            Branchcombo.DataSource = branchs;
        }

        private void hstatecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
          vendorpresenter.setHdistrictNames(hstatecombo.SelectedValue);
        }

        private void estatecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendorpresenter.setEdistrictNames(estatecombo.SelectedValue);
            
        }
        private object ID;
        private void vendorgrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editbtn.Enabled = true;
            dltbtn.Enabled = true;
            ID = vendorgrid.Rows[e.RowIndex].Cells[0].Value;
           ventorNametxt.Text = vendorgrid.Rows[e.RowIndex].Cells[1].Value.ToString();
           homeAddresstxt.Text=vendorgrid.Rows[e.RowIndex].Cells[2].Value.ToString();
           hdistrictcombo.SelectedValue=vendorgrid.Rows[e.RowIndex].Cells[3].Value;
           hstatecombo.SelectedValue=vendorgrid.Rows[e.RowIndex].Cells[4].Value.ToString();
           estateAddresstxt.Text=vendorgrid.Rows[e.RowIndex].Cells[5].Value.ToString();
           edistrictcombo.SelectedValue=vendorgrid.Rows[e.RowIndex].Cells[6].Value;
           estatecombo.SelectedValue=vendorgrid.Rows[e.RowIndex].Cells[7].Value;
           oAddresstxt.Text=vendorgrid.Rows[e.RowIndex].Cells[8].Value.ToString();
           tapperNotxt.Text=vendorgrid.Rows[e.RowIndex].Cells[9].Value.ToString();
           occuptxt.Text=vendorgrid.Rows[e.RowIndex].Cells[10].Value.ToString();
           ownerNotxt.Text=vendorgrid.Rows[e.RowIndex].Cells[11].Value.ToString();
           LicenNotxt.Text= vendorgrid.Rows[e.RowIndex].Cells[13].Value.ToString();
           TinNotxt.Text= vendorgrid.Rows[e.RowIndex].Cells[14].Value.ToString();
           cstNotxt.Text=vendorgrid.Rows[e.RowIndex].Cells[15].Value.ToString();
           remarktxt.Text=vendorgrid.Rows[e.RowIndex].Cells[16].Value.ToString();
           Bankcombo.SelectedValue = vendorgrid.Rows[e.RowIndex].Cells[20].Value;
           Branchcombo.SelectedValue = vendorgrid.Rows[e.RowIndex].Cells[21].Value;
           acctxt.Text = vendorgrid.Rows[e.RowIndex].Cells[22].Value.ToString();
           if (vendorgrid.Rows[e.RowIndex].Cells[23].Value.ToString() == "1")
           {
               regcheckbox.Checked = true;
               if (vendorgrid.Rows[e.RowIndex].Cells[22].Value.ToString() == "1")
                   growerRbtn.Checked = true;
               else if (vendorgrid.Rows[e.RowIndex].Cells[22].Value.ToString() == "2")
                   dealerRbtn.Checked = false;
           }
           else
               {   regcheckbox.Checked = false;
               growerRbtn.Checked = true;
               }
           }

        private void savebtn_Click(object sender, EventArgs e)
        {
            int dealer_grower,register;//if dealer-2,grower-1
            Regex phone = new Regex("^[0-9]{10}$");
           
            if (growerRbtn.Checked == true)
                dealer_grower = 1;
            else
                dealer_grower = 2;
            if (regcheckbox.Checked == true)
                register = 1;
            else
                register = 0;
            if (string.IsNullOrWhiteSpace(ventorNametxt.Text))
                MessageBox.Show("Enter the Name");
            else if (!phone.IsMatch(ownerNotxt.Text))
                MessageBox.Show("Owner phone number has insufficient digits");
            else if (!phone.IsMatch(tapperNotxt.Text))
                MessageBox.Show("Tapper phone number has insufficient digits");
            else
            {
                vendorpresenter.AddVendor(ventorNametxt.Text, homeAddresstxt.Text, int.Parse(hdistrictcombo.SelectedValue.ToString()), int.Parse(hstatecombo.SelectedValue.ToString()), estateAddresstxt.Text, int.Parse(edistrictcombo.SelectedValue.ToString()), int.Parse(estatecombo.SelectedValue.ToString()), oAddresstxt.Text, tapperNotxt.Text, occuptxt.Text, ownerNotxt.Text, dealer_grower, LicenNotxt.Text, TinNotxt.Text, cstNotxt.Text, remarktxt.Text, DateTime.Now.Date.ToString("yyyy-MM-dd"), DateTime.Now.Date.ToString("yyyy-MM-dd"), "notnow", int.Parse(Bankcombo.SelectedValue.ToString()), int.Parse(Branchcombo.SelectedValue.ToString()), acctxt.Text, register);
                MessageBox.Show("Vendor added");
                FormFunctions func = new FormFunctions();
                func.ClearTextBoxes(this);
            }
  

        }
       
        private void Bankcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendorpresenter.setBranchNames(Bankcombo.SelectedValue);
        }

        private void rgstrchkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (regcheckbox.Checked == false)
            {
                dealerRbtn.Enabled = false;
                LicenNotxt.Enabled = false;
                TinNotxt.Enabled = false;
                cstNotxt.Enabled = false;
                remarktxt.Enabled = false;
                growerRbtn.Checked = true;
                LicenNotxt.Text = "";
                TinNotxt.Text = "";
                cstNotxt.Text = "";
            }
            else
            {
                dealerRbtn.Enabled = true;
                LicenNotxt.Enabled = true;
                TinNotxt.Enabled = true;
                cstNotxt.Enabled = true;
                remarktxt.Enabled = true;
            }
        }

     
       

        
       
    }
}
