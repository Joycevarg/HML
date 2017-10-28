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
            Sql = "Select FIN_YEAR_ID,FIN_YEAR_NAME as 'FINANCIAL YEAR' from FIN_YEAR";
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
        public void UpdateFinYear(FinancialYears FinYear)
        {
            Sql = "UPDATE FIN_YEAR set FIN_YEAR_NAME='" + FinYear.FIN_YEAR_NAME + "' WHERE FIN_YEAR_ID=" + FinYear.FIN_YEAR_ID.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Update");
        }
        
    }
}
