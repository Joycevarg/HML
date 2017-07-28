using System;
using System.Collections.Generic;
using System.Text;
using Harrison.Inventory.Data.Model;
namespace Harrison.Inventory.Presenter
{
    public interface IFinancialYearsPresenter
    {
        void FinancialYearsSort(SortType sortType, SortFieldType sortFieldType);
        void init();
        void AddFinancialYears(String FinYear);
        void DeleteFinYear(object FinYearid);
    }
}
