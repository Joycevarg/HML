using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IRPSPresenter
    {
        void DefaultRPSOrder();
        void ChangeRPSOrder(SortType sortType, SortFieldType sortField);
    }
}