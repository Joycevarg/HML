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
        SqlDataAdapter da;

        public DataTable GetDistrictDetails()
        {
            
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from DISTRICT";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }

        public DataTable SelectDistricts(object stateid)
        {
            dt.Clear();
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from DISTRICT WHERE STATE_ID =" + stateid.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }

    }
}
