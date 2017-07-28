using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Service
{

    public interface IBankServices
    {
        DataTable Arrangebank(SortType sortType, SortFieldType sortField);
        void AddBank(String BankName);
        void DeleteBank(object Bankid);
    }
}
