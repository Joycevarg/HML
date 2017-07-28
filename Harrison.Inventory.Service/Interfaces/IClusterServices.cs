using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Service
{
    public interface IClusterServices
    {
        DataTable ArrangeCluster(SortType sortType, SortFieldType sortField);
        void AddCluster(string clustername, int stateid);
        void DeleteCluster(object Clusterid);
        void UpdateCluster(int clusterid, string clustername, int stateid);
    }
}
