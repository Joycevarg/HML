using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class ClusterData : IClusterData
    {
        public List<Cluster> GetClusterDetails()
        {
            return new List<Cluster>{
            new Cluster(1,"cluster1",1),
            new Cluster(2,"cluster2",2)
            };
        }
    }
}
