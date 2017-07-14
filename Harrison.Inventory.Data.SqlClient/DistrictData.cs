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
        public void AddDistrict(District district)
        {
            Sql = "Insert into DISTRICT (DISTRICT_NAME,STATE_ID) values( '" + district.DISTRICT_NAME + "','" + district.STATE_ID.ToString() + "')";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }

    }
}
