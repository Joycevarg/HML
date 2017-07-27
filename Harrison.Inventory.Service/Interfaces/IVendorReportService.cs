using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Service
{
    public interface IVendorReportService
    {
        void DataTableToExcel(int venid, string fromdate="", string todate="");
    }
}
