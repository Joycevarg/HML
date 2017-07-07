using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public class VendorPresenter : IVendorPresenter
    {
        private IVendorView _ivendorview;
        private IVendorServices _ivendorservice;
        public VendorPresenter(IVendorView vendorview, IVendorServices vendorservice)
        {
            _ivendorservice = vendorservice;
            _ivendorview = vendorview;
        }
        public void DefaultVendorOrder()
        {
            _ivendorview.givearrdata(_ivendorservice.ArrangeVendor(SortType.Ascending, SortFieldType.Id));
        }
        public void ChangeVendorOrder(SortType srttype, SortFieldType srtfield)
        {
            _ivendorview.givearrdata(_ivendorservice.ArrangeVendor(srttype, srtfield));
        }
    }
}
