using System;
using System.Collections.Generic;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public interface IFinancialYearsDAL
    {
        List<FinancialYears> GetAllFinancialYears();
    }
}
