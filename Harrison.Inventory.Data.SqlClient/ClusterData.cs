using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class ClusterData : IClusterData
    {
        String Sql;
        DataTable dt = new DataTable();
        SqlDataAdapter da;

        public DataTable GetClusterDetails()
        {
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from CLUSTER";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        
    }
}
