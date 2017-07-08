using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Harrison.Inventory.Data.SqlClient;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Presenter;

namespace Harrison.Inventory.WinForm
{
    public partial class InvoiceForm : Form,IInvoiceView
        
    {   IInvoicePresenter _invoicepresenter;
        public InvoiceForm()
        {
            InitializeComponent();
            _invoicepresenter= new InvoicePresenter(this,new InvoiceServices(new InvoiceData()));
            _invoicepresenter.SetVendorValues();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setVendorNames(DataTable vendors)
        {
          VendorNamecombo.DataSource=vendors;
          VendorNamecombo.DisplayMember="VENDOR_NAME";
          VendorNamecombo.ValueMember="VENDOR_ID";

        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
        
        }

        private void wetwttxt_TextChanged(object sender, EventArgs e)
        {
            float wetwt, drywt, drc;
            if (this.drctxt.Text == "")
                drc = 0;
            else
                drc = float.Parse(this.drctxt.Text);
            if (this.wetwttxt.Text == "")
                wetwt = 0;
            else
                wetwt = float.Parse(this.wetwttxt.Text);
            drywt = drc * wetwt / 100;
            drywttxt.Text = drywt.ToString();
        }

        private void drctxt_TextChanged(object sender, EventArgs e)
        {
             float wetwt,drywt,drc;
             if (this.drctxt.Text == "")
                 drc = 0;
             else
             {
                 drc = float.Parse(this.drctxt.Text);
                
             }
             if (this.wetwttxt.Text == "")
                 wetwt = 0;
             else
                 wetwt = float.Parse(this.wetwttxt.Text);
             drywt = drc * wetwt / 100;
             drywttxt.Text = drywt.ToString();
             
        }

        private void ratekg_TextChanged(object sender, EventArgs e)
        {
            float rate, dwt, amnt;
            if (this.drywttxt.Text == "")
                dwt = 0;
            else
                dwt = float.Parse(this.drywttxt.Text);
            if (this.ratetxt.Text == "")
                rate = 0;
            else
                rate = float.Parse(this.ratetxt.Text);
            amnt = dwt * rate;
            amnttxt.Text = amnt.ToString();
        }

       
}
        
            }

    