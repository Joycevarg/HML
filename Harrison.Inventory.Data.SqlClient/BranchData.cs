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
        public void UpdateBranch(Branch branch)
        {
            Sql = "UPDATE BRANCH set BRANCH_NAME='" + branch.BRANCH_NAME +"',BANK_ID="+branch.BANK_ID.ToString()+",IFSC_CODE='"+branch.IFSC_CODE+"',BRANCH_ADDRESS='"+branch.BRANCH_ADDRESS+"',CONTACT_NO='"+branch.CONTACT_NO+"' WHERE BRANCH_ID="+branch.BRANCH_ID.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Update");
        }
        public DataTable SelectBranchs(object bankid)
        {
            Sql = "Select * from BRANCH WHERE BANK_ID =" + bankid.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return dt;
        }
        public void DeleteBranch(string BranchId)
        {
            Sql = "DELETE BRANCH WHERE BRANCH_ID=" + BranchId;
            dt = Dbcon.Sqlconnection(Sql, "Delete");
        }
    }
}
