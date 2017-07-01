using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IClusterView
    {
        SortType SortDirection { get; set; }
        SortFieldType SortField { get; set; }
        void givearrdata(List<Cluster> districts);
    }
}
