using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Harrison.Inventory.Data.SqlClient;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class VendorData : IVendorData
    {
        String Sql;
        DataTable dt = new DataTable();
        DBConnection Dbcon = new DBConnection();

        public DataTable GetVendorDetails()
        {
           
            Sql = "Select * from VENDOR";
            dt = Dbcon.Sqlconnection(Sql,"Select");
            //da.Fill(dt);
            return (dt);
        }
        public void AddVendor(Vendor vendor)
        {
            Sql = "Insert into VENDOR (VENDOR_NAME,HOME_ADDRESS,HOME_DISTRICT_ID,HOME_STATE_ID,ESTATE_ADDRESS,ESTATE_DISTRICT_ID,ESTATE_STATE_ID,OWNER_ADDRESS,TAPPER_NO,OCCUPATION,OWNER_NO,DEALER_GROWER,LICENSE_NO,TIN_NO,CST_NO,REMARKS,VENDOR_CR_DATE,VENDOR_UP_DATE,VENDOR_STATUS,BANK_ID,BRANCH_NAME,BRANCH_ID,ACCOUNT_NO,REGISTERED) values ( '" + vendor.VENDOR_NAME + "','" + vendor.HOME_ADDRESS + "'," + vendor.HOME_DISTRICT_ID.ToString() + "," + vendor.HOME_STATE_ID.ToString() + ",'" + vendor.ESTATE_ADDRESS + "'," + vendor.ESTATE_DISTRICT_ID + "," + vendor.ESTATE_STATE_ID + ",'"+vendor.OWNER_ADDRESS+"','"+ vendor.TAPPER_NO + "','" + vendor.OCCUPATION + "','" + vendor.OWNER_NO + "'," + vendor.DEALER_GROWER.ToString() + ",'" + vendor.LICENSE_NO + "','" + vendor.TIN_NO + "','" + vendor.CST_NO + "','" + vendor.REMARKS + "','" + vendor.VENDOR_CR_DATE + "','" + vendor.VENDOR_UP_DATE + "','" + vendor.VENDOR_STATUS + "','" + vendor.BANK_ID.ToString() + "','" + vendor.BRANCH_NAME + "','" + vendor.BRANCH_ID.ToString() + "','" + vendor.REGISTERED.ToString() + "')";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        } 

    }
}
