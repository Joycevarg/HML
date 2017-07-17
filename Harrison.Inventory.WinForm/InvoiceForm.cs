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
        int reg;
        TaxDetails tax = new TaxDetails(0, "null", "null", 0, 0);
            
        GridForm gridfrm;
        public InvoiceForm()
        {
            InitializeComponent();
            _invoicepresenter= new InvoicePresenter(this,new InvoiceServices(new InvoiceData()));
            _invoicepresenter.SetVendorNames();
            _invoicepresenter.setSpotContractNames();
            _invoicepresenter.DefaultInvoiceOrder();
          
           
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

        public void setSpotContractValues()
        {
            List<SPOT_CONTRACT> spotlist=new List<SPOT_CONTRACT>(){new SPOT_CONTRACT(1,"Spot"),new SPOT_CONTRACT(2,"Contract")};
            spotContractCombo.ValueMember = "IDMember";
            spotContractCombo.DisplayMember = "displayMember";
            spotContractCombo.DataSource = spotlist;
            
        }

        public void setRPSValues(DataTable rpss)
        {
            RPScombo.ValueMember = "RPS_ID";
            RPScombo.DisplayMember = "RPS_NAME";
            RPScombo.DataSource = rpss;
        }
        public void givearrdata(DataTable branchs)
        {
            gridfrm = new GridForm(branchs);
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            
        }
        private void VendorNamecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            reg=_invoicepresenter.VendorRegistered(VendorNamecombo.SelectedValue.ToString());
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
            int moved=0,traded=0;
            if(movedcb.Checked==true)
                moved=1;
            if(tradedcb.Checked==true)
                traded=1;
            _invoicepresenter.AddInvoice(moved, Datetxt.Text, int.Parse(VendorNamecombo.SelectedValue.ToString()), int.Parse(RPScombo.SelectedValue.ToString()), commcombo.Text, traded, commCodecombo.Text, FrrNotxt.Text, lpcNotxt.Text, vfatxt.Text, float.Parse(barrelqtytxt.Text), float.Parse(lumpqtytxt.Text), float.Parse(emptyqtytxt.Text), float.Parse(wetwttxt.Text), float.Parse(drctxt.Text), float.Parse(ratetxt.Text), int.Parse(spotContractCombo.SelectedValue.ToString()), codetxt.Text, float.Parse(drywttxt.Text), float.Parse(amnttxt.Text),float.Parse(LumbPricetxt.Text),float.Parse(LumbAmnttxt.Text),float.Parse(TotAmntNotTaxestxt.Text), float.Parse(CGSTtxt.Text), float.Parse(SGSTtxt.Text), float.Parse(TotAmntwithTaxestxt.Text));
            MessageBox.Show("Invoice added");
            FormFunctions func = new FormFunctions();
            func.ClearTextBoxes(this);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _invoicepresenter.DefaultInvoiceOrder();
            gridfrm.Show();
        }

        private void amnttxt_TextChanged(object sender, EventArgs e)
        {
            float LatexAmnt=0, LumbAmnt=0,total;
            if (amnttxt.Text == "")
                LatexAmnt = 0;
            else
                LatexAmnt = float.Parse(amnttxt.Text);
            if (LumbAmnttxt.Text == "")
                LumbAmnt = 0;
            else
                LumbAmnt = float.Parse(LumbAmnttxt.Text);
            total = LatexAmnt + LumbAmnt;

            TotAmntNotTaxestxt.Text = total.ToString();
        }

        private void LumbAmnttxt_TextChanged(object sender, EventArgs e)
        {
            float LatexAmnt = 0, LumbAmnt = 0, total;
            if (amnttxt.Text == "")
                LatexAmnt = 0;
            else
                LatexAmnt = float.Parse(amnttxt.Text);
            if (LumbAmnttxt.Text == "")
                LumbAmnt = 0;
            else
                LumbAmnt = float.Parse(LumbAmnttxt.Text);
            total = LatexAmnt + LumbAmnt;

            TotAmntNotTaxestxt.Text = total.ToString();

        }

        

        private void Datetxt_ValueChanged(object sender, EventArgs e)
        {
           tax = _invoicepresenter.GetTax(Datetxt.Text);
           float amnt = 0, cgst = 0, sgst = 0, total = 0;
           cgstpercentlbl.Text = "";
           sgstpercentlbl.Text = "";                
           if (TotAmntNotTaxestxt.Text == "")
               amnt = 0;
           else
               amnt = float.Parse(TotAmntNotTaxestxt.Text);
           if (reg == 1)
           {
               cgstpercentlbl.Text = tax.CGST.ToString() + "%";
               sgstpercentlbl.Text = tax.SGST.ToString() + "%";
               cgst = amnt * tax.CGST / 100;
               sgst = amnt * tax.SGST / 100;
               CGSTtxt.Text = cgst.ToString();
               SGSTtxt.Text = sgst.ToString();
           }
           total = amnt + cgst + sgst;
           TotAmntwithTaxestxt.Text = total.ToString();
        }

        private void TotAmntNotTaxestxt_TextChanged(object sender, EventArgs e)
        {
            float amnt=0,cgst = 0, sgst = 0, total = 0;
            cgstpercentlbl.Text = "";
            sgstpercentlbl.Text = "";
            if (TotAmntNotTaxestxt.Text == "")
                amnt = 0;
            else
                amnt = float.Parse(TotAmntNotTaxestxt.Text);
            if (reg == 1)
            {
                cgstpercentlbl.Text = tax.CGST.ToString() + "%";
                sgstpercentlbl.Text = tax.SGST.ToString() + "%";
                cgst = amnt * tax.CGST / 100;
                sgst = amnt * tax.SGST / 100;
                CGSTtxt.Text = cgst.ToString();
                SGSTtxt.Text = sgst.ToString();
            }
            total = amnt + cgst + sgst;
            TotAmntwithTaxestxt.Text = total.ToString();

        }

        private void drywttxt_TextChanged(object sender, EventArgs e)
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

    