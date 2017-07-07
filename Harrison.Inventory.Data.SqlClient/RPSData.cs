using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Data.SqlClient
{
    public class RPSData : IRPSData
    {
        String Sql;
        DataTable dt = new DataTable();
        SqlDataAdapter da;

        public DataTable GetRPSDetails()
        {
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from RPS";
            da = Dbcon.Sqlconnection(Sql);
            da.Fill(dt);
            return (dt);
        }

    }
}
