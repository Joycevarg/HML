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
        private IStateServices _ihstateservice,_iestateservice;
        private IVendorServices _ivendorservice;
        private IDistrictServices _ihdistrictservice,_iedistrictservice;
        public VendorPresenter(IVendorView vendorview, IVendorServices vendorservice)
        {
            _ivendorservice = vendorservice;
            _ivendorview = vendorview;
            _ihstateservice = new StateServices(new StateData());
            _iestateservice = new StateServices(new StateData());
            _ihdistrictservice = new DistrictServices(new DistrictData());
            _iedistrictservice = new DistrictServices(new DistrictData());
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
            _ivendorview.setHStateValues(_ihstateservice.ArrangeState(SortType.Ascending, SortFieldType.Id));
        }
        public void setHdistrictNames(object stateid)
        {
            _ivendorview.setHDistrictValues(_ihdistrictservice.DistrictwithState(stateid));
        }
        public void setEdistrictNames(object stateid)
        {
            _ivendorview.setEDistrictValues(_iedistrictservice.DistrictwithState(stateid));
        }
        public void setEstateNames()
        {
            _ivendorview.setEStateValues(_iestateservice.ArrangeState(SortType.Ascending, SortFieldType.Id));
        }
    }
}
