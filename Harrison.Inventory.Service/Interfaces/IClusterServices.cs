using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Service
{
    public interface IClusterServices
    {
        List<Cluster> ArrangeCluster(SortType sortType, SortFieldType sortField);

    }
}
