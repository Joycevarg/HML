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
        private IBranchServices _ibranchservices;
        private IBankServices _ibankservices;
        public VendorPresenter(IVendorView vendorview, IVendorServices vendorservice)
        {
            _ivendorservice = vendorservice;
            _ivendorview = vendorview;
            _ihstateservice = new StateServices(new StateData());
            _iestateservice = new StateServices(new StateData());
            _ihdistrictservice = new DistrictServices(new DistrictData());
            _iedistrictservice = new DistrictServices(new DistrictData());
            _ibranchservices = new BranchServices(new BranchData());
            _ibankservices= new BankServices(new BankData());

        }
        public void DefaultVendorOrder()
        {
            _ivendorview.givearrdata(_ivendorservice.ArrangeVendor(SortType.Ascending, SortFieldType.Id));
        }
        public void DeleteVendor(object Vendorid)
        {
            _ivendorservice.DeleteVendor(Vendorid);
        }
        public void ChangeVendorOrder(SortType srttype, SortFieldType srtfield)
        {
            _ivendorview.givearrdata(_ivendorservice.ArrangeVendor(srttype, srtfield));
        }
        public void setBankNames()
        {
            _ivendorview.setBankValues(_ibankservices.Arrangebank(SortType.Ascending,SortFieldType.Id));
        }
        public void setBranchNames(object bankid)
        {
            _ivendorview.setBranchValues(_ibranchservices.BranchwithBank(bankid));
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
        
        public void AddVendor(string vendorname, string homeaddr, int homedist, int homestat, string estateaddr, int estatdist, int estatstat, string owneraddr, string tappno, string occup, string ownerno, int dealgrow, string licenno, string tinno, string cstno, string remark, string vendcrdate, string vendupdate, string vendstat, int bankid, int branchid,string accno, int register)
        
        {
            _ivendorservice.AddVendor(vendorname, homeaddr, homedist, homestat, estateaddr, estatdist, estatstat, owneraddr, tappno, occup, ownerno, dealgrow, licenno, tinno, cstno, remark, vendcrdate, vendupdate, vendstat, bankid, branchid,accno, register);
        

        }
    }
}
