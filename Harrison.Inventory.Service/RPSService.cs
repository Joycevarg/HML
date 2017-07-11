using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class RPSServices : IRPSServices
    {
        private IRPSData _rpsdata;
        public RPSServices(IRPSData RPSdata)
        {
            _rpsdata = RPSdata;
        }
        public DataTable ArrangeRPS(SortType sortType, SortFieldType sortField)
        {
            DataTable rpss = _rpsdata.GetRPSDetails();
            /*    if (sortType == SortType.Ascending)
                {
                    districts = districts.OrderBy(p => p.DISTRICT_ID).ToList();
                }
                else
                {
                    districts = districts.OrderByDescending(p => p.DISTRICT_ID).ToList();
                } */
            return rpss;

        }
        public DataTable RpswithVendor(object vendorid)
        {
            DataTable rpss = _rpsdata.SelectRPS(vendorid);
            return rpss;
        }

    }
}