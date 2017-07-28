﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Service
{
    public interface IClusterDistrictservice
    {
        DataTable ArrangeClusterDistrict(SortType sortType, SortFieldType sortField);
        void AddClusterDistrict(int districtid, int clusterid);
        void DeleteClusterDistrict(object Districtid);
        void UpdateClusterDistrict(int districtid, int clusterid);
    }
}
