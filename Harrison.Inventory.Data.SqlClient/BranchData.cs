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
           
            Sql = "Select BRANCH_ID,BRANCH_NAME as 'BRANCH NAME',BA.BANK_ID ,BANK_NAME AS 'BANK NAME',IFSC_CODE AS 'IFSC CODE',BRANCH_ADDRESS AS 'BRANCH ADDRESS',CONTACT_NO AS 'CONTACT NO' from BRANCH BR,BANK BA WHERE BR.BANK_ID=BA.BANK_ID";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        public void AddBranch( Branch branch)
        {
            Sql = "Insert into BRANCH (BRANCH_NAME,BANK_ID,IFSC_CODE,BRANCH_ADDRESS,CONTACT_NO) values( '" + branch.BRANCH_NAME.ToUpper() + "','" + branch.BANK_ID.ToString() + "','" + branch.IFSC_CODE + "','" + branch.BRANCH_ADDRESS.ToUpper() + "','" + branch.CONTACT_NO + "')";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        public void UpdateBranch(Branch branch)
        {
            Sql = "UPDATE BRANCH set BRANCH_NAME='" + branch.BRANCH_NAME.ToUpper() + "',BANK_ID=" + branch.BANK_ID.ToString() + ",IFSC_CODE='" + branch.IFSC_CODE.ToUpper() + "',BRANCH_ADDRESS='" + branch.BRANCH_ADDRESS.ToUpper() + "',CONTACT_NO='" + branch.CONTACT_NO + "' WHERE BRANCH_ID=" + branch.BRANCH_ID.ToString();
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
