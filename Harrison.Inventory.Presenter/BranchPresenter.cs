using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public class BranchPresenter : IBranchPresenter
    {
        private IBranchView _ibranchview;
        private IBranchServices _ibranchservice;
        public BranchPresenter(IBranchView branchview, IBranchServices branchservice)
        {
            _ibranchservice = branchservice;
            _ibranchview = branchview;
        }
        public void DefaultBranchOrder()
        {
            _ibranchview.givearrdata(_ibranchservice.ArrangeBranch(SortType.Ascending, SortFieldType.Id));
        }
        public void ChangeBranchOrder(SortType srttype, SortFieldType srtfield)
        {
            _ibranchview.givearrdata(_ibranchservice.ArrangeBranch(srttype, srtfield));
        }
    }
}