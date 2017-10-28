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
        private object ID;
        
        public bankDetails()
        {
            InitializeComponent();
            _bankpresenter = new BankPresenter(this, new BankServices(new BankData()));
            _bankpresenter.DefaultBankOrder();
            this.bankgrid.Columns[0].Visible = false;

        }
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }
       


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
                 FormFunctions func = new FormFunctions();
                 func.ClearTextBoxes(this);
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

       
        private void bankgrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            edtbtn.Enabled = true;
            dltbtn.Enabled = true;
            ID = bankgrid.Rows[e.RowIndex].Cells[0].Value;
            bankNametxt.Text = bankgrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            _bankpresenter.DeleteBank(ID);
            MessageBox.Show(bankNametxt.Text + " is deleted");
            _bankpresenter.DefaultBankOrder();
        }

        private void edtbtn_Click(object sender, EventArgs e)
        {
            _bankpresenter.UpdateBank(int.Parse(ID.ToString()), bankNametxt.Text);
            _bankpresenter.DefaultBankOrder();
            bankNametxt.Text = "";
        }

    }
}
