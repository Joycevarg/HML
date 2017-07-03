using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Harrison.Inventory.Data.SqlClient
{
    public class DBConnection
    {
        public SqlDataAdapter Sqlconnection(String sql)
        {
            SqlConnection cnn;
            string connetionString = null;
            connetionString = "Data Source=(local);Initial Catalog=HML_PURCHASE;User ID=Joyce;Password=tiger1234";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                SqlCommand myCommand = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                return (da);
                //da.Fill(dt);                
                //return (dt);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                Console.WriteLine("Database not connected");
                Console.Read();
                return (null);
            }
        }
    }
}
