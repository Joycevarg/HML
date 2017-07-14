using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class ClusterServices : IClusterServices
    {
        private ClusterData _clusterdata;
        public ClusterServices(ClusterData ClusterData)
        {
            _clusterdata = ClusterData;
        }
        public DataTable ArrangeCluster(SortType sortType, SortFieldType sortField)
        {
            DataTable clusters = _clusterdata.GetClusterDetails();
        /*    if (sortType == SortType.Ascending)
            {
                clusters = clusters.OrderBy(p => p.CLUSTER_ID).ToList();
            }
            else
            {
                clusters = clusters.OrderByDescending(p => p.CLUSTER_ID).ToList();
            } */
            return clusters;
        }

        public void AddCluster(string clustername, int stateid)
        {
            Cluster cluster = new Cluster(0, clustername, stateid);
            _clusterdata.AddCluster(cluster);

        }
    }
}
