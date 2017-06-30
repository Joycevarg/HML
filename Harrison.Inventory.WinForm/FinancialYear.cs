using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Harrison.Inventory.Presenter;
using Harrison.Inventory.Data;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.SqlClient;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.WinForm
{
    public partial class FinancialYear : Form,IFinancialYearsView
    {

        #region//Presenter
        private IFinancialYearsPresenter _iFinancialYearsPresenter;
        #endregion

        public FinancialYear()
        {
            InitializeComponent();
            _iFinancialYearsPresenter = new FinancialYearsPresenter(this,new FinancialYearsService(new FinancialYearsDAL()));
            _iFinancialYearsPresenter.init();
         }
        public SortType SortDirection
        {
            get;
            set;
        }

        public SortFieldType SortField
        {
            get;
            set;
        }
        public void OrderFinancialYearbyFieldAndDirection(List<Harrison.Inventory.Data.Model.FinancialYears> financialYears)
        {
          //  dgvStocks.DataSource = stocks;
            FinancialYear_Grid.DataSource = financialYears;
        }

        private void Add_Fin_Year_Bttn_Click(object sender, EventArgs e)
        {

        }

       
      

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FinancialYear_Load(object sender, EventArgs e)
        {

        }
     
    }
}
