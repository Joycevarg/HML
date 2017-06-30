using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class StateServices : IStateServices
    {
        private StateData _statedata;
        public StateServices(StateData Statedata)
        {
            _statedata = Statedata;
        }
        public List<State> ArrangeState(SortType sortType, SortFieldType sortField)
        {
            List<State> states = _statedata.GetStateDetails();
            if (sortType == SortType.Ascending)
            {
                states = states.OrderBy(p => p.STATE_ID).ToList();
            }
            else
            {
                states = states.OrderByDescending(p => p.STATE_ID).ToList();
            }
            return states;


        }

    }
}
