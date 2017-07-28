using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class PaymentInfoData:IPaymentInfoData
    {
        String Sql;
        DataTable dt = new DataTable();
        DBConnection Dbcon = new DBConnection();

        public DataTable GetPaymentInfoDetails()
        {

            Sql = "Select * from PAYMENT_FORM";
            dt = Dbcon.Sqlconnection(Sql, "Select");
            //da.Fill(dt);
            return (dt);
        }
        public void AddPaymentInfo(PaymentInfo paymentinfo)
        {
            Sql = "Insert into PAYMENT_FORM (INVOICE_ID,VENDOR_ID,PAID_DATE,TO_PAY,FROM_HO,OTHER_DEBITS,PAYMENT_METHOD,TOTAL_PAID,BALANCE,REMARKS) values( '" + paymentinfo.INVOICE_ID.ToString() + "','" + paymentinfo.VENDOR_ID.ToString() + "','" + paymentinfo.PAID_DATE + "'," +paymentinfo.TO_PAY.ToString()+ "," + paymentinfo.FROM_HO.ToString() + "," + paymentinfo.OTHER_DEBITS.ToString() + ",'" + paymentinfo.PAYMENT_METHOD + "'," + paymentinfo.TOTAL_PAID.ToString() + "," + paymentinfo.BALANCE.ToString() + ",'" +paymentinfo.REMARKS +"')";
            dt = Dbcon.Sqlconnection(Sql, "Insert");
        }
        public void DeletePaymentInfo(string invoiceid)
        {
            Sql = "Delete PAYMENT_FORM where INVOICEID=" + invoiceid;
            dt = Dbcon.Sqlconnection(Sql, "Delete");
        }

    }
}
