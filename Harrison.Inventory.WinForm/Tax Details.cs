using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Harrison.Inventory.Presenter;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;
namespace Harrison.Inventory.WinForm
{
    public partial class Tax_Details : Form,ITaxDetailsView
    {
        
        ITaxDetailPresenter taxpresenter;
        public Tax_Details()
        {
            taxpresenter = new TaxDetailsPresenter(this, new TaxDetailsService(new TaxDetailsData()));
            InitializeComponent();
            taxpresenter.DefaultTaxDetailsOrder();
            taxpresenter.SetFinancialYears();
            effectDate.Value = DateTime.Today;
        }
        public void givearrdata(DataTable taxdetails)
      
        {
            taxgrid.DataSource = taxdetails;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            taxpresenter.AddTaxDetails(int.Parse(finYeartxt.SelectedValue.ToString()), effectDate.Value.ToString("yyyy-MM-dd"),endDate.Value.ToString("yyyy-MM-dd"), float.Parse(CGSTtxt.Text), float.Parse(SGSTtxt.Text));
            MessageBox.Show("Tax details added");
            FormFunctions func = new FormFunctions();
            func.ClearTextBoxes(this);
        }

        private void Tax_Details_Load(object sender, EventArgs e)
        {

        }
        public void setFinancialYears(DataTable finyears)
        {
            finYeartxt.ValueMember = "FIN_YEAR_ID";
            finYeartxt.DisplayMember = "FIN_YEAR_NAME";
            finYeartxt.DataSource = finyears;
        }

       

        private void effectDate_ValueChanged(object sender, EventArgs e)
        {
            string enddate,eff;
            eff = effectDate.Value.ToString("yyyy-MM-dd");
            if (int.Parse(eff.Substring(5, 2)) < 3)
            {
                enddate = eff.Substring(0, 4) + "-03-31";
            }
            else
            {
                enddate = (int.Parse(eff.Substring(0, 4)) + 1).ToString() + "-03-31";            
            }
            endDate.Text = enddate;
        }

    }
}