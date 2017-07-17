using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
    public class SPOT_CONTRACT
    {
        public int IDMember { get; set; }
        public string displayMember { get; set; }
        public SPOT_CONTRACT(int id, string name)
        {
            this.IDMember = id;
            this.displayMember = name;
        }
    }
}
