using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;
using System.Data;

namespace Harrison.Inventory.Presenter
{       
    public interface IFinancialYearsView
    {
        SortType SortDirection{get;set;}
        SortFieldType SortField { get; set; }
        void OrderFinancialYearbyFieldAndDirection(DataTable financialyears);
     //   void AddFinancialYear(String FinyearText);

    }
}
