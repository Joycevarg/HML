using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Harrison.Inventory.Data.SqlClient
{
    public class BranchData:IBranchData
    {
        String Sql;
        DataTable dt = new DataTable();
        SqlDataAdapter da;

        public DataTable GetBranchDetails()
        {
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from BRANCH";
            da = Dbcon.Sqlconnection(Sql);
            da.Fill(dt);
            return (dt);
        }
    }
}
