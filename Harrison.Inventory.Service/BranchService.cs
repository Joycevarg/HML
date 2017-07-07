﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class BranchServices : IBranchServices
    {
        private BranchData _branchdata;
        public BranchServices(BranchData Branchdata)
        {
            _branchdata = Branchdata;
        }
        public DataTable ArrangeBranch(SortType sortType, SortFieldType sortField)
        {
            DataTable branchs = _branchdata.GetBranchDetails();
            /*    if (sortType == SortType.Ascending)
                {
                    districts = districts.OrderBy(p => p.DISTRICT_ID).ToList();
                }
                else
                {
                    districts = districts.OrderByDescending(p => p.DISTRICT_ID).ToList();
                } */
            return branchs;

        }
    }
}