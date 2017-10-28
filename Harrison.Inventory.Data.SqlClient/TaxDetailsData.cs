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
            Sql = "Select T.FIN_YEAR_ID,FIN_YEAR_NAME AS 'FINANCIAL YEAR NAME',EFFECT_DATE AS 'EFFECT DATE',END_DATE AS 'END DATE',CGST,SGST from TAX_DETAILS T,FIN_YEAR F WHERE T.FIN_YEAR_ID=F.FIN_YEAR_ID";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        public void AddTaxDetails(TaxDetails taxdetails)
        {
            Sql = "Insert into TAX_DETAILS (FIN_YEAR_ID,EFFECT_DATE,END_DATE,CGST,SGST) values( '" + taxdetails.FIN_YEAR_ID.ToString() + "','"+taxdetails.EFFECT_DATE+"','"+taxdetails.END_DATE+"','"+taxdetails.CGST.ToString()+"','"+taxdetails.SGST.ToString()+"');";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        public void DeleteTaxDetails(string finyear)
        {
            Sql = "Delete TAX_DETAILS where FIN_YEAR_ID=" + finyear;
            dt = Dbcon.Sqlconnection(Sql, "Delete");
        }
        public void UpdateTaxDetails(TaxDetails taxdetails)
        {
            Sql = "UPDATE TAX_DETAILS set FIN_YEAR_ID='" + taxdetails.FIN_YEAR_ID.ToString() + "',EFFECT_DATE='" + taxdetails.EFFECT_DATE + "',END_DATE='" + taxdetails.END_DATE + "',CGST='" + taxdetails.CGST.ToString() + "',SGST='" + taxdetails.SGST.ToString() + "' WHERE FIN_YEAR_ID="+taxdetails.FIN_YEAR_ID.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Update");
        }
    }
}
