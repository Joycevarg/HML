using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Harrison.Inventory.Presenter;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.WinForm
{
    public partial class PaymentInfoForm : Form,IPaymentInfoView
    {
        IPaymentInfoPresenter _paymentinfopresenter; 
        GridForm gridview;
        float total, HO, OtDeb;
        public PaymentInfoForm()
        {
            InitializeComponent();
            _paymentinfopresenter = new PaymentInfoPresenter(this, new PaymentInfoService(new PaymentInfoData()));
           _paymentinfopresenter.SetInvoiceIDs();
            
            
        }
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }
        public void givearrdata(DataTable paymentinfos)
        {
           gridview = new GridForm(paymentinfos);
            
        }
        public void SetInvoiceValues(DataTable invoices)
        {
            InvNoCombo.ValueMember = "INVOICE_ID";
            InvNoCombo.DisplayMember = "INVOICE_ID";
            InvNoCombo.DataSource=invoices;
            InvNoCombo.FormatString = "INV0000";
        }
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paymentInfo_Load(object sender, EventArgs e)
        {

        }

        private void HOtxt_TextChanged(object sender, EventArgs e)
        {
            bool hoval=float.TryParse(HOtxt.Text, out HO);
            if (hoval || string.IsNullOrWhiteSpace(HOtxt.Text))
            {
                hoerrlbl.Text = "";
            }
            else {
                hoerrlbl.Text = "Invalid input";
            }
            total=HO+OtDeb;
            TotAmntPaidtxt.Text=total.ToString();
        }

        private void OtherDebittxt_TextChanged(object sender, EventArgs e)
        {
            bool otdebval=float.TryParse(OtherDebittxt.Text, out OtDeb);
            if (otdebval || string.IsNullOrWhiteSpace(OtherDebittxt.Text))
            {
                otdeberrlbl.Text = "";
            }
            else 
            {
                otdeberrlbl.Text = "Invalid input";
            }
            total = HO + OtDeb;
            TotAmntPaidtxt.Text = total.ToString();
        }

        private void TotAmntPaidtxt_TextChanged(object sender, EventArgs e)
        {
            float topay, due, paid;
            if(string.IsNullOrWhiteSpace(TotaltoPaytxt.Text))
            topay=0;
            else
                topay=float.Parse(TotaltoPaytxt.Text);
            if(string.IsNullOrWhiteSpace(TotAmntPaidtxt.Text))
                paid=0;
            else
                paid=float.Parse(TotAmntPaidtxt.Text);
            due = topay-paid;
            Balancetxt.Text = due.ToString();
        }

        private void gridbtn_Click(object sender, EventArgs e)
        {
            _paymentinfopresenter.DefaultPaymentInfoOrder();
            gridview.Show();
            
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            float.TryParse(OtherDebittxt.Text, out OtDeb);
            float.TryParse(HOtxt.Text, out HO);
            _paymentinfopresenter.AddPaymentInfo(int.Parse(InvNoCombo.SelectedValue.ToString()),0, paymentdatetxt.Value.ToString("yyyy-MM-dd"), float.Parse(TotaltoPaytxt.Text),HO, OtDeb, PaymentModeCombo.Text,float.Parse(TotAmntPaidtxt.Text), float.Parse(Balancetxt.Text), Remarktxt.Text);
            MessageBox.Show("Payment added");
            FormFunctions form = new FormFunctions();
            form.ClearTextBoxes(this);
            TotAmntPaidtxt.Text = "0";
            Balancetxt.Text = "0";
        }

     
        private void InvNoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
         int invid = int.Parse(InvNoCombo.SelectedValue.ToString());
         _paymentinfopresenter.SetVendorName(invid);   
        _paymentinfopresenter.SetToPayAmnt(invid);
        }

        private void PaymentModeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SetVendorName(string vendorname)
        {
            VendorNametxt.Text = vendorname;
        }
        public void SetToPayAmount(float topayamnt)
        {
            TotaltoPaytxt.Text = topayamnt.ToString();
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
