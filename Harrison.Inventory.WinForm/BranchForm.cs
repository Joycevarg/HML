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
    public partial class branchDetails : Form,IBranchView
    {
        private IBranchPresenter branchpresenter;
        private object ID;
 
        public branchDetails()
        {
            InitializeComponent();
            branchpresenter = new BranchPresenter(this, new BranchServices(new BranchData()));
            branchpresenter.setBankNames();
            branchpresenter.DefaultBranchOrder();
        }
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }


        private void branchDetails_Load(object sender, EventArgs e)
        {

        }
        public void setBankValues(DataTable banks)
        {
          
            bankcombo.ValueMember="BANK_ID";
            bankcombo.DisplayMember = "BANK_NAME";
            bankcombo.DataSource = banks; 

        
        }

        public void givearrdata(DataTable branchs)
        {
            branchgrid.DataSource = branchs;
        }
       

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(branchnametxt.Text))
                MessageBox.Show("Enter a name");
            else if (string.IsNullOrWhiteSpace(ifsctxt.Text))
                MessageBox.Show("Enter the ifsc code");
            else
            {
                branchpresenter.AddBranch(branchnametxt.Text, int.Parse(bankcombo.SelectedValue.ToString()), ifsctxt.Text, bankaddresstxt.Text, contacttxt.Text);
                MessageBox.Show("Branch added");
                branchpresenter.DefaultBranchOrder();
                FormFunctions func = new FormFunctions();
                func.ClearTextBoxes(this);

            }

        }
        private void branchgrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            edtbtn.Enabled = true;
            dltbtn.Enabled = true;
            ID = branchgrid.Rows[e.RowIndex].Cells[0].Value;
            branchnametxt.Text = branchgrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            bankcombo.SelectedValue = branchgrid.Rows[e.RowIndex].Cells[2].Value;
            ifsctxt.Text = branchgrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            bankaddresstxt.Text = branchgrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            contacttxt.Text=branchgrid.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private void edtbtn_Click(object sender, EventArgs e)
        {
            branchpresenter.UpdateBranch(int.Parse(ID.ToString()), branchnametxt.Text, int.Parse(bankcombo.SelectedValue.ToString()), ifsctxt.Text, bankaddresstxt.Text, contacttxt.Text);
            branchpresenter.DefaultBranchOrder();
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            branchpresenter.DeleteBranch(ID);
            branchpresenter.DefaultBranchOrder();
        }
    }
}
