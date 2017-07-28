using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;
using System.Data;

namespace Harrison.Inventory.Service
{
    public interface IFinancialYearsService
    {

        DataTable GetAllFinancialYears(SortType sortType, SortFieldType sortField);
        void AddFinancialYears(String FinYear);
        void DeleteFinancialYear(object FinYearid);
    }
}
