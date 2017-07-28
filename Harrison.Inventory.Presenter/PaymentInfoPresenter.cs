using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Presenter
{
    public  class PaymentInfoPresenter:IPaymentInfoPresenter
    {   private IPaymentInfoService _ipaymentinfoservice;
        private IInvoiceServices _iinvoiceservice;
        private IPaymentInfoView _ipaymentinfoview;
        private IVendorServices _ivendorservices;
        public PaymentInfoPresenter(IPaymentInfoView paymentinfoview, IPaymentInfoService paymentinfoservice)
        {
           _ipaymentinfoservice=paymentinfoservice;
           _ipaymentinfoview = paymentinfoview;
           _iinvoiceservice = new InvoiceServices(new InvoiceData());
           _ivendorservices = new VendorService(new VendorData());
           
        }
        public void DefaultPaymentInfoOrder()
        {
            _ipaymentinfoview.givearrdata(_ipaymentinfoservice.ArrangePaymentInfo(SortType.Ascending, SortFieldType.Id));
        }
        public void ChangePaymentInfoOrder(SortType srttype, SortFieldType srtfield)
        {
            _ipaymentinfoview.givearrdata(_ipaymentinfoservice.ArrangePaymentInfo(srttype, srtfield));
        }
        public void AddPaymentInfo(int invid, int venid, string paiddate,float topay, float fromho, float otherdebit, string paymentmethod, float total, float balance, string remark)
        {
            _ipaymentinfoservice.AddPaymentInfo(invid, venid, paiddate, topay,fromho, otherdebit, paymentmethod, total, balance, remark);
        }
        public void UpdatePaymentInfo(int invid, int venid, string paiddate, float topay, float fromho, float otherdebit, string paymentmethod, float total, float balance, string remark)
        {
            _ipaymentinfoservice.UpdatePaymentInfo(invid, venid, paiddate, topay, fromho, otherdebit, paymentmethod, total, balance, remark);
        }
        public void DeletePaymentInfo(object Invid)
        {
            _ipaymentinfoservice.DeletePaymentInfo(Invid);
        }
        public void SetInvoiceIDs()
        {
            _ipaymentinfoview.SetInvoiceValues(_iinvoiceservice.ArrangeInvoices(SortType.Ascending,SortFieldType.Id));
        }
        public void SetVendorName(int invno)
        {
            _ipaymentinfoview.SetVendorName(_ivendorservices.GetVendorName(_iinvoiceservice.GetVendorID(invno)));
        }
        public void SetToPayAmnt(int invno)
        {
            _ipaymentinfoview.SetToPayAmount(_iinvoiceservice.GetAmount(invno));
        }

    }
}
