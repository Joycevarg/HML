using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
    public class PaymentInfo
    {
        public int INVOICE_ID { get; set; }
        public int VENDOR_ID { get; set; }
        public string PAID_DATE { get; set; }
        public float TO_PAY { get; set; }
        public float FROM_HO { get; set; }
        public float OTHER_DEBITS { get; set; }
        public string PAYMENT_METHOD { get; set; }
        public float TOTAL_PAID { get; set; }
        public float BALANCE { get; set; }
        public string REMARKS { get; set; }
        public PaymentInfo(int InvID, int VenID, string PaidDate,float ToPay,float FromHO, float OtherDebits, string PaymentMethod, float Total, float Balance, string remarks)
        {
            this.INVOICE_ID = InvID;
            this.VENDOR_ID = VenID;
            this.PAID_DATE = PaidDate;
            this.TO_PAY = ToPay;
            this.FROM_HO = FromHO;
            this.OTHER_DEBITS = OtherDebits;
            this.PAYMENT_METHOD = PaymentMethod;
            this.TOTAL_PAID = Total;
            this.BALANCE = Balance;
            this.REMARKS = remarks;
        
        
        }
    }
}
