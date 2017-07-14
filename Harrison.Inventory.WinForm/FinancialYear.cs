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
using System.Text.RegularExpressions;

namespace Harrison.Inventory.WinForm
{
    public partial class FinancialYear : Form,IFinancialYearsView
    {

        #region//Presenter
        private IFinancialYearsPresenter _iFinancialYearsPresenter;
        static bool flag = true;
        #endregion

        public FinancialYear()
        {
           
            InitializeComponent();
            _iFinancialYearsPresenter = new FinancialYearsPresenter(this,new FinancialYearsService(new FinancialYearsDAL()));
            _iFinancialYearsPresenter.init();
           
           this.finYeartxt.TextChanged+=new EventHandler(finYeartxt_TextChanged);

            
         }
        private void finYeartxt_TextChanged(object sender, EventArgs e)
        {
            
            finYeartxt.MaxLength = 9;

            if (finYeartxt.TextLength == 4 && flag)
            {
                finYeartxt.Text += "-";
                finYeartxt.SelectionStart = finYeartxt.TextLength;
                      flag = false;
            }
            else if (finYeartxt.TextLength == 3)
                    flag = true;
                
           
            
        
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
        public void OrderFinancialYearbyFieldAndDirection(DataTable financialYears)
        {
          //  dgvStocks.DataSource = stocks;
            FinancialYear_Grid.DataSource = financialYears;
        }




        private void Add_Fin_Year_Bttn_Click(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9-]{9}$");
            String FinyearText = finYeartxt.Text;
            if (string.IsNullOrEmpty(FinyearText))
                MessageBox.Show("Enter a value");
            
            else if(!r.IsMatch(FinyearText))
            {
                MessageBox.Show("Invalid Characters.Only [0-9],- are allowed");
            }
            else if (finYeartxt.Text[4] != '-')

                MessageBox.Show("Invalid Format.[YYYY-YYYY]");
            else
            {
                _iFinancialYearsPresenter.AddFinancialYears(FinyearText);
                _iFinancialYearsPresenter.init();
                MessageBox.Show("Financial Year added!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FinancialYear_Load(object sender, EventArgs e)
        {

        }

        private void FinancialYear_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
    }
}
