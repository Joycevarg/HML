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
        public DataTable GetAllFinancialYears()
        {
            Connection con= new Connection();
            SqlConnection conn= con.sqlconnection();
            string cmd="SELECT * FROM FIN_YEAR";
            SqlCommand com = new SqlCommand(cmd,conn);
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            return dt;
        }
    }
}
