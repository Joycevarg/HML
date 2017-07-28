using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class DistrictData:IDistrictData
    {
        String Sql;
        DataTable dt = new DataTable();
        DBConnection Dbcon = new DBConnection();

        public DataTable GetDistrictDetails()
        {
            
            
            Sql = "Select * from DISTRICT";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }

        public DataTable SelectDistricts(object stateid)
        {
            Sql = "Select * from DISTRICT WHERE STATE_ID =" + stateid.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        public void UpdateDistrict(District district)
        {
            Sql = "UPDATE DISTRICT set DISTRICT_NAME='" + district.DISTRICT_NAME + "',STATE_ID=" + district.STATE_ID.ToString() +" WHERE DISTRICT_ID=" + district.DISTRICT_ID.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Update");
        }
        public void AddDistrict(District district)
        {
            Sql = "Insert into DISTRICT (DISTRICT_NAME,STATE_ID) values( '" + district.DISTRICT_NAME + "','" + district.STATE_ID.ToString() + "')";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        public void DeleteDistrict(string districtid)
        {
            Sql = "Delete DISTRICT where DISTRICT_ID=" + districtid;
            dt = Dbcon.Sqlconnection(Sql, "Delete");
        }
        
    }
}
