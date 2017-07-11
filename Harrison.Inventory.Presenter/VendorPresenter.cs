using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;
namespace Harrison.Inventory.Presenter
{
    public class VendorPresenter : IVendorPresenter
    {
        private IVendorView _ivendorview;
        private IStateServices _istateservice;
        private IVendorServices _ivendorservice;
        private IDistrictServices _idistrictservice;
        public VendorPresenter(IVendorView vendorview, IVendorServices vendorservice)
        {
            _ivendorservice = vendorservice;
            _ivendorview = vendorview;
            _istateservice = new StateServices(new StateData());
            _idistrictservice = new DistrictServices(new DistrictData());
        }
        public void DefaultVendorOrder()
        {
            _ivendorview.givearrdata(_ivendorservice.ArrangeVendor(SortType.Ascending, SortFieldType.Id));
        }
        public void ChangeVendorOrder(SortType srttype, SortFieldType srtfield)
        {
            _ivendorview.givearrdata(_ivendorservice.ArrangeVendor(srttype, srtfield));
        }
        public void setHstateNames()
        {
            _ivendorview.setHStateValues(_istateservice.ArrangeState(SortType.Ascending, SortFieldType.Id));
        }
        public void setHdistrictNames(object stateid)
        {
            _ivendorview.setHDistrictValues(_idistrictservice.DistrictwithState(stateid));
        }
    }
}
