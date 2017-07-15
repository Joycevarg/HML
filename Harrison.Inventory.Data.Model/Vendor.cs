using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
    public class Vendor
    {
        public int VENDOR_ID { get; set; }
        public string VENDOR_NAME { get; set; }
        public string HOME_ADDRESS { get; set; }
        public int HOME_DISTRICT_ID { get; set; }
        public int HOME_STATE_ID { get; set; }
        public string ESTATE_ADDRESS { get; set; }
        public int ESTATE_DISTRICT_ID { get; set; }
        public int ESTATE_STATE_ID { get; set; }
        public string OWNER_ADDRESS { get; set; }
        public string TAPPER_NO { get; set; }
        public string OCCUPATION { get; set; }
        public string OWNER_NO { get; set; }
        public int DEALER_GROWER { get; set; }
        public string LICENSE_NO { get; set; }
        public string TIN_NO { get; set; }
        public string CST_NO { get; set; }
        public string REMARKS {get;set;}
        public string VENDOR_CR_DATE { get; set; }
        public string VENDOR_UP_DATE { get; set; }
        public string VENDOR_STATUS { get; set; }
        public int BANK_ID { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string BRANCH_NAME { get; set; }
        public int BRANCH_ID { get; set; }
        public int REGISTERED { get; set; }
        public Vendor(string vendorname, string homeaddr, int homedist, int homestat, string estateaddr, int estatdist, int estatstat, string owneraddr, string tappno, string occup, string ownerno, int dealgrow, string licenno, string tinno, string cstno, string remark, string vendcrdate, string vendupdate, string vendstat,int bankid, int branchid, string branchname,string accno, int register)
        {
            this.VENDOR_ID = 0;
            this.VENDOR_NAME = vendorname;
            this.HOME_ADDRESS = homeaddr;
            this.HOME_DISTRICT_ID = homedist;
            this.HOME_STATE_ID = homestat;
            this.ESTATE_ADDRESS = estateaddr;
            this.ESTATE_DISTRICT_ID = estatdist;
            this.ESTATE_STATE_ID = estatstat;
            this.OWNER_ADDRESS = owneraddr;
            this.TAPPER_NO = tappno;
            this.OCCUPATION = occup;
            this.OWNER_NO = ownerno;
            this.DEALER_GROWER = dealgrow;
            this.LICENSE_NO = licenno;
            this.TIN_NO = tinno;
            this.CST_NO = cstno;
            this.REMARKS = remark;
            this.VENDOR_CR_DATE = vendcrdate;
            this.VENDOR_UP_DATE = vendupdate;
            this.VENDOR_STATUS = vendstat;
            this.BANK_ID = bankid;
            this.BRANCH_ID = branchid;
            this.BRANCH_NAME = branchname;
            this.ACCOUNT_NO = accno;
            this.REGISTERED = register;
        }
    }
}
