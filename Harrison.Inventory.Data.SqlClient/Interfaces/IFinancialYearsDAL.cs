using System;
using System.Collections.Generic;
using System.Text;
using Harrison.Inventory.Data.Model;
using System.Data;

namespace Harrison.Inventory.Data.SqlClient
{
    public interface IFinancialYearsDAL
    {
        DataTable GetAllFinancialYears();
        void AddFinancialYears(String FinYear);
    }
}
