﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class InvoiceData : IInvoiceData
    {
        String Sql;
        DataTable dt = new DataTable();
        SqlDataAdapter da;
   
        public DataTable GetVendorDetails()
        {
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from VENDOR";
            da = Dbcon.Sqlconnection(Sql);
            da.Fill(dt);
            return dt;
        }
    }
}