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
        void AddVendor(string vendorname, string homeaddr, int homedist, int homestat, string estateaddr, int estatdist, int estatstat, string owneraddr, string tappno, string occup, string ownerno, int dealgrow, string licenno, string tinno, string cstno, string remark, string vendcrdate, string vendupdate, string vendstat, int bankid, int branchid,string accno, int register);
        int VendorRegistered(int vendorid);
        
    }
}
