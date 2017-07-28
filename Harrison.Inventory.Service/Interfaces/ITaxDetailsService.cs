using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Service
{
    public interface ITaxDetailsService
    {
        DataTable ArrangeTaxDetails(SortType sortType, SortFieldType sortField);
        void AddTaxDetails(int finid, string effectdate,string enddate, float cgst, float sgst);
        void UpdateTaxDetails(int finid, string effectdate, string enddate, float cgst, float sgst);
        void DeleteTaxDetails(object FinYearid);
        TaxDetails TaxFromDate(DateTime invoicedate);
    }
}
