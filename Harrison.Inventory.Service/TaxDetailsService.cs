using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class TaxDetailsService:ITaxDetailsService
    {
         private ITaxDetailsData taxdetailsdata;
        public TaxDetailsService(ITaxDetailsData taxdetaildata)
        {
            taxdetailsdata = taxdetaildata;
        }
        public DataTable ArrangeTaxDetails(SortType sortType, SortFieldType sortField)
        {
            DataTable taxdetails = taxdetailsdata.GetTaxDetails();
            /*    if (sortType == SortType.Ascending)
                {
                    districts = districts.OrderBy(p => p.DISTRICT_ID).ToList();
                }
                else
                {
                    districts = districts.OrderByDescending(p => p.DISTRICT_ID).ToList();
                } */
            return taxdetails;

        }
        public void AddTaxDetails(int finid, string effectdate, float cgst, float sgst)
        {
            TaxDetails taxdetails = new TaxDetails(finid, effectdate, cgst, sgst);
            taxdetailsdata.AddTaxDetails(taxdetails);
        }
    }
}
