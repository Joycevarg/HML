using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class StateData:IStateData
    {
        String Sql;
        DataTable dt = new DataTable();
        SqlDataAdapter da;

        public DataTable GetStateDetails()
        {
           
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from STATE";
            dt = Dbcon.Sqlconnection(Sql,"Select");
            //da.Fill(dt);
            return (dt);
        }
        

    }
}
