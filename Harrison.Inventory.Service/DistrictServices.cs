using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class DistrictServices : IDistrictServices
    {
        private DistrictData _districtdata;
        public DistrictServices(DistrictData Districtdata)
        {
            _districtdata = Districtdata;
        }
        public List<District> ArrangeDistrict(SortType sortType, SortFieldType sortField)
        {
            List<District> districts = _districtdata.GetDistrictDetails();
            if (sortType == SortType.Ascending)
            {
                districts = districts.OrderBy(p => p.DISTRICT_ID).ToList();
            }
            else
            {
                districts = districts.OrderByDescending(p => p.DISTRICT_ID).ToList();
            }
            return districts;

        }
    }
}
