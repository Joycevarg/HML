using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Service
{

    public interface IBankServices
    {
        List<Bank> Arrangebank(SortType sortType, SortFieldType sortField);
        
    }
}
