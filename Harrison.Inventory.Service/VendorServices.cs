using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;
using System.Data;

namespace Harrison.Inventory.Service
{
    public class  VendorService: IVendorServices
    {
        private IVendorData _vendordata;
        public VendorService(IVendorData ivendordata)
        {
            _vendordata = ivendordata;
        }
        public DataTable ArrangeVendor(SortType sortType, SortFieldType sortFieldType)
        {
            DataTable vendors = _vendordata.GetVendorDetails();

           
            return vendors;
        }
    }

}