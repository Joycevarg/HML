using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
    public class RPS
    {
       public int VENDOR_ID { get; set; }
       public int RPS_ID { get; set; }
       public string RPS_NAME { get; set; }
       public string CONTACT_NAME { get; set; }
       public string CONTACT_NO { get; set; }
       public string ROUTE_DETAILS { get; set; }
       public string REMARKS { get; set; }
        public RPS(int vid, int rpsid, string rpsname, string contname, string contno, string route, string remarks)
        {
            this.VENDOR_ID = vid;
            this.RPS_ID = rpsid;
            this.RPS_NAME = rpsname;
            this.CONTACT_NAME = contname;
            this.CONTACT_NO = contno;
            this.ROUTE_DETAILS = route;
            this.REMARKS = remarks;
        }
    }
}
