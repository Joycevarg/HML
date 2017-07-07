using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
    public class Branch
    {
        public int BRANCH_ID { get; set; }
        public string BRANCH_NAME { get; set; }
        public int BANK_ID { get; set; }
        public string IFSC_CODE { get; set; }
        public string BRANCH_ADDRESS { get; set; }
        public string CONTACT_NO { get; set; }

        public Branch(int branchid, string branchname, int bankid, string ifsc, string address, string contact)
        {
            this.BRANCH_ID = branchid;
            this.BRANCH_NAME = branchname;
            this.BANK_ID=bankid;
            this.IFSC_CODE=ifsc;
            this.BRANCH_ADDRESS=address;
            this.CONTACT_NO = contact;
        }
    }
}
