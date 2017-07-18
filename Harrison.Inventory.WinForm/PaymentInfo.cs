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
        IPaymentInfoPresenter paymentinfopresenter; GridForm gridview;
        public PaymentInfoForm()
        {
            InitializeComponent();
            paymentinfopresenter = new PaymentInfoPresenter(this, new PaymentInfoService(new PaymentInfoData()));
            
            
        }
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }
        public void givearrdata(DataTable paymentinfos)
        {
           gridview = new GridForm(paymentinfos);
            
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
            float total, HO, OtDeb;
            if (string.IsNullOrWhiteSpace(HOtxt.Text))
                HO = 0;
            else
                HO=float.Parse(HOtxt.Text);
            if(string.IsNullOrWhiteSpace(OtherDebittxt.Text))
                OtDeb=0;
            else
                OtDeb=float.Parse(OtherDebittxt.Text);
            total=HO+OtDeb;
            TotAmntPaidtxt.Text=total.ToString();
        }

        private void OtherDebittxt_TextChanged(object sender, EventArgs e)
        {
            float total, HO, OtDeb;
            if (string.IsNullOrWhiteSpace(HOtxt.Text))
                HO = 0;
            else
                HO = float.Parse(HOtxt.Text);
            if (string.IsNullOrWhiteSpace(OtherDebittxt.Text))
                OtDeb = 0;
            else
                OtDeb = float.Parse(OtherDebittxt.Text);
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
            paymentinfopresenter.DefaultPaymentInfoOrder();
            gridview.Show();
            
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            paymentinfopresenter.AddPaymentInfo(0,0, paymentdatetxt.Value.ToString("yyyy-MM-dd"), 0, float.Parse(HOtxt.Text), float.Parse(OtherDebittxt.Text), PaymentModeCombo.Text, 0, float.Parse(Balancetxt.Text), Remarktxt.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

     
    }
}
