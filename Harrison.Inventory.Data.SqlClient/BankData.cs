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
        String Sql;
        DataTable dt = new DataTable();
        SqlDataAdapter da;
       


        public DataTable GetBankDetails()
        {
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from BANK";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        
        
        
    }
}
