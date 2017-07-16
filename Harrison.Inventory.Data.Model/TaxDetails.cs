using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
    public class TaxDetails
    {
        public int FIN_YEAR_ID{get;set;}
        public string EFFECT_DATE { get; set; }
        public float CGST { get; set; }
        public float SGST { get; set; }
        public TaxDetails(int finyear, string effectdate, float cgst, float sgst)
        {
            this.FIN_YEAR_ID = finyear;
            this.EFFECT_DATE = effectdate;
            this.CGST = cgst;
            this.SGST = sgst;
        }
    }
}
