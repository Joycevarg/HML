using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Harrison.Inventory.Data.SqlClient
{
    public class ReportData:IReportdata
    {
        String Sql;
        DataTable dt = new DataTable();
        DBConnection Dbcon = new DBConnection();
        public DataTable GetReportData(int venid, string fromdate="", string todate="")
        {
            if(fromdate=="")
            Sql = "Select I.INVOICE_ID,INVOICE_DATE,I.VENDOR_ID,LPC,VFA,BARREL_QTY,LUMB_QTY,EMPTY_QTY,WET_WT,DRC,RATE_KG,DRY_WT,AMOUNT,LUMB_PRICE,LUMB_AMOUNT,NO_TAX_AMOUNT,CGST,SGST,TOTAL_AMOUNT,PAID_DATE,TO_PAY,FROM_HO,OTHER_DEBITS,TOTAL_PAID,BALANCE FROM PAYMENT_FORM P,INVOICE I WHERE P.INVOICE_id=I.INVOICE_ID AND I.VENDOR_ID="+venid.ToString();
            else
            Sql = "Select I.INVOICE_ID,INVOICE_DATE,I.VENDOR_ID,LPC,VFA,BARREL_QTY,LUMB_QTY,EMPTY_QTY,WET_WT,DRC,RATE_KG,DRY_WT,AMOUNT,LUMB_PRICE,LUMB_AMOUNT,NO_TAX_AMOUNT,CGST,SGST,TOTAL_AMOUNT,PAID_DATE,TO_PAY,FROM_HO,OTHER_DEBITS,TOTAL_PAID,BALANCE FROM PAYMENT_FORM P,INVOICE I WHERE (P.INVOICE_id=I.INVOICE_ID) AND (I.VENDOR_ID=" + venid.ToString()+")AND (P.PAID_DATE BETWEEN '"+fromdate+"' AND '"+todate+"')";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
    }
}
