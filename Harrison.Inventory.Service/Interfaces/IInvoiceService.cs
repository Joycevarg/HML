using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Harrison.Inventory.Service
{
    public interface IInvoiceServices
    {
        DataTable ArrangeVendorData();
    }
}
