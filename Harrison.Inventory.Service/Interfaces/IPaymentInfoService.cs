using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Service
{
    public interface IPaymentInfoService
    {
        DataTable ArrangePaymentInfo(SortType sortType, SortFieldType sortField);
        void AddPaymentInfo(int invid, int venid, string paiddate,float topay, float fromho, float otherdebit, string paymentmethod, float total, float balance, string remark);
        void DeletePaymentInfo(object invid);
        void UpdatePaymentInfo(int invid, int venid, string paiddate, float topay, float fromho, float otherdebit, string paymentmethod, float total, float balance, string remark);
    }
}
