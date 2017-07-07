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
        GridForm gridfrm;
 
        public branchDetails()
        {
            InitializeComponent();
            branchpresenter = new BranchPresenter(this, new BranchServices(new BranchData()));
            
        }
        public SortType SortDirection { get; set; }
        public SortFieldType SortField { get; set; }


        private void branchDetails_Load(object sender, EventArgs e)
        {

        }
        public void givearrdata(DataTable branchs)
        {
            gridfrm = new GridForm(branchs);
        }
        private void gridbtn_Click(object sender, EventArgs e)
        {
            branchpresenter.DefaultBranchOrder();
            gridfrm.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
