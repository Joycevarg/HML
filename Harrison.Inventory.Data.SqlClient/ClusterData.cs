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
            Sql = "Insert into CLUSTER (CLUSTER_NAME) values( '" + cluster.CLUSTER_NAME.ToUpper() + "')";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }

        public void DeleteCluster(string clusterid)
        {
            Sql = "Delete CLUSTER where CLUSTER_ID="+clusterid;
            dt = Dbcon.Sqlconnection(Sql, "Delete");
        }
        public void UpdateCluster(Cluster cluster)
        {
            Sql = "UPDATE CLUSTER set CLUSTER_NAME='" + cluster.CLUSTER_NAME.ToUpper() + "' WHERE CLUSTER_ID=" + cluster.CLUSTER_ID.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Update");
        }
        
    }
}
