using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IClusterPresenter
    {
        void DefaultClusterOrder();
        void ChangeClusterOrder(SortType sortType, SortFieldType sortField);
        void setStateValues();
        void AddCluster(String ClusterName, int stateid);
        void DeleteCluster(object Clusterid);
    }
}
