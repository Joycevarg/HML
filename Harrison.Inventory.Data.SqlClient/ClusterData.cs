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
        DBConnection Dbcon = new DBConnection();

        public DataTable GetClusterDetails()
        {
            
            Sql = "Select * from CLUSTER";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }

        public void AddCluster(Cluster cluster)
        {
            Sql = "Insert into CLUSTER (CLUSTER_NAME,STATE_ID) values( '" + cluster.CLUSTER_NAME + "'," + cluster.STATE_ID.ToString() + ")";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        
    }
}
