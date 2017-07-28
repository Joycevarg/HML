using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class InvoiceServices : IInvoiceServices
    {
        private IInvoiceData _invoicedata;
        public InvoiceServices(InvoiceData _InvoiceData)
        {
            _invoicedata = _InvoiceData;
        }
        public DataTable ArrangeInvoices(SortType srttype,SortFieldType srtfld)
        {
             DataTable invoices = _invoicedata.GetInvoiceDetails();
            /*    if (sortType == SortType.Ascending)
                {
                    clusters = clusters.OrderBy(p => p.CLUSTER_ID).ToList();
                }
                else
                {
                    clusters = clusters.OrderByDescending(p => p.CLUSTER_ID).ToList();
                } */
            return invoices;
        }
        public void AddInvoice(int ino, int moved, string date, int vid, int rid, string comm, int trade, string commcode, string frr, string lpc, string vfa, float bqty, float lqty, float eqty, float wwt, float drc, float ratekg, int spot_contract, string code, float dwt, float amnt,float lumbprice,float lumbamnt,float notaxamnt, float cgst, float sgst, float tamnt)
        {
            Invoice invoice = new Invoice(ino, moved, date, vid, rid, comm, trade, commcode, frr, lpc, vfa, bqty, lqty, eqty, wwt, drc, ratekg, spot_contract, code, dwt, amnt, lumbprice, lumbamnt, notaxamnt, cgst, sgst, tamnt);
            _invoicedata.AddInvoice(invoice);
        
        }
        public void UpdateInvoice(int ino, int moved, string date, int vid, int rid, string comm, int trade, string commcode, string frr, string lpc, string vfa, float bqty, float lqty, float eqty, float wwt, float drc, float ratekg, int spot_contract, string code, float dwt, float amnt, float lumbprice, float lumbamnt, float notaxamnt, float cgst, float sgst, float tamnt)
        {
            Invoice invoice = new Invoice(ino, moved, date, vid, rid, comm, trade, commcode, frr, lpc, vfa, bqty, lqty, eqty, wwt, drc, ratekg, spot_contract, code, dwt, amnt, lumbprice, lumbamnt, notaxamnt, cgst, sgst, tamnt);
            _invoicedata.UpdateInvoice(invoice);

        }
        public string GenerID()
        {
            DataTable dt = _invoicedata.GetInvoiceID();
            string invoiceid;
            int no=100;
            no = int.Parse(dt.Rows[0][0].ToString());
            ServiceFunctions func= new ServiceFunctions();
            invoiceid=func.GenerateID("INV", no,4);
            return invoiceid;
        }
        public int GetVendorID(int invoiceno)
        {
            int vendorid=0;
            int  invoicenum = invoiceno;
            DataTable dt = _invoicedata.GetInvoiceDetails();
            foreach (DataRow row in dt.Rows)
            {
                if (int.Parse(row["INVOICE_ID"].ToString()) == invoicenum)
                { vendorid = int.Parse(row["VENDOR_ID"].ToString()); break; }

            }
            return vendorid;
        }
        public float GetAmount(int invno)
        {
            float topayamnt=0;
            DataTable dt = _invoicedata.GetInvoiceDetails();
            foreach (DataRow row in dt.Rows)
            {
                if (int.Parse(row["INVOICE_ID"].ToString()) ==invno)
                { topayamnt = float.Parse(row["TOTAL_AMOUNT"].ToString()); break; }

            }
            return topayamnt;
        }
        public void DeleteInvoice(object Invoiceid)
        {

            _invoicedata.DeleteInvoice(Invoiceid.ToString());

        }
    }
}