using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Data.SqlClient
{
    public class VendorData : IVendorData
    {
        String Sql;
        DataTable dt = new DataTable();
        SqlDataAdapter da;

        public DataTable GetVendorDetails()
        {
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from VENDOR";
            dt = Dbcon.Sqlconnection(Sql,"Select");
            //da.Fill(dt);
            return (dt);
        }

    }
}
