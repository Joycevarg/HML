using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public interface IClusterData
    {
        List<Cluster> GetClusterDetails();
    }
}
