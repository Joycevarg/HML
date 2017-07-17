﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
     public interface IInvoiceData
    {
      
        DataTable GetInvoiceDetails();
        void AddInvoice(Invoice invoice);
        DataTable GetInvoiceID();
    }
}
