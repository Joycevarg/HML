using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;
using System.Data;
namespace Harrison.Inventory.Service
{
    public class FinancialYearsService:IFinancialYearsService
    {
        private IFinancialYearsDAL _iFinancialYearsDAL;
        public FinancialYearsService(IFinancialYearsDAL iFinancialYearsDAL)
        {
            _iFinancialYearsDAL = iFinancialYearsDAL;
        }
        public DataTable GetAllFinancialYears(SortType sortType, SortFieldType sortFieldType)
        {
            DataTable financialYears = _iFinancialYearsDAL.GetAllFinancialYears();

          /*  if (sortType == SortType.Ascending)
            {
                financialYears = financialYears.OrderBy(p => p.FIN_YEAR_ID).ToList();
            }
            else
            {
                financialYears = financialYears.OrderByDescending(p => p.FIN_YEAR_NAME).ToList();
            }
            */
            return financialYears;
        }
        public void AddFinancialYears(String FinYear)
        {

            _iFinancialYearsDAL.AddFinancialYears(FinYear);

        }
        public void DeleteFinancialYear(object FinYearid)
        {

            _iFinancialYearsDAL.DeleteFinYear(FinYearid.ToString());

        }
    }
   
}
