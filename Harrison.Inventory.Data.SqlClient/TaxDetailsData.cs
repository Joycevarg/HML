using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class TaxDetailsData:ITaxDetailsData
    {
        String Sql;
        DataTable dt = new DataTable();
        DBConnection Dbcon = new DBConnection();

        public DataTable GetTaxDetails()
        {


            Sql = "Select * from TAX_DETAILS";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        public void AddTaxDetails(TaxDetails taxdetails)
        {
            Sql = "Insert into TAX_DETAILS (FIN_YEAR_ID,EFFECT_DATE,END_DATE,CGST,SGST) values( '" + taxdetails.FIN_YEAR_ID.ToString() + "','"+taxdetails.EFFECT_DATE+"','"+taxdetails.END_DATE+"','"+taxdetails.CGST.ToString()+"','"+taxdetails.SGST.ToString()+"');";
            dt = Dbcon.Sqlconnection(Sql, "Insert");


        }
    }
}
