using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.SqlClient;
using Harrison.Inventory.Data.Model;
using System.Data;

namespace Harrison.Inventory.Service
{
    public class ClusterDistrictservice:IClusterDistrictservice
    {
        private IClusterDistrictData _clusterdistrictdata;
        public ClusterDistrictservice(IClusterDistrictData clusterdistrict)
        {
            _clusterdistrictdata = clusterdistrict;
        }
        public DataTable ArrangeClusterDistrict(SortType sortType, SortFieldType sortField)
        {
            DataTable clusterdistricts = _clusterdistrictdata.GetClusterDistrictDetails();
        /*    if (sortType == SortType.Ascending)
            {
                districts = districts.OrderBy(p => p.DISTRICT_ID).ToList();
            }
            else
            {
                districts = districts.OrderByDescending(p => p.DISTRICT_ID).ToList();
            } */
            return clusterdistricts; 

        }
   
      
        public void AddClusterDistrict(int districtid,int clusterid)
        {
            ClusterDistrict clusterdistrict = new ClusterDistrict(clusterid, districtid);
            _clusterdistrictdata.AddClusterDistrict(clusterdistrict);

        }
    }
}
