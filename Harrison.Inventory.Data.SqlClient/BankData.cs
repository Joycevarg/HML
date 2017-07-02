using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;
using System.Data.SqlClient;
using System.Data;

namespace Harrison.Inventory.Data.SqlClient
{
    public class BankData:IBankData
    {
        public DataTable GetBankDetails()
        {

            Connection con = new Connection();
            SqlConnection conn = con.sqlconnection();
            string cmd = "SELECT * FROM BANK";
            SqlCommand com = new SqlCommand(cmd, conn);
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            return dt;
        
        
        }
    }
}
