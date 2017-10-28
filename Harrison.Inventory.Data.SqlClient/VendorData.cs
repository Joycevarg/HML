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

            Sql = "Select VENDOR_ID,VENDOR_NAME as 'VENDOR NAME',HOME_ADDRESS as 'HOME ADDRESS',HOME_DISTRICT_ID,HD.DISTRICT_NAME AS 'HOME DISTRICT NAME',HOME_STATE_ID,HS.STATE_NAME AS 'HOME STATE NAME',ESTATE_ADDRESS as 'ESTATE ADDRESS',ESTATE_DISTRICT_ID,ED.DISTRICT_NAME AS 'ESTATE DISTRICT NAME',ESTATE_STATE_ID,ES.STATE_NAME AS 'ESTATE STATE NAME',OWNER_ADDRESS as 'OWNER ADDRESS',TAPPER_NO as 'TAPPER NO',OCCUPATION,OWNER_NO AS 'OWNER NO',DEALER_GROWER AS 'DEALER/GROWER',LICENSE_NO AS 'LICENSE NO',TIN_NO AS 'TIN NO',CST_NO as 'CST NO',REMARKS,VENDOR_CR_DATE AS 'VENDOR CREATION DATE',VENDOR_UP_DATE AS 'VENDOR UPDATE DATE',VENDOR_STATUS AS 'VENDOR STATUS',BA.BANK_ID,BANK_NAME AS'BANK NAME',BR.BRANCH_ID,BRANCH_NAME AS 'BRANCH NAME',ACCOUNT_NO AS 'ACCOUNT NO',REGISTERED from VENDOR V, DISTRICT HD,DISTRICT ED,STATE HS,STATE ES,BANK BA,BRANCH BR WHERE V.HOME_DISTRICT_ID=HD.DISTRICT_ID AND V.ESTATE_DISTRICT_ID=ED.DISTRICT_ID AND V.HOME_STATE_ID=HS.STATE_ID AND V.ESTATE_STATE_ID=ES.STATE_ID AND BA.BANK_ID=V.BANK_ID AND BR.BRANCH_ID=V.BRANCH_ID";
            dt = Dbcon.Sqlconnection(Sql,"Select");
            //da.Fill(dt);
            return (dt);
        }
        public void AddVendor(Vendor vendor)
        {
            Sql = "Insert into VENDOR (VENDOR_NAME,HOME_ADDRESS,HOME_DISTRICT_ID,HOME_STATE_ID,ESTATE_ADDRESS,ESTATE_DISTRICT_ID,ESTATE_STATE_ID,OWNER_ADDRESS,TAPPER_NO,OCCUPATION,OWNER_NO,DEALER_GROWER,LICENSE_NO,TIN_NO,CST_NO,REMARKS,VENDOR_CR_DATE,VENDOR_UP_DATE,VENDOR_STATUS,BANK_ID,BRANCH_ID,ACCOUNT_NO,REGISTERED) values ( '" + vendor.VENDOR_NAME.ToUpper() + "','" + vendor.HOME_ADDRESS.ToUpper() + "'," + vendor.HOME_DISTRICT_ID.ToString() + "," + vendor.HOME_STATE_ID.ToString() + ",'" + vendor.ESTATE_ADDRESS.ToUpper() + "'," + vendor.ESTATE_DISTRICT_ID.ToString() + "," + vendor.ESTATE_STATE_ID.ToString() + ",'" + vendor.OWNER_ADDRESS.ToUpper() + "','" + vendor.TAPPER_NO + "','" + vendor.OCCUPATION.ToUpper() + "','" + vendor.OWNER_NO + "'," + vendor.DEALER_GROWER.ToString() + ",'" + vendor.LICENSE_NO.ToUpper() + "','" + vendor.TIN_NO.ToUpper() + "','" + vendor.CST_NO.ToUpper() + "','" + vendor.REMARKS.ToUpper() + "','" + vendor.VENDOR_CR_DATE + "','" + vendor.VENDOR_UP_DATE + "','" + vendor.VENDOR_STATUS.ToUpper() + "','" + vendor.BANK_ID.ToString() + "','" + vendor.BRANCH_ID.ToString() + "','" + vendor.ACCOUNT_NO.ToUpper() + "','" + vendor.REGISTERED.ToString() + "')";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        public void DeleteVendor(string vendorid)
        {
            Sql = "Delete VENDOR where VENDOR_ID=" + vendorid;
            dt = Dbcon.Sqlconnection(Sql, "Delete");
        }
        public void UpdateVendor(Vendor vendor)
        {
            Sql = "UPDATE VENDOR set VENDOR_NAME='" + vendor.VENDOR_NAME + "',HOME_ADDRESS='" + vendor.HOME_ADDRESS + "',HOME_DISTRICT_ID=" + vendor.HOME_DISTRICT_ID.ToString() + ",HOME_STATE_ID=" + vendor.HOME_STATE_ID.ToString() + ",ESTATE_ADDRESS='" + vendor.ESTATE_ADDRESS + "',ESTATE_DISTRICT_ID=" + vendor.ESTATE_DISTRICT_ID.ToString() + ",ESTATE_STATE_ID=" + vendor.ESTATE_STATE_ID.ToString() + ",OWNER_ADDRESS='" + vendor.OWNER_ADDRESS + "',TAPPER_NO='" + vendor.TAPPER_NO + "',OCCUPATION='" + vendor.OCCUPATION + "',OWNER_NO='" + vendor.OWNER_NO + "',DEALER_GROWER=" + vendor.DEALER_GROWER.ToString() + ",LICENSE_NO='" + vendor.LICENSE_NO + "',TIN_NO='" + vendor.TIN_NO + "',CST_NO='" + vendor.CST_NO + "',REMARKS='" + vendor.REMARKS + "',VENDOR_UP_DATE='" + vendor.VENDOR_UP_DATE + "',VENDOR_STATUS='" + vendor.VENDOR_STATUS + "',BANK_ID='" + vendor.BANK_ID.ToString() + "',BRANCH_ID='" + vendor.BRANCH_ID.ToString() + "',ACCOUNT_NO='" + vendor.ACCOUNT_NO + "',REGISTERED='" + vendor.REGISTERED.ToString() + "' WHERE VENDOR_ID=" + vendor.VENDOR_ID.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Update");
        }

    }
}
