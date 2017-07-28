using System;
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
        public void AddBranch(string branchname, int bankid,string ifsc,string address,string contact)
        {
            Branch branch = new Branch(0, branchname, bankid, ifsc, address, contact);
            _branchdata.AddBranch(branch);
        }
        public void DeleteBranch(object Branchid)
        {

            _branchdata.DeleteBranch(Branchid.ToString());

        }
        public void UpdateBranch(int branchid, string branchname, int bankid, string ifsc, string address, string contact)
        {
            Branch branch = new Branch(branchid, branchname, bankid, ifsc, address, contact);
            _branchdata.UpdateBranch(branch);
        }
        public DataTable BranchwithBank(object bankid)
        {
            DataTable branchs = _branchdata.SelectBranchs(bankid);
            return branchs;

        }
    }
}