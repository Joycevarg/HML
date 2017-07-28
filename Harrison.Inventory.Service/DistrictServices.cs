using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class DistrictServices : IDistrictServices
    {
        private IDistrictData _districtdata;
        public DistrictServices(DistrictData Districtdata)
        {
            _districtdata = Districtdata;
        }
        public DataTable ArrangeDistrict(SortType sortType, SortFieldType sortField)
        {
            DataTable districts = _districtdata.GetDistrictDetails();
        /*    if (sortType == SortType.Ascending)
            {
                districts = districts.OrderBy(p => p.DISTRICT_ID).ToList();
            }
            else
            {
                districts = districts.OrderByDescending(p => p.DISTRICT_ID).ToList();
            } */
            return districts; 

        }
        public DataTable DistrictwithState(object stateid)
        {
            DataTable states = _districtdata.SelectDistricts(stateid);
            return states;
        
        }
        public void AddDistrict(string districtname,int stateid)
        {
            District district = new District(0, districtname, stateid);
            _districtdata.AddDistrict(district);

        }
        public void UpdateDistrict(int districtid,string districtname, int stateid)
        {
            District district = new District(districtid, districtname, stateid);
            _districtdata.UpdateDistrict(district);

        }
        public void DeleteDistrict(object Districtid)
        {

            _districtdata.DeleteDistrict(Districtid.ToString());

        }
      
    }
}
