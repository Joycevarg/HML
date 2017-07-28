using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IInvoicePresenter
    {
        void DefaultInvoiceOrder();
        void ChangeInvoiceOrder(SortType sortType, SortFieldType sortField);
        void SetVendorNames();
        void SetRPSNames(object vendorid);
        void AddInvoice(int moved, string date, int vid, int rid, string comm, int trade, string commcode, string frr, string lpc, string vfa, float bqty, float lqty, float eqty, float wwt, float drc, float ratekg, int spot_contract, string code, float dwt, float amnt, float lumbprice, float lumbamnt, float notaxamnt, float cgst, float sgst, float tamnt);
        void UpdateInvoice(int invid, int moved, string date, int vid, int rid, string comm, int trade, string commcode, string frr, string lpc, string vfa, float bqty, float lqty, float eqty, float wwt, float drc, float ratekg, int spot_contract, string code, float dwt, float amnt, float lumbprice, float lumbamnt, float notaxamnt, float cgst, float sgst, float tamnt);
        TaxDetails GetTax(string invoicedate);
        void setSpotContractNames();
        void setInvID();
        int VendorRegistered(string vendorid);
        void DeleteInvoice(object Invoiceid);
    }
}
