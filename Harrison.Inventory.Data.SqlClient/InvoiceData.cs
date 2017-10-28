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

            Sql = "Select INVOICE_ID,MOVED_RECIEPT as 'MOVED RECIEPT',INVOICE_DATE as 'INVOICE DATE',I.VENDOR_ID,V.VENDOR_NAME AS 'VENDOR NAME',I.RPS_ID,R.RPS_NAME AS 'RPS NAME',COMMODITY,TRADED,COMMODITY_CODE as 'COMMODITY CODE',FRR_NO as 'FRR NO',LPC,VFA,BARREL_QTY as 'BARREL QUANTITY',LUMB_QTY as 'LUMB QUANTITY',EMPTY_QTY as 'EMPTY QUANTITY',WET_WT as 'WET WEIGHT',DRC,RATE_KG as 'RATE PER KG',SPOT_CONTRACT as 'SPOT/CONTRACT',CODE_NO as 'CODE NO',DRY_WT as 'DRY WEIGHT',AMOUNT,LUMB_PRICE as 'LUMB PRICE',LUMB_AMOUNT as 'LUMB AMOUNT',NO_TAX_AMOUNT AS 'AMOUNT WITHOUT TAX',CGST,SGST,TOTAL_AMOUNT AS 'TOTAL AMOUNT' from INVOICE I,VENDOR V,RPS R WHERE I.VENDOR_ID=V.VENDOR_ID AND I.RPS_ID=R.RPS_ID";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        public void AddInvoice(Invoice invoice)
        {
            Sql = "Insert into INVOICE (MOVED_RECIEPT,INVOICE_DATE,VENDOR_ID,RPS_ID,COMMODITY,TRADED,COMMODITY_CODE,FRR_NO,LPC,VFA,BARREL_QTY,LUMB_QTY,EMPTY_QTY,WET_WT,DRC,RATE_KG,SPOT_CONTRACT,CODE_NO,DRY_WT,AMOUNT,LUMB_PRICE,LUMB_AMOUNT,NO_TAX_AMOUNT,CGST,SGST,TOTAL_AMOUNT) values( '" + invoice.MOVED_RECIEPT.ToString() + "','" + invoice.INVOICE_DATE + "','" + invoice.VENDOR_ID.ToString() + "','" + invoice.RPS_ID.ToString() + "','" + invoice.COMMODITY.ToUpper() + "','" + invoice.TRADED.ToString() + "','" + invoice.COMMODITY_CODE.ToUpper() + "','" + invoice.FRR_NO.ToUpper() + "','" + invoice.LPC.ToUpper() + "','" + invoice.VFA.ToUpper() + "','" + invoice.BARREL_QTY.ToString() + "','" + invoice.LUMB_QTY.ToString() + "','" + invoice.EMPTY_QTY.ToString() + "','" + invoice.WET_WT.ToString() + "','" + invoice.DRC.ToString() + "','" + invoice.RATE_KG.ToString() + "','" + invoice.SPOT_CONTRACT.ToString() + "','" + invoice.CODE_NO.ToUpper() + "','" + invoice.DRY_WT.ToString() + "','" + invoice.AMOUNT.ToString() + "','" + invoice.LUMB_PRICE.ToString() + "','" + invoice.LUMB_AMOUNT.ToString() + "','" + invoice.NO_TAX_AMOUNT.ToString() + "','" + invoice.CGST.ToString() + "','" + invoice.SGST.ToString() + "','" + invoice.TOTAL_AMOUNT.ToString() + "')";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        public void UpdateInvoice(Invoice invoice)
        {
            Sql = "UPDATE INVOICE set MOVED_RECIEPT=" + invoice.MOVED_RECIEPT + ",INVOICE_DATE='" + invoice.INVOICE_DATE + "',VENDOR_ID='" + invoice.VENDOR_ID.ToString() + "',RPS_ID='" + invoice.RPS_ID.ToString() + "',COMMODITY='" + invoice.COMMODITY.ToUpper() + "',TRADED='" + invoice.TRADED.ToString() + "',COMMODITY_CODE='" + invoice.COMMODITY_CODE.ToUpper() + "',FRR_NO='" + invoice.FRR_NO.ToUpper() + "',LPC='" + invoice.LPC.ToUpper() + "',VFA='" + invoice.VFA.ToUpper() + "',BARREL_QTY='" + invoice.BARREL_QTY.ToString() + "',LUMB_QTY='" + invoice.LUMB_QTY.ToString() + "',EMPTY_QTY='" + invoice.EMPTY_QTY.ToString() + "',WET_WT='" + invoice.WET_WT.ToString() + "',DRC='" + invoice.DRC.ToString() + "',RATE_KG='" + invoice.RATE_KG.ToString() + "',SPOT_CONTRACT='" + invoice.SPOT_CONTRACT.ToString() + "',CODE_NO='" + invoice.CODE_NO.ToUpper() + "',DRY_WT='" + invoice.DRY_WT.ToString() + "',AMOUNT='" + invoice.AMOUNT.ToString() + "',LUMB_PRICE='" + invoice.LUMB_PRICE.ToString() + "',LUMB_AMOUNT='" + invoice.LUMB_AMOUNT.ToString() + "',NO_TAX_AMOUNT='" + invoice.NO_TAX_AMOUNT.ToString() + "',CGST='" + invoice.CGST.ToString() + "',SGST='" + invoice.SGST.ToString() + "',TOTAL_AMOUNT='" + invoice.TOTAL_AMOUNT.ToString() + "' WHERE INVOICE_ID=" + invoice.INVOICE_ID.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Update");
        }
        public DataTable GetInvoiceID()
        {
            Sql = "SELECT IDENT_CURRENT('INVOICE')+1";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            return dt;
        }
        public void DeleteInvoice(string invoiceid)
        {
            Sql = "Delete INVOICE where INVOICE_ID=" + invoiceid;
            dt = Dbcon.Sqlconnection(Sql, "Delete");
        }
    }
}