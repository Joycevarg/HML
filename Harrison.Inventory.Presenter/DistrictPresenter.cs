using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.SqlClient;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;


namespace Harrison.Inventory.Presenter
{
    public class DistrictPresenter:IDistrictPresenter
    {
        private IStateServices _istateservice = new StateServices(new StateData());
         private IDistrictView _idistrictview;
        private IDistrictServices _idistrictservice;
        public DistrictPresenter(IDistrictView districtview,IDistrictServices districtservice)
        {
            _idistrictservice=districtservice;
            _idistrictview=districtview;
        }
        public void DefaultDistrictOrder()
        {
            _idistrictview.givearrdata(_idistrictservice.ArrangeDistrict(SortType.Ascending, SortFieldType.Id));
        }
        public void ChangeDistrictOrder(SortType srttype,SortFieldType srtfield)
        {
            _idistrictview.givearrdata(_idistrictservice.ArrangeDistrict(srttype, srtfield));
        }
        public void setStateNames()
        {
            _idistrictview.setStateValues(_istateservice.ArrangeState(SortType.Ascending, SortFieldType.Id));

        }
    }
}
