using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Harrison.Inventory.Data.SqlClient
{
    class Connection
    {
        string userid,password,datasource,database;
        public Connection() {
            database = "HML_PURCHASE";
            datasource = "(local)";
            userid = "Joyce";
            password = "tiger1234";

        }
        public SqlConnection sqlconnection()
        {
            string conquery = "Data Source="+this.datasource+";Initial Catalog="+this.database+";User ID=" + this.userid + ";Password=" + this.password;
           SqlConnection con = new SqlConnection(conquery);
           con.Open();
           return con;

        }


    }
}
