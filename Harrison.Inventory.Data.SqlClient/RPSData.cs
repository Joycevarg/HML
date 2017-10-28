﻿using System;
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

            Sql = "Select RPS_ID,R.VENDOR_ID,V.VENDOR_NAME as 'VENDOR NAME',RPS_NAME as 'RPS NAME',CONTACT_NAME AS 'CONTACT NAME',CONTACT_NO AS 'CONTACT NO',ROUTE_DETAILS AS 'ROUTE DETAILS',R.REMARKS AS 'REMARKS'from RPS R,VENDOR V WHERE R.VENDOR_ID=V.VENDOR_ID";
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
            Sql = "Insert into RPS (VENDOR_ID,RPS_NAME,CONTACT_NAME,CONTACT_NO,ROUTE_DETAILS,REMARKS) values( '" + rps.VENDOR_ID.ToString() + "','" + rps.RPS_NAME.ToUpper() + "','" + rps.CONTACT_NAME.ToUpper() + "','" + rps.CONTACT_NO + "','" + rps.ROUTE_DETAILS.ToUpper() + "','" + rps.REMARKS.ToUpper() + "')";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        public void DeleteRPS(string rpsid)
        {
            Sql = "Delete RPS where RPS_ID=" + rpsid;
            dt = Dbcon.Sqlconnection(Sql, "Delete");
        }
        public void UpdateRPS(RPS rps)
        {
            Sql = "UPDATE RPS set VENDOR_ID =" + rps.VENDOR_ID.ToString() + ",RPS_NAME='" + rps.RPS_NAME.ToUpper() + "',CONTACT_NAME='" + rps.CONTACT_NAME.ToUpper() + "',CONTACT_NO='" + rps.CONTACT_NO + "',ROUTE_DETAILS='" + rps.ROUTE_DETAILS.ToUpper() + "',REMARKS='" + rps.REMARKS.ToUpper() + "' WHERE RPS_ID=" + rps.RPS_ID.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Update");
        }

    }

}
