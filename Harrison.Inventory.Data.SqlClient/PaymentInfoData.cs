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
            Sql = "Delete PAYMENT_FORM where INVOICE_ID=" + invoiceid;
            dt = Dbcon.Sqlconnection(Sql, "Delete");
        }
        public void UpdatePaymentForm(PaymentInfo paymentinfo)
        {
            Sql = "UPDATE PAYMENT_FORM set VENDOR_ID='" + paymentinfo.VENDOR_ID.ToString() + "',PAID_DATE='" + paymentinfo.PAID_DATE + "',TO_PAY=" + paymentinfo.TO_PAY.ToString() + ",FROM_HO=" + paymentinfo.FROM_HO.ToString() + ",OTHER_DEBITS=" + paymentinfo.OTHER_DEBITS.ToString() + ",PAYMENT_METHOD='" + paymentinfo.PAYMENT_METHOD + "',TOTAL_PAID=" + paymentinfo.TOTAL_PAID.ToString() + ",BALANCE=" + paymentinfo.BALANCE.ToString() + ",REMARKS='" + paymentinfo.REMARKS + "' WHERE INVOICE_ID="+paymentinfo.INVOICE_ID.ToString();
            dt = Dbcon.Sqlconnection(Sql, "Update");
        }
    }
}
