using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class DistrictData:IDistrictData
    {
        public DataTable GetDistrictDetails()
        {
            Connection con = new Connection();
            SqlConnection conn = con.sqlconnection();
            string cmd = "SELECT * FROM DISTRICT";
            SqlCommand com = new SqlCommand(cmd, conn);
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            return dt;
        }
    }
}
