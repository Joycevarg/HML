using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Service
{
    public interface IDistrictServices
    {
        DataTable ArrangeDistrict(SortType sortType, SortFieldType sortField);

    }
}
