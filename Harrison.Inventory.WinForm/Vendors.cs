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
    public partial class VendorsForm : Form,IVendorView
    {
        private IVendorPresenter vendorpresenter;
        GridForm gridfrm;
            
            public VendorsForm()
        {
            InitializeComponent();
            vendorpresenter = new VendorPresenter(this, new VendorService(new VendorData()));
            
        }

            public SortType SortDirection { get; set; }
            public SortFieldType SortField { get; set; }

            public void givearrdata(DataTable vendors)
            {
                 gridfrm = new GridForm(vendors);
            }



        private void Vendors_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridbtn_Click(object sender, EventArgs e)
        {
            vendorpresenter.DefaultVendorOrder();
            gridfrm.Show();
           
        }

       
    }
}
