using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
    public class ClusterDistrict
    {
        public int clusterid { get; set; }
        public int districtid { get; set; }
        public ClusterDistrict(int cid, int did)
        {
            this.clusterid = cid;
            this.districtid = did;
        }
    }
}
