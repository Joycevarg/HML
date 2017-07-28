using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class StateServices : IStateServices
    {
        private IStateData _statedata;
        public StateServices(StateData Statedata)
        {
            _statedata = Statedata;
        }
        public DataTable ArrangeState(SortType sortType, SortFieldType sortField)
        {
            DataTable states = _statedata.GetStateDetails();
        /*    if (sortType == SortType.Ascending)
            {
                states = states.OrderBy(p => p.STATE_ID).ToList();
            }
            else
            {
                states = states.OrderByDescending(p => p.STATE_ID).ToList();
            } */
            return states;


        }
        public void AddState(String StateName)
        {
            _statedata.AddState(StateName);
        }
        public void DeleteState(object stateid)
        {
            _statedata.DeleteState(stateid.ToString());
        }
       
    }
}
