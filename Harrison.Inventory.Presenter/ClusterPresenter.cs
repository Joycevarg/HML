﻿using System;
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
       
        public void DeleteCluster(object Clusterid)
        {
            _iclusterservice.DeleteCluster(Clusterid);
        }
        public void AddCluster(String ClusterName)
        {
            _iclusterservice.AddCluster(ClusterName);
        }
        public void UpdateCluster(int clusterid,String ClusterName)
        {
            _iclusterservice.UpdateCluster(clusterid,ClusterName);
        }
    }
}