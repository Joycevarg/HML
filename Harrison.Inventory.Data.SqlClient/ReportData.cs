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
                Sql = "Select I.INVOICE_ID,INVOICE_DATE AS 'INVOICE DATE',LPC,VFA,BARREL_QTY AS 'BARREL QUANTITY',LUMB_QTY AS 'LUMB QUANTITY',EMPTY_QTY AS 'EMPTY QUANTITY',WET_WT AS 'WET WEIGHT',DRC,RATE_KG AS 'RATE PER KG',DRY_WT AS 'DRY WEIGHT',AMOUNT,LUMB_PRICE AS 'LUMB PRICE',LUMB_AMOUNT AS 'LUMB AMOUNT',NO_TAX_AMOUNT AS 'TOTAL AMOUNT WITHOUT TAX',CGST,SGST,TOTAL_AMOUNT AS 'TOTAL AMOUNT INCLD TAX',PAID_DATE AS 'PAID DATE',TO_PAY AS 'TO BE PAID',FROM_HO 'FROM HEAD OFFICE' ,OTHER_DEBITS AS 'OTHER DEBITS',TOTAL_PAID AS 'TOTAL PAID',BALANCE FROM PAYMENT_FORM P,INVOICE I WHERE P.INVOICE_ID=I.INVOICE_ID AND I.VENDOR_ID=" + venid.ToString();
            else
                Sql = "Select I.INVOICE_ID,INVOICE_DATE AS 'INVOICE DATE',LPC,VFA,BARREL_QTY AS 'BARREL QUANTITY',LUMB_QTY AS 'LUMB QUANTITY',EMPTY_QTY AS 'EMPTY QUANTITY',WET_WT AS 'WET WEIGHT',DRC,RATE_KG AS 'RATE PER KG',DRY_WT AS 'DRY WEIGHT',AMOUNT,LUMB_PRICE AS 'LUMB PRICE',LUMB_AMOUNT AS 'LUMB AMOUNT',NO_TAX_AMOUNT AS 'TOTAL AMOUNT WITHOUT TAX',CGST,SGST,TOTAL_AMOUNT AS 'TOTAL AMOUNT INCLD TAX',PAID_DATE AS 'PAID DATE',TO_PAY AS 'TO BE PAID',FROM_HO 'FROM HEAD OFFICE' ,OTHER_DEBITS AS 'OTHER DEBITS',TOTAL_PAID AS 'TOTAL PAID',BALANCE FROM PAYMENT_FORM P,INVOICE I WHERE (P.INVOICE_ID=I.INVOICE_ID) AND (I.VENDOR_ID=" + venid.ToString() + ")AND (P.PAID_DATE BETWEEN '" + fromdate + "' AND '" + todate + "')";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
    }
}
