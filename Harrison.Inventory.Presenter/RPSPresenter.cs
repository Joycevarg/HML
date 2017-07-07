using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Service;

namespace Harrison.Inventory.Presenter
{
    public class RPSPresenter : IRPSPresenter
    {
        private IRPSView _irpsview;
        private IRPSServices _irpsservice;
        public RPSPresenter(IRPSView rpsview, IRPSServices rpsservice)
        {
            _irpsservice = rpsservice;
            _irpsview = rpsview;
        }
        public void DefaultRPSOrder()
        {
            _irpsview.givearrdata(_irpsservice.ArrangeRPS(SortType.Ascending, SortFieldType.Id));
        }
        public void ChangeRPSOrder(SortType srttype, SortFieldType srtfield)
        {
            _irpsview.givearrdata(_irpsservice.ArrangeRPS(srttype, srtfield));
        }
    }
}
