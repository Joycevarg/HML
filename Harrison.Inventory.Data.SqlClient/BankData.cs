using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Data.Model;

namespace Harrison.Inventory.Data.SqlClient
{
    public class BankData:IBankData
    {
        public List<Bank> GetBankDetails()
        { 
        
        return new List<Bank> {new Bank(1,"bank1"),new Bank(2,"bank2")};
        
        
        }
    }
}
