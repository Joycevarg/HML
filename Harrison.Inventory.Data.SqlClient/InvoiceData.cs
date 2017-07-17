using System;
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
        DBConnection Dbcon = new DBConnection();
       
   
        public DataTable GetInvoiceDetails()
        {
          
            Sql = "Select * from INVOICE";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        public void AddInvoice(Invoice invoice)
        {
            Sql = "Insert into INVOICE (MOVED_RECIEPT,INVOICE_DATE,VENDOR_ID,RPS_ID,COMMODITY,TRADED,COMMODITY_CODE,FRR_NO,LPC,VFA,BARREL_QTY,LUMB_QTY,EMPTY_QTY,WET_WT,DRC,RATE_KG,SPOT_CONTRACT,CODE_NO,DRY_WT,AMOUNT,LUMB_PRICE,LUMB_AMOUNT,NO_TAX_AMOUNT,CGST,SGST,TOTAL_AMOUNT) values( '" + invoice.MOVED_RECIEPT.ToString() + "','" + invoice.INVOICE_DATE + "','" + invoice.VENDOR_ID.ToString() + "','" + invoice.RPS_ID.ToString() + "','" + invoice.COMMODITY + "','" + invoice.TRADED.ToString() + "','" + invoice.COMMODITY_CODE + "','" + invoice.FRR_NO + "','" + invoice.LPC + "','" + invoice.VFA + "','" + invoice.BARREL_QTY.ToString() + "','" + invoice.LUMB_QTY.ToString() + "','" + invoice.EMPTY_QTY.ToString() + "','" + invoice.WET_WT.ToString() + "','" + invoice.DRC.ToString() + "','" + invoice.RATE_KG.ToString() + "','" + invoice.SPOT_CONTRACT.ToString() + "','" + invoice.CODE_NO + "','" + invoice.DRY_WT.ToString() + "','" + invoice.AMOUNT.ToString() + "','" +invoice.LUMB_PRICE.ToString()+ "','" +invoice.LUMB_AMOUNT.ToString()+ "','" +invoice.NO_TAX_AMOUNT.ToString()+ "','" + invoice.CGST.ToString() + "','" + invoice.SGST.ToString() + "','" + invoice.TOTAL_AMOUNT.ToString() + "')";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        public DataTable GetInvoiceID()
        {
            Sql = "SELECT IDENT_CURRENT('INVOICE')+1";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            return dt;
        }
    }
}