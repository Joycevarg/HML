using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Presenter
{
    public interface IVendorReportPresenter
    {
        void SetVendorNames();
        void GenerateReport(object venid,DateTime fromdate,DateTime todate);
        void GenerateReport(object venid);
    }
}
