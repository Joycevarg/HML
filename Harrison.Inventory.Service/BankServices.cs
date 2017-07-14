using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class BankServices:IBankServices

    {
        private IBankData _bankdata;
        public BankServices(BankData Bankdata)
        {
            _bankdata = Bankdata;
        }
        public DataTable Arrangebank(SortType sortType, SortFieldType sortField)
        {
            DataTable banks = _bankdata.GetBankDetails();
           /* if (sortType == SortType.Ascending)
            {
                banks = banks.OrderBy(p => p.BANK_ID).ToList();
            }
            else
            {
                banks = banks.OrderByDescending(p => p.BANK_ID).ToList();
            } */
            return banks;
        
        
        }
        public void AddBank(String BankName)
        {

            _bankdata.AddBank(BankName);

        }
       
    }
}
