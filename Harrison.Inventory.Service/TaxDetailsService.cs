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
        public void AddTaxDetails(int finid, string effectdate,string enddate, float cgst, float sgst)
        {
            TaxDetails taxdetails = new TaxDetails(finid, effectdate,enddate, cgst, sgst);
            taxdetailsdata.AddTaxDetails(taxdetails);
        }
        public void UpdateTaxDetails(int finid, string effectdate, string enddate, float cgst, float sgst)
        {
            TaxDetails taxdetails = new TaxDetails(finid, effectdate, enddate, cgst, sgst);
            taxdetailsdata.UpdateTaxDetails(taxdetails);
        }
        public void DeleteTaxDetails(object FinYearid)
        {
            taxdetailsdata.DeleteTaxDetails(FinYearid.ToString()); 
        }
       
        public TaxDetails TaxFromDate(DateTime invoicedate)
        {
            DataTable taxdetails = taxdetailsdata.GetTaxDetails();
            TaxDetails tax = new TaxDetails(0, "null", "null", 0, 0);
            DateTime effectdate, enddate;
            foreach (DataRow row in taxdetails.Rows)
            { 
                effectdate=DateTime.Parse(row["EFFECT_DATE"].ToString());
                enddate=DateTime.Parse(row["END_DATE"].ToString());
                if (DateTime.Compare(invoicedate, effectdate) >= 0 && DateTime.Compare(invoicedate, enddate) <= 0)
                {
                   
                    tax.CGST = float.Parse(row["CGST"].ToString());
                    tax.SGST = float.Parse(row["SGST"].ToString());
                }
            }
            return tax;
        }
    }
}
