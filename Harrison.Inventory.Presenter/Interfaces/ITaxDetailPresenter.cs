using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface ITaxDetailPresenter
    {
        void DefaultTaxDetailsOrder();
        void ChangeTaxDetailsOrder(SortType sortType, SortFieldType sortField);
        void AddTaxDetails(int finid,string effectdate,string enddate,float cgst,float sgst);
        void SetFinancialYears();
        void UpdateTaxDetails(int finid, string effectdate, string enddate, float cgst, float sgst);
    }
}
