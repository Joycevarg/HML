using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;
using System.Data;
namespace Harrison.Inventory.Data.SqlClient
{
    public interface IStateData
    {
        DataTable GetStateDetails();
    }
}
