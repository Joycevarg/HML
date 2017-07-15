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
        void AddInvoice(int ino, int moved, string date, int vid, int rid, string comm, int trade, string commcode, string frr, string lpc, string vfa, float bqty, float lqty, float eqty, float wwt, float drc, float ratekg, int spot_contract, string code, float dwt, float amnt, float cgst, float sgst, float tamnt);
    }
}
