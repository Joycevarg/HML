using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public interface IBranchData
    {
        DataTable GetBranchDetails();
        DataTable SelectBranchs(object branchid);
        void AddBranch(Branch branch);
        void DeleteBranch(string BranchId);
        void UpdateBranch(Branch branch);
        
    }
}
