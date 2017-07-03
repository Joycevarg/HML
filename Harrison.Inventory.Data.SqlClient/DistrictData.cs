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
            da = Dbcon.Sqlconnection(Sql);
            da.Fill(dt);
            return (dt);
        }
        
    }
}
