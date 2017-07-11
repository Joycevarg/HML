using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IBranchView
    {
        SortType SortDirection { get; set; }
        SortFieldType SortField { get; set; }
        void givearrdata(DataTable branchs);
        void setBankValues(DataTable banks);
    }
}
