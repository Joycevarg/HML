using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
    public class Bank
    {
        public int BANK_ID { get; set; }
        public string BANK_NAME { get; set; }
        public Bank(int id,string name)
        {
            this.BANK_ID = id;
            this.BANK_NAME = name;
        }

    }
}
