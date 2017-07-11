using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Presenter
{
    public class ClusterPresenter : IClusterPresenter
    {
        private IClusterView _iclusterview;
        private IClusterServices _iclusterservice;
        private IStateServices _istateservice = new StateServices(new StateData());
        public ClusterPresenter(IClusterView clusterview, IClusterServices clusterservice)
        {
            _iclusterservice = clusterservice;
            _iclusterview = clusterview;
        }
        public void DefaultClusterOrder()
        {
            _iclusterview.givearrdata(_iclusterservice.ArrangeCluster(SortType.Ascending, SortFieldType.Id));
        }
        public void ChangeClusterOrder(SortType srttype, SortFieldType srtfield)
        {
            _iclusterview.givearrdata(_iclusterservice.ArrangeCluster(srttype, srtfield));
        }
        public void setStateValues()
        {
            _iclusterview.setStateNames(_istateservice.ArrangeState(SortType.Ascending, SortFieldType.Id));
                
        }
    }
}