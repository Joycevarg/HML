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

            Sql = "SELECT D.DISTRICT_NAME,C.CLUSTER_NAME FROM DISTRICT D,CLUSTER C,CLUS_DIST_MAP M WHERE (D.DISTRICT_ID=M.DISTRICT_ID) AND (C.CLUSTER_ID=M.CLUSTER_ID) ";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }

        public void AddClusterDistrict(ClusterDistrict clusterdistrict)
        {
            Sql = "Insert into CLUS_DIST_MAP (DISTRICT_ID,CLUSTER_ID) values( " + clusterdistrict.districtid.ToString() + "," + clusterdistrict.clusterid.ToString()+ ")";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        public void DeleteClusterDistrict(string districtid)
        {
            Sql = "Delete CLUS_DIST_MAP where DISTRICT_ID="+districtid;
            dt = Dbcon.Sqlconnection(Sql, "Delete");
        }
        public void UpdateClusterDistrict(ClusterDistrict clustdist)
        {
            Sql = "UPDATE CLUS_DIST_MAP set CLUSTER_ID=" + clustdist.clusterid.ToString() + ",DISTRICT_ID=" + clustdist.districtid.ToString() + " WHERE DISTRICT_ID=" + clustdist.districtid.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Update");
        }
        
    }
}
