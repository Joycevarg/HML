using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IBankView
    {
        SortType SortDirection { get; set; }
        SortFieldType SortField { get; set; }
        void givearrdata(DataTable banks);
        
    }
}
