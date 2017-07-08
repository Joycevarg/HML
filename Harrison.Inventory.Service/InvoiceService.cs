using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class InvoiceServices : IInvoiceServices
    {
        private IInvoiceData _invoicedata;
        public InvoiceServices(InvoiceData _InvoiceData)
        {
            _invoicedata = _InvoiceData;
        }
        public DataTable ArrangeVendorData()
        {
            DataTable vendors = _invoicedata.GetVendorDetails();
            /*    if (sortType == SortType.Ascending)
                {
                    clusters = clusters.OrderBy(p => p.CLUSTER_ID).ToList();
                }
                else
                {
                    clusters = clusters.OrderByDescending(p => p.CLUSTER_ID).ToList();
                } */
            return vendors;


        }
    }
}