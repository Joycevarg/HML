using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IVendorView
    {
        SortType SortDirection { get; set; }
        SortFieldType SortField { get; set; }
        void givearrdata(DataTable vendors);
        void setHStateValues(DataTable states);
        void setEStateValues(DataTable states);
        void setHDistrictValues(DataTable districts);
        void setEDistrictValues(DataTable districts);
        void setBranchValues(DataTable branchs);
        void setBankValues(DataTable banks);
    }
}
