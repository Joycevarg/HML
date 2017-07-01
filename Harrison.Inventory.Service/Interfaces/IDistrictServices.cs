using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Service
{
    public interface IDistrictServices
    {
        List<District> ArrangeDistrict(SortType sortType, SortFieldType sortField);

    }
}
