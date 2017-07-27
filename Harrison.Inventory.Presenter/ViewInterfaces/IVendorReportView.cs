using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Harrison.Inventory.Presenter
{
    public interface IVendorReportView
    {
        void SetVendorValues(DataTable vendors);
    }
}
