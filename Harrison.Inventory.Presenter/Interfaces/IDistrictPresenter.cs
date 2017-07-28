﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IDistrictPresenter
    {
        void DefaultDistrictOrder();
        void ChangeDistrictOrder(SortType sortType, SortFieldType sortField);
        void setStateNames();
        void AddDistrict(String DistrictName, int stateid);
        void DeleteDistrict(object Districtid);
    }
}
