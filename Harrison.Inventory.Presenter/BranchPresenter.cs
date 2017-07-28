using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;
namespace Harrison.Inventory.Presenter
{
    public class BranchPresenter : IBranchPresenter
    {
        private IBranchView _ibranchview;
        private IBranchServices _ibranchservice;
        private IBankServices _ibankservice = new BankServices(new BankData());
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
        public void setBankNames()
        {
            _ibranchview.setBankValues(_ibankservice.Arrangebank(SortType.Ascending, SortFieldType.Id));
        }
        public void AddBranch(string branchname, int bankid, string ifsc, string address, string contact)
        {
            _ibranchservice.AddBranch(branchname, bankid, ifsc, address, contact);
        }
        public void DeleteBranch(object Branchid)
        {
            _ibranchservice.DeleteBranch(Branchid);
        }
    }
}