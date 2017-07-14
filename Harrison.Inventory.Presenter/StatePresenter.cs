using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public class StatePresenter : IStatePresenter
    {
        private IStateView _istateview;
        private IStateServices _istateservice;
        public StatePresenter(IStateView stateview, IStateServices stateservice)
        {
            _istateservice = stateservice;
            _istateview = stateview;
        }
        public void DefaultStateOrder()
        {
            _istateview.givearrdata(_istateservice.ArrangeState(SortType.Ascending, SortFieldType.Id));
        }
        public void ChangeStateOrder(SortType srttype, SortFieldType srtfield)
        {
            _istateview.givearrdata(_istateservice.ArrangeState(srttype, srtfield));
        }
        public void AddState(String StateName)
        {

            _istateservice.AddState(StateName);

        }
    }
}
