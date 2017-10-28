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

            Sql = "SELECT CDM.CLUSTER_ID,CDM.DISTRICT_ID,DISTRICT_NAME as 'DISTRICT NAME',CLUSTER_NAME as 'CLUSTER NAME' FROM CLUS_DIST_MAP CDM ,CLUSTER C,DISTRICT D WHERE CDM.DISTRICT_ID=D.DISTRICT_ID AND CDM.CLUSTER_ID=C.CLUSTER_ID";
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
