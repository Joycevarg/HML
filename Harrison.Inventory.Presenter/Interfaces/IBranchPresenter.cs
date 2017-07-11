using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IBranchPresenter
    {
        void DefaultBranchOrder();
        void ChangeBranchOrder(SortType sortType, SortFieldType sortField);
        void setBankNames();
    }
}