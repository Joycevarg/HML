﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class BankServices:IBankServices

    {
        private BankData _bankdata;
        public BankServices(BankData Bankdata)
        {
            _bankdata = Bankdata;
        }
        public List<Bank> Arrangebank(SortType sortType, SortFieldType sortField)
        {
            List<Bank> banks = _bankdata.GetBankDetails();
            if (sortType == SortType.Ascending)
            {
                banks = banks.OrderBy(p => p.BANK_ID).ToList();
            }
            else
            {
                banks = banks.OrderByDescending(p => p.BANK_ID).ToList();
            }
            return banks;
        
        
        }
       
    }
}
