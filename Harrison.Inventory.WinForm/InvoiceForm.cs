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
            _invoicepresenter.SetVendorNames();
           
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setVendorValues(DataTable vendors)
        {
            VendorNamecombo.ValueMember="VENDOR_ID";
            VendorNamecombo.DisplayMember="VENDOR_NAME";         
            VendorNamecombo.DataSource=vendors;
           
          

        }
        public void setRPSValues(DataTable rpss)
        {
            RPScombo.ValueMember = "RPS_ID";
            RPScombo.DisplayMember = "RPS_NAME";
            RPScombo.DataSource = rpss;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
        
        }



       

        

        private void VendorNamecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            _invoicepresenter.SetRPSNames(VendorNamecombo.SelectedValue);
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

        private void ratetxt_TextChanged(object sender, EventArgs e)
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

        private void lumpqtytxt_TextChanged(object sender, EventArgs e)
        {
            float lumb, price,amnt;
            if (lumpqtytxt.Text == "")
                lumb = 0;
            else
            lumb = float.Parse(lumpqtytxt.Text);
            if (LumbPricetxt.Text == "")
                price = 0;
            else
                price = float.Parse(LumbPricetxt.Text);
            amnt = lumb * price;
            LumbAmnttxt.Text = amnt.ToString();

        }

        private void LumbPricetxt_TextChanged(object sender, EventArgs e)
        {
            float lumb, price, amnt;
            if (lumpqtytxt.Text == "")
                lumb = 0;
            else
                lumb = float.Parse(lumpqtytxt.Text);
            if (LumbPricetxt.Text == "")
                price = 0;
            else
                price = float.Parse(LumbPricetxt.Text);
            amnt = lumb * price;
            LumbAmnttxt.Text = amnt.ToString();

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            int moved=0,traded=0,spot_contract=0;
            if(movedcb.Checked==true)
                moved=1;
            if(tradedcb.Checked==true)
                traded=1;
            
            _invoicepresenter.AddInvoice(moved, Datetxt.Text, int.Parse(VendorNamecombo.SelectedValue.ToString()), int.Parse(RPScombo.SelectedValue.ToString()), commcombo.Text, traded, commCodecombo.Text, FrrNotxt.Text, lpcNotxt.Text, vfatxt.Text, float.Parse(barrelqtytxt.Text), float.Parse(lumpqtytxt.Text), float.Parse(emptyqtytxt.Text), float.Parse(wetwttxt.Text), float.Parse(drctxt.Text), float.Parse(ratetxt.Text), int.Parse(spot_contract.ToString()), codetxt.Text, float.Parse(drywttxt.Text), float.Parse(amnttxt.Text), float.Parse(CGSTtxt.Text), float.Parse(SGSTtxt.Text), float.Parse(tamnttxt.Text));
            MessageBox.Show("Invoice added");
        }   
    }
}

    