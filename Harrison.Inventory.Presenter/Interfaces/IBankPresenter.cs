using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IBankPresenter
    {
        void DefaultBankOrder();
        void ChangeBankOrder(SortType sortType, SortFieldType sortField);
        void AddBank(String Bank);
        void DeleteBank(object Bankid);
        void UpdateBank(int bankid, string bankname);
    }
}
