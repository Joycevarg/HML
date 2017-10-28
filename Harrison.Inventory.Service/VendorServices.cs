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
        public void AddVendor(string vendorname, string homeaddr, int homedist, int homestat, string estateaddr, int estatdist, int estatstat, string owneraddr, string tappno, string occup, string ownerno, int dealgrow, string licenno, string tinno, string cstno, string remark, string vendcrdate, string vendupdate, string vendstat, int bankid, int branchid, string accno, int register)
        {
            Vendor vendor = new Vendor(0,vendorname, homeaddr, homedist, homestat, estateaddr, estatdist, estatstat, owneraddr, tappno, occup, ownerno, dealgrow, licenno, tinno, cstno, remark, vendcrdate, vendupdate, vendstat, bankid, branchid,accno, register);
            _vendordata.AddVendor(vendor);

        }
        public void UpdateVendor(int vendorid,string vendorname, string homeaddr, int homedist, int homestat, string estateaddr, int estatdist, int estatstat, string owneraddr, string tappno, string occup, string ownerno, int dealgrow, string licenno, string tinno, string cstno, string remark, string vendupdate, string vendstat, int bankid, int branchid, string accno, int register)
        {
            Vendor vendor = new Vendor(vendorid,vendorname, homeaddr, homedist, homestat, estateaddr, estatdist, estatstat, owneraddr, tappno, occup, ownerno, dealgrow, licenno, tinno, cstno, remark, "", vendupdate, vendstat, bankid, branchid, accno, register);
            _vendordata.UpdateVendor(vendor);

        }
        public void DeleteVendor(object Vendorid)
        {
            _vendordata.DeleteVendor(Vendorid.ToString());
        }
       
        public int GetVendorRegistered(int vendorid)
        {
            DataTable vendors = _vendordata.GetVendorDetails();
            int register = 0;
            foreach (DataRow row in vendors.Rows)
            {
                if (int.Parse(row["VENDOR_ID"].ToString()) == vendorid)
                {
                    register = int.Parse(row["REGISTERED"].ToString());
                    break;
                }
            }
            return register;
        }
        public string GetVendorName(int vendorid)
        {
            DataTable vendors = _vendordata.GetVendorDetails();
            string vendorname = "";
            foreach (DataRow row in vendors.Rows)
            {
                if (int.Parse(row["VENDOR_ID"].ToString()) == vendorid)
                {
                    vendorname = row["VENDOR NAME"].ToString();
                    break;
                }
            }
            return vendorname;
        }
        public string GetTIN(int vendorid)
        {
            DataTable vendors = _vendordata.GetVendorDetails();
            string tinno = "";
            foreach (DataRow row in vendors.Rows)
            {
                if (int.Parse(row["VENDOR_ID"].ToString()) == vendorid)
                {
                    tinno = row["TIN NO"].ToString();
                    break;
                }
            }
            return tinno;
        }
    }

}