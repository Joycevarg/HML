using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public class BankPresenter:IBankPresenter
    {
        private IBankView _ibankview;
        private IBankServices _ibankservice;
        public BankPresenter(IBankView bankview,IBankServices bankservice)
        {
            _ibankservice=bankservice;
            _ibankview=bankview;
        }
        public void DefaultBankOrder()
        {
            _ibankview.givearrdata(_ibankservice.Arrangebank(SortType.Ascending, SortFieldType.Id));
        }
        public void ChangeBankOrder(SortType srttype,SortFieldType srtfield)
        {
            _ibankview.givearrdata(_ibankservice.Arrangebank(srttype, srtfield));
        }
        public void AddBank(String BankName)
        {

            _ibankservice.AddBank(BankName);

        }
    }
}
