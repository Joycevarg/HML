using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Harrison.Inventory.Data.SqlClient;
using Harrison.Inventory.Data.Model;
namespace Harrison.Inventory.Data.SqlClient
{
    public class RPSData : IRPSData
    {
        String Sql;
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        DBConnection Dbcon = new DBConnection();

        public DataTable GetRPSDetails()
        {
           
            Sql = "Select * from RPS";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        public DataTable SelectRPS(object vendorid)
        {
            
            dt.Clear();           
            Sql = "Select * from RPS WHERE VENDOR_ID=" + vendorid.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        public void AddRPS(RPS rps)
        {
            Sql = "Insert into RPS (VENDOR_ID,RPS_NAME,CONTACT_NAME,CONTACT_NO,ROUTE_DETAILS,REMARKS) values( '" + rps.VENDOR_ID.ToString() + "','" + rps.RPS_NAME + "','" + rps.CONTACT_NAME + "','" + rps.CONTACT_NO + "','" + rps.ROUTE_DETAILS + "','" +rps.REMARKS+ "')";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        public void DeleteRPS(string rpsid)
        {
            Sql = "Delete RPS where RPS_ID=" + rpsid;
            dt = Dbcon.Sqlconnection(Sql, "Delete");
        }

    }

}
