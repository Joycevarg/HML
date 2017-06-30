using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;
namespace Harrison.Inventory.Service
{
    public class FinancialYearsService:IFinancialYearsService
    {
        private IFinancialYearsDAL _iFinancialYearsDAL;
        public FinancialYearsService(IFinancialYearsDAL iFinancialYearsDAL)
        {
            _iFinancialYearsDAL = iFinancialYearsDAL;
        }
        public List<FinancialYears> GetAllFinancialYears(SortType sortType, SortFieldType sortFieldType)
        {
            List<FinancialYears> financialYears = _iFinancialYearsDAL.GetAllFinancialYears();

            if (sortType == SortType.Ascending)
            {
                financialYears = financialYears.OrderBy(p => p.FIN_YEAR_ID).ToList();
            }
            else
            {
                financialYears = financialYears.OrderByDescending(p => p.FIN_YEAR_NAME).ToList();
            }

            return financialYears;
        }
    }
   
}
