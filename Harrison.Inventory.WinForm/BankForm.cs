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
    public partial class bankDetails : Form,IBankView
    {
        private IBankPresenter _bankpresenter;
        public bankDetails()
        {
            InitializeComponent();
            _bankpresenter = new BankPresenter(this, new BankServices(new BankData()));
            _bankpresenter.DefaultBankOrder();

        }
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }
       

        private void addBank_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void modifyBank_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void removeBank_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bankNametxt.Text))
                MessageBox.Show("Enter a Name");
            else
            {
                _bankpresenter.AddBank(bankNametxt.Text);
                 MessageBox.Show("Bank added");
                _bankpresenter.DefaultBankOrder();
                
            
            }
        }

        private void bankDetails_Load(object sender, EventArgs e)
        {

        }
        public void givearrdata(DataTable banks)
        {
            bankgrid.DataSource = banks;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            branchDetails branchform = new branchDetails();
            branchform.Show();
   

        }

       
    }
}
