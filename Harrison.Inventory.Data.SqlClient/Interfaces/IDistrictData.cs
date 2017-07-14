using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;
using System.Data;

namespace Harrison.Inventory.Data.SqlClient
{
    public interface IDistrictData
    {
        DataTable GetDistrictDetails();
        DataTable SelectDistricts(object stateid);
        void AddDistrict(District district);
    }
}
