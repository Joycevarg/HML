using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.SqlClient;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public class ClusterDistrictPresenter:IClusterDistrictPresenter
    {
         private IClusterDistrictView _iclusterdistrictview;
        private IClusterDistrictservice _iclusterdistrictservice;
        private IClusterServices _iclusterservice;
        private IDistrictServices _idistrictservice;
     
        public ClusterDistrictPresenter(IClusterDistrictView clusterdistrictview, IClusterDistrictservice clusterdistrictservice)
        {
            _iclusterdistrictservice = clusterdistrictservice;
            _iclusterdistrictview = clusterdistrictview;
            _iclusterservice = new ClusterServices(new ClusterData());
            _idistrictservice = new DistrictServices(new DistrictData());
        }
        public void DefaultClusterDistrictOrder()
        {
            _iclusterdistrictview.givearrdata(_iclusterdistrictservice.ArrangeClusterDistrict(SortType.Ascending, SortFieldType.Id));
        }
        public void ChangeClusterDistrictOrder(SortType srttype, SortFieldType srtfield)
        {
            _iclusterdistrictview.givearrdata(_iclusterdistrictservice.ArrangeClusterDistrict(srttype, srtfield));
        }
        public void SetDistrictNames()
        {
            _iclusterdistrictview.setDistrictValues(_idistrictservice.ArrangeDistrict(SortType.Ascending, SortFieldType.Id));

        }
        public void DeleteClusterDistrict(object Districtid)
        {
            _iclusterdistrictservice.DeleteClusterDistrict(Districtid);
        }
        public void SetClusterNames()
        {
            _iclusterdistrictview.setClusterValues(_iclusterservice.ArrangeCluster(SortType.Ascending, SortFieldType.Id));
        }
        public void AddClusterDistrict(int districtid, int clusterid)
        {
            _iclusterdistrictservice.AddClusterDistrict(districtid, clusterid);
        }
    }
}
