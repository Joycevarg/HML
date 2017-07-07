using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Service
{
    public interface IVendorServices
    {
        
            DataTable ArrangeVendor(SortType sortType, SortFieldType sortField);
        
    }
}
