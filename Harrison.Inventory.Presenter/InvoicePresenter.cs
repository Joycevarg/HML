using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;
using System.Data;


namespace Harrison.Inventory.Presenter
{
    public class InvoicePresenter : IInvoicePresenter
    {
        private IInvoiceView _iinvoiceview;
        private IInvoiceServices _iinvoiceservice;
        private IVendorServices _ivendorservice ;
        private IRPSServices _irpsservice;
        private ITaxDetailsService _itaxdetailservice;
        public void DefaultInvoiceOrder()
        {
            _iinvoiceview.givearrdata(_iinvoiceservice.ArrangeInvoices(SortType.Ascending, SortFieldType.Id));
           
        }
        public void ChangeInvoiceOrder(SortType srttype, SortFieldType srtfield)
        {
            _iinvoiceview.givearrdata(_iinvoiceservice.ArrangeInvoices(srttype, srtfield));
        }
        public InvoicePresenter(IInvoiceView invoiceview, IInvoiceServices invoiceservice)
        {
            _iinvoiceservice = invoiceservice;
            _iinvoiceview = invoiceview;
            _ivendorservice = new VendorService(new VendorData());
            _irpsservice = new RPSServices(new RPSData());
            _itaxdetailservice = new TaxDetailsService(new TaxDetailsData());

        }
        public TaxDetails GetTax(string invoicedate)
        {
            return _itaxdetailservice.TaxFromDate(DateTime.Parse(invoicedate));
        }
        public void setSpotContractNames()
        {
            _iinvoiceview.setSpotContractValues();
        }
        
        public void SetVendorNames()
        {
            _iinvoiceview.setVendorValues(_ivendorservice.ArrangeVendor(SortType.Ascending, SortFieldType.Id));  
        }
        public void SetRPSNames(object vendorid)
        {
            _iinvoiceview.setRPSValues(_irpsservice.RpswithVendor(vendorid));
        }
        public void AddInvoice(int moved, string date, int vid, int rid, string comm, int trade, string commcode, string frr, string lpc, string vfa, float bqty, float lqty, float eqty, float wwt, float drc, float ratekg, int spot_contract, string code, float dwt, float amnt,float lumbprice,float lumbamnt,float notaxamnt, float cgst, float sgst, float tamnt)
        {
            _iinvoiceservice.AddInvoice(0, moved, date, vid, rid, comm, trade, commcode, frr, lpc, vfa, bqty, lqty, eqty, wwt, drc, ratekg, spot_contract, code, dwt, amnt,lumbprice,lumbamnt,notaxamnt, cgst, sgst, tamnt);

        }
        public void setInvID()
        {
            _iinvoiceview.setID(_iinvoiceservice.GenerID());
        }
        public int VendorRegistered(string vendorid)
        { 
            int vid=int.Parse(vendorid);
            return _ivendorservice.GetVendorRegistered(vid);
        
        }
    }
}