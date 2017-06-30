using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class StateData:IStateData
    {
        public List<State> GetStateDetails()
        {

            return new List<State> { new State(1, "state1"), new State(2, "state2") };


        }
    }
}
