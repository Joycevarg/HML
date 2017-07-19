using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IPaymentInfoPresenter
    {
         void DefaultPaymentInfoOrder();
         void ChangePaymentInfoOrder(SortType srttype, SortFieldType srtfield);
        void AddPaymentInfo(int invid, int venid, string paiddate,float topay, float fromho, float otherdebit, string paymentmethod, float total, float balance, string remark);
        void SetInvoiceIDs();
        void SetVendorName(int invno);
        void SetToPayAmnt(int invno);
    }
}
