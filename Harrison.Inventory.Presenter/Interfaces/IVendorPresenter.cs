﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IVendorPresenter
    {
        void DefaultVendorOrder();
        void ChangeVendorOrder(SortType sortType, SortFieldType sortField);
    }
}
