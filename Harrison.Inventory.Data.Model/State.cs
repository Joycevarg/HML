using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
    public class State
    {
        public int STATE_ID { get; set; }
        public string STATE_NAME { get; set; }
        public State(int id, string name)
        {
            this.STATE_ID = id;
            this.STATE_NAME = name;
        }
    }
}
