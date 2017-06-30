using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Service
{
    public interface IStateServices
    {
        List<State> ArrangeState(SortType sortType, SortFieldType sortField);

    }
}
