using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;


namespace Harrison.Inventory.Presenter
{
    public class InvoicePresenter : IInvoicePresenter
    {
        private IInvoiceView _iinvoiceview;
        private IInvoiceServices _iinvoiceservice;
        private IVendorServices _ivendorservice = new VendorService(new VendorData());
        private IRPSServices _irpsservice = new RPSServices(new RPSData());
        public InvoicePresenter(IInvoiceView invoiceview, IInvoiceServices invoiceservice)
        {
            _iinvoiceservice = invoiceservice;
            _iinvoiceview = invoiceview;
        }
        public void SetVendorNames()
        {
            _iinvoiceview.setVendorValues(_ivendorservice.ArrangeVendor(SortType.Ascending, SortFieldType.Id));  //this one
        }
        public void SetRPSNames(object vendorid)
        {
            _iinvoiceview.setRPSValues(_irpsservice.RpswithVendor(vendorid));
        }
    }
}