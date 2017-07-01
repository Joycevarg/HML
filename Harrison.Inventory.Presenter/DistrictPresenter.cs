using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Service;

namespace Harrison.Inventory.Presenter
{
    public class DistrictPresenter:IDistrictPresenter
    {
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
    }
}
