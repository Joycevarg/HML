using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class PaymentInfoService:IPaymentInfoService
    {
        IPaymentInfoData _paymentinfodata;
        public PaymentInfoService(IPaymentInfoData PaymentInfodata)
        {
            _paymentinfodata = PaymentInfodata;
        }
        public DataTable ArrangePaymentInfo(SortType sortType, SortFieldType sortField)
        {
            DataTable paymentinfos = _paymentinfodata.GetPaymentInfoDetails();
        /*    if (sortType == SortType.Ascending)
            {
                districts = districts.OrderBy(p => p.DISTRICT_ID).ToList();
            }
            else
            {
                districts = districts.OrderByDescending(p => p.DISTRICT_ID).ToList();
            } */
            return paymentinfos;
        }
        public void AddPaymentInfo(int invid,int venid,string paiddate,float topay,float fromho,float otherdebit,string paymentmethod,float total,float balance,string remark)
        {
            PaymentInfo paymentinfo = new PaymentInfo(invid, venid, paiddate,topay, fromho, otherdebit, paymentmethod, total, balance, remark);
            _paymentinfodata.AddPaymentInfo(paymentinfo);
        }
        public void DeletePaymentInfo(object invid)
        {
            _paymentinfodata.DeletePaymentInfo(invid.ToString());
        }
    }
}
