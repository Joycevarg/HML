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
        DBConnection Dbcon = new DBConnection();
       


        public DataTable GetBankDetails()
        {
            
            Sql = "Select * from BANK";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        public void AddBank(String BankName)
        {
            Sql = "Insert into BANK (BANK_NAME) values( '" + BankName + "');";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        
        
        
    }
}
