﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public interface IBankData

    {
        DataTable GetBankDetails();
        void AddBank(String BankName);
        void DeleteBank(string BankId);
        void UpdateBank(Bank bank);
    }
}
