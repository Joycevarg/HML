using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
using System.Data.SqlClient;

namespace Harrison.Inventory.Data.SqlClient
{
    public class BranchData:IBranchData
    {
        String Sql;
        DataTable dt = new DataTable();
         DBConnection Dbcon = new DBConnection();

        public DataTable GetBranchDetails()
        {
           
            Sql = "Select * from BRANCH";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        public void AddBranch( Branch branch)
        {
            Sql = "Insert into BRANCH (BRANCH_NAME,BANK_ID,IFSC_CODE,BRANCH_ADDRESS,CONTACT_NO) values( '" + branch.BRANCH_NAME+ "','"+branch.BANK_ID.ToString()+"','"+branch.IFSC_CODE+"','"+branch.BRANCH_ADDRESS+"','"+branch.CONTACT_NO+"')";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        public DataTable SelectBranchs(object bankid)
        {
            Sql = "Select * from BRANCH WHERE BANK_ID =" + bankid.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return dt;
        }
    }
}
