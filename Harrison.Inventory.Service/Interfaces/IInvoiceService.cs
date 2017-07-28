using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Service
{
    public interface IInvoiceServices
    {
        DataTable ArrangeInvoices(SortType srttype,SortFieldType srtfld);
        void AddInvoice(int ino, int moved, string date, int vid, int rid, string comm, int trade, string commcode, string frr, string lpc, string vfa, float bqty, float lqty, float eqty, float wwt, float drc, float ratekg, int spot_contract, string code, float dwt, float amnt,float lumbprice,float floatamnt,float notaxamnt, float cgst, float sgst, float tamnt);
        string GenerID();
        void UpdateInvoice(int ino, int moved, string date, int vid, int rid, string comm, int trade, string commcode, string frr, string lpc, string vfa, float bqty, float lqty, float eqty, float wwt, float drc, float ratekg, int spot_contract, string code, float dwt, float amnt, float lumbprice, float lumbamnt, float notaxamnt, float cgst, float sgst, float tamnt);
        int GetVendorID(int invoiceno);
        float GetAmount(int invno);
        void DeleteInvoice(object Invoiceid);
    }
}
