using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Presenter
{
    public interface IInvoiceView
    {
        void givearrdata(DataTable branchs);
        void setVendorValues(DataTable vendors);
        void setRPSValues(DataTable rpss); 
        void setSpotContractValues();
    }
}
