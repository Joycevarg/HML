using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Harrison.Inventory.Data.SqlClient
{
    public class DBConnection
    {
        public DataTable Sqlconnection(String sql, String TypeExec)
        {
            SqlConnection cnn;
            string connetionString = null;
            connetionString = "Data Source=(local);Initial Catalog=HML_PURCHASE;User ID=Joyce;Password=tiger1234";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand myCommand;
            cnn = new SqlConnection(connetionString);
            myCommand = new SqlCommand(sql, cnn);
            cnn.Open();
            try
            {
                if (TypeExec == "Select")
                {
                    da = new SqlDataAdapter(myCommand);
                    da.Fill(dt);
                }
                else if (TypeExec == "Insert"||TypeExec=="Delete")
                {
                    da.InsertCommand = new SqlCommand(sql, cnn);
                    da.InsertCommand.ExecuteNonQuery();
                }
               

                return (dt);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                Console.WriteLine("Database not connected");

                return (dt);
            }
        }
    }
}
