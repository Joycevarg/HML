using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class ClusterDistrictData:IClusterDistrictData
    {
        String Sql;
        DataTable dt = new DataTable();
        DBConnection Dbcon = new DBConnection();

        public DataTable GetClusterDistrictDetails()
        {

            Sql = "Select * from CLUS_DIST_MAP";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }

        public void AddClusterDistrict(ClusterDistrict clusterdistrict)
        {
            Sql = "Insert into CLUS_DIST_MAP (DISTRICT_ID,CLUSTER_ID) values( " + clusterdistrict.districtid.ToString() + "," + clusterdistrict.clusterid.ToString()+ ")";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        
    }
}
