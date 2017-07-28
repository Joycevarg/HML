using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
namespace Harrison.Inventory.Data.SqlClient
{
    public interface IRPSData
    {
        DataTable GetRPSDetails();
        DataTable SelectRPS(object vendorid);
        void AddRPS(RPS rps);
        void DeleteRPS(string rpsid);
        void UpdateRPS(RPS rps);
    }
}