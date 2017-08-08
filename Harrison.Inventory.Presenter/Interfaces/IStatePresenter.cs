using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
     public interface IStatePresenter
    {
        void DefaultStateOrder();
        void ChangeStateOrder(SortType sortType, SortFieldType sortField);
        void AddState(String StateName);
        void UpdateState(int stateid, string statename);
        void DeleteState(object Stateid);
     }
}
