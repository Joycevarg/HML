
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Data.Model
{
      public class FinancialYears
    {
        
    #region //public properties
        public int FIN_YEAR_ID{get;set;}
        public string FIN_YEAR_NAME { get; set; }   
    #endregion
    #region //Constructors
public FinancialYears(int FinancialYearId,string FinancialYear)
{
    this.FIN_YEAR_ID=FinancialYearId;
    this.FIN_YEAR_NAME=FinancialYear;
}


    #endregion
    }
}
