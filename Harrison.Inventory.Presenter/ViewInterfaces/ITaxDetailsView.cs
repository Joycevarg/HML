using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Harrison.Inventory.Presenter
{
    public interface ITaxDetailsView
    {
        void givearrdata(DataTable taxdetails);
        void setFinancialYears(DataTable finyears);
    }
}
