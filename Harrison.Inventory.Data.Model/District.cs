using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
    public class District
    {
        public int DISTRICT_ID{get;set;}        
        public string DISTRICT_NAME{get;set;}
        public int STATE_ID{get;set;}

        public District(int Did, string Dname, int Sid)
        {
            this.DISTRICT_ID = Did;
            this.DISTRICT_NAME = Dname;
            this.STATE_ID = Sid;

        }
    }
}
