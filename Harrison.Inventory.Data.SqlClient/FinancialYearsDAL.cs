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
        DBConnection Dbcon = new DBConnection();
        DataTable dt = new DataTable();

        public DataTable GetAllFinancialYears()
        {
            Sql = "Select * from FIN_YEAR";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            // da.Fill(dt);
            return (dt);
        }

        public void AddFinancialYears(String FinYear)
        {
            Sql = "Insert into FIN_YEAR (FIN_YEAR_NAME) values( '" + FinYear + "');";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        public void DeleteFinYear(string finyearid)
        {
            Sql = "Delete FIN_YEAR WHERE FIN_YEAR_ID="+finyearid;
            dt = Dbcon.Sqlconnection(Sql, "Delete");
        }
        
        
    }
}
