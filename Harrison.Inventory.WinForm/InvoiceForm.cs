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
using System.Text.RegularExpressions;

namespace Harrison.Inventory.WinForm
{
    public partial class InvoiceForm : Form,IInvoiceView
        
    {   IInvoicePresenter _invoicepresenter;
        int reg;
        TaxDetails tax = new TaxDetails(0, "null", "null", 0, 0);
        float wetwt, drywt, drc, rate, dwt, amnt,lumb, price;
        GridForm gridfrm;
        public InvoiceForm()
        {
            InitializeComponent();
            _invoicepresenter= new InvoicePresenter(this,new InvoiceServices(new InvoiceData()));
            _invoicepresenter.SetVendorNames();
            _invoicepresenter.setSpotContractNames();
            _invoicepresenter.DefaultInvoiceOrder();
            _invoicepresenter.setInvID();
           

        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setVendorValues(DataTable vendors)
        {
            VendorNamecombo.ValueMember="VENDOR_ID";
            VendorNamecombo.DisplayMember="VENDOR NAME";         
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
        public void givearrdata(DataTable invoices)
        {
            Invoicegrid.DataSource = invoices;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            
        }
        public void setID(string id)
        {
            Invoicelbl.Text = id;
        
        }
        private void VendorNamecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            reg=_invoicepresenter.VendorRegistered(VendorNamecombo.SelectedValue.ToString());
            _invoicepresenter.SetRPSNames(VendorNamecombo.SelectedValue);
        }

        private void wetwttxt_TextChanged(object sender, EventArgs e)
        {
            bool wetwtval = float.TryParse(this.wetwttxt.Text, out wetwt);
            if (wetwtval||(string.IsNullOrWhiteSpace(this.wetwttxt.Text)))
                wetwterrlbl.Text = "";
            else
                wetwterrlbl.Text = "Invalid input";
            drywt = drc * wetwt / 100;
            drywttxt.Text = drywt.ToString();
        }

        private void drctxt_TextChanged(object sender, EventArgs e)
        {
            bool drcval = float.TryParse(this.drctxt.Text, out drc);
            if (drcval || (string.IsNullOrWhiteSpace(this.drctxt.Text)))
                drcerrlbl.Text = "";
            else
                drcerrlbl.Text = "Invalid input";
            drywt = drc * wetwt / 100;
            drywttxt.Text = drywt.ToString();
        }

        private void ratetxt_TextChanged(object sender, EventArgs e)
        {
            bool rateval = float.TryParse(this.ratetxt.Text, out rate);
            if (rateval || (string.IsNullOrWhiteSpace(this.ratetxt.Text)))
                rateerrlbl.Text = "";
            else
                rateerrlbl.Text = "Invalid input";
            amnt = dwt * rate;
            amnttxt.Text = amnt.ToString();
        }
        private void drywttxt_TextChanged(object sender, EventArgs e)
        {

            bool dryval = float.TryParse(this.drywttxt.Text, out dwt);                
            amnt = dwt * rate;
            amnttxt.Text = amnt.ToString();
        }

        private void lumpqtytxt_TextChanged(object sender, EventArgs e)
        {
            bool lqtyerrval = float.TryParse(this.lumpqtytxt.Text, out lumb);
            if (lqtyerrval || (string.IsNullOrWhiteSpace(this.lumpqtytxt.Text)))
                lumbqtyerrlbl.Text = "";
            else
                lumbqtyerrlbl.Text = "Invalid input";
            amnt = lumb * price;
            LumbAmnttxt.Text = amnt.ToString();

        }

        private void LumbPricetxt_TextChanged(object sender, EventArgs e)
        {
            bool lpriceval = float.TryParse(this.LumbPricetxt.Text, out price);
            if (lpriceval ||(string.IsNullOrWhiteSpace(this.LumbPricetxt.Text)))
                lumbpriceerrlbl.Text = "";
            else
                lumbpriceerrlbl.Text = "Invalid input";
            amnt = lumb * price;
            LumbAmnttxt.Text = amnt.ToString();

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            int barrel=0,lump=0,empty=0,moved=0,traded=0,rps=0;
            float cgst=0,sgst=0;
            if(movedcb.Checked==true)
                moved=1;
            if(tradedcb.Checked==true)
                traded=1;
            if (!string.IsNullOrWhiteSpace(CGSTtxt.Text))
                cgst = float.Parse(CGSTtxt.Text);
            if (!string.IsNullOrWhiteSpace(SGSTtxt.Text))
                sgst = float.Parse(SGSTtxt.Text);
            if (RPScombo.SelectedValue != null)
                rps = int.Parse(RPScombo.SelectedValue.ToString());
            if (!string.IsNullOrWhiteSpace(barrelqtytxt.Text))
                int.TryParse(barrelqtytxt.Text,out barrel);
            if (!string.IsNullOrWhiteSpace(lumpqtytxt.Text))
                int.TryParse(lumpqtytxt.Text,out lump);
            if (!string.IsNullOrWhiteSpace(emptyqtytxt.Text))
                int.TryParse(emptyqtytxt.Text,out empty);
            float.TryParse(this.wetwttxt.Text, out wetwt);
            float.TryParse(this.drctxt.Text, out drc);
            float.TryParse(this.ratetxt.Text, out rate);
            float.TryParse(this.drywttxt.Text, out dwt);
            float.TryParse(this.LumbPricetxt.Text, out price);
            _invoicepresenter.AddInvoice(moved, Datetxt.Value.ToString("yyyy-MM-dd"), int.Parse(VendorNamecombo.SelectedValue.ToString()), rps, commcombo.Text, traded, commCodecombo.Text, FrrNotxt.Text, lpcNotxt.Text, vfatxt.Text, barrel,lump,empty, wetwt, drc, rate, int.Parse(spotContractCombo.SelectedValue.ToString()), codetxt.Text, dwt, float.Parse(amnttxt.Text), price, float.Parse(LumbAmnttxt.Text), float.Parse(TotAmntNotTaxestxt.Text), cgst,sgst, float.Parse(TotAmntwithTaxestxt.Text));
            MessageBox.Show("Invoice added");
            FormFunctions func = new FormFunctions();
            func.ClearTextBoxes(this);
            _invoicepresenter.DefaultInvoiceOrder();
            _invoicepresenter.setInvID();
           
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

        private void barrelqtytxt_TextChanged(object sender, EventArgs e)
        { 
            int barelqty;
            if (int.TryParse(this.barrelqtytxt.Text, out barelqty)||string.IsNullOrWhiteSpace(barrelqtytxt.Text))
                brlqtyerrlbl.Text = "";
            else
                brlqtyerrlbl.Text = "Invalid input";
        }

        private void emptyqtytxt_TextChanged(object sender, EventArgs e)
        {

            int empqty;
            if (int.TryParse(this.emptyqtytxt.Text, out empqty) || string.IsNullOrWhiteSpace(emptyqtytxt.Text))
                empqtyerrlbl.Text = "";
            else
                empqtyerrlbl.Text = "Invalid input";
        }


     
            
    }
}

    