using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;


namespace Harrison.Inventory.Service
{
    public class VendorReportService:IVendorReportService
    {
        IServicefunctions servicefunction = new ServiceFunctions();
        IReportdata reportdata=new ReportData();
        public void DataTableToExcel(int venid, string fromdate="", string todate="")
        {
            string filename="";
            DataTable dt = new DataTable();
            dt = reportdata.GetReportData(venid, fromdate, todate);
            servicefunction.ExportToExcel(dt,1,venid, filename);
        }
     

     }
}
