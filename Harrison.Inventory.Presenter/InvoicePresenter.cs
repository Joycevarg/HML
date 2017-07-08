using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public class InvoicePresenter:IInvoicePresenter
    {
        private IInvoiceView _iinvoiceview;
        private IInvoiceServices _iinvoiceservice;
        public InvoicePresenter(IInvoiceView invoiceview, IInvoiceServices invoiceservice)
        {
            _iinvoiceservice = invoiceservice;
            _iinvoiceview = invoiceview;
        }
        public void SetVendorValues()
        {
            _iinvoiceview.setVendorNames(_iinvoiceservice.ArrangeVendorData());
        }
    }
}
