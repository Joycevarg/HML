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
            bankNametxt.Text = bankgrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void edtbtn_Click(object sender, EventArgs e)
        {
            
        }

    }
}
