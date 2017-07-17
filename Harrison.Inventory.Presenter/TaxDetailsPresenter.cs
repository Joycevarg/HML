using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Presenter
{
    public class TaxDetailsPresenter:ITaxDetailPresenter
    {
        public ITaxDetailsView taxdetailsview;
        public ITaxDetailsService taxdetailsservice;
        public IFinancialYearsService ifinancialyearservice;

        public TaxDetailsPresenter(ITaxDetailsView taxview,ITaxDetailsService taxservice)
        {
            taxdetailsview=taxview;
            taxdetailsservice=taxservice;
            ifinancialyearservice = new FinancialYearsService(new FinancialYearsDAL());
        }
        public void DefaultTaxDetailsOrder()
        {
            taxdetailsview.givearrdata(taxdetailsservice.ArrangeTaxDetails(SortType.Ascending, SortFieldType.Id));
        }
        public void ChangeTaxDetailsOrder(SortType srttype, SortFieldType srtfield)
        {
            taxdetailsview.givearrdata(taxdetailsservice.ArrangeTaxDetails(srttype,srtfield));
        }
        public void AddTaxDetails(int finid, string effectdate,string enddate, float cgst, float sgst)
        {

            taxdetailsservice.AddTaxDetails(finid, effectdate,enddate, cgst, sgst);

        }
        public void SetFinancialYears()
        {
            taxdetailsview.setFinancialYears(ifinancialyearservice.GetAllFinancialYears(SortType.Ascending, SortFieldType.Id));
        }
    }
}
