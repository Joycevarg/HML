using System;
using System.Collections.Generic;
using System.Text;
using Harrison.Inventory.Data.Model;
using System.Data.SqlClient;
using System.Data;

namespace Harrison.Inventory.Data.SqlClient
{
    public class FinancialYearsDAL:IFinancialYearsDAL
    {
        String Sql;
        DataTable dt = new DataTable();
        SqlDataAdapter da;

        public DataTable GetAllFinancialYears()
        {
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from FIN_YEAR";
            da = Dbcon.Sqlconnection(Sql);
            da.Fill(dt);
            return (dt);
        }
        
    }
}
