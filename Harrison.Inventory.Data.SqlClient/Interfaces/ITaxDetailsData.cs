using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public interface ITaxDetailsData
    {
        DataTable GetTaxDetails();
        void AddTaxDetails(TaxDetails taxdetails);
        void DeleteTaxDetails(string finyear);
    }
}
