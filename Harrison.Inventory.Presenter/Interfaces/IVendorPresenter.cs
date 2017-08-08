using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IVendorPresenter
    {
        void DefaultVendorOrder();
        void ChangeVendorOrder(SortType sortType, SortFieldType sortField);
        void setHstateNames();
        void setEstateNames();
        void setHdistrictNames(object stateid);
        void setEdistrictNames(object stateid);
        void setBankNames();
        void setBranchNames(object branchid);
        void DeleteVendor(object Vendorid);
        void AddVendor(string vendorname, string homeaddr, int homedist, int homestat, string estateaddr, int estatdist, int estatstat, string owneraddr, string tappno, string occup, string ownerno, int dealgrow, string licenno, string tinno, string cstno, string remark, string vendcrdate, string vendupdate, string vendstat, int bankid, int branchid,string accno, int register);
        void UpdateVendor(int vendorid, string vendorname, string homeaddr, int homedist, int homestat, string estateaddr, int estatdist, int estatstat, string owneraddr, string tappno, string occup, string ownerno, int dealgrow, string licenno, string tinno, string cstno, string remark,  string vendupdate, string vendstat, int bankid, int branchid, string accno, int register);
    }
}
