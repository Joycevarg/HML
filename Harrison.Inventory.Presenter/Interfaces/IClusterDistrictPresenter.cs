using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IClusterDistrictPresenter
    {
        void DefaultClusterDistrictOrder();
        void ChangeClusterDistrictOrder(SortType srttype, SortFieldType srtfield);
        void AddClusterDistrict(int districtid, int clusterid);
        void SetDistrictNames(object stateid);
        void SetClusterNames();
        void DeleteClusterDistrict(object Districtid);
        void UpdateClusterDistrict(int districtid, int clusterid);
    }
}
