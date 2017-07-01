using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class DistrictData:IDistrictData
    {
        public List<District> GetDistrictDetails()
        {
            return new List<District>{
            new District(1,"state1",1),
            new District(2,"state2",2)
            };
        }
    }
}
