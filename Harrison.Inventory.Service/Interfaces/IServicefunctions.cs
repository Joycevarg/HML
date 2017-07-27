using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace Harrison.Inventory.Service
{
    public interface IServicefunctions
    {
        string GenerateID(string stringpart, int number, int noofdigits);
        string GenerateID(string stringpart, int number);
        int GetIDint(string id);
        int GetIDint(string id, int noofdigits);
        void ExportToExcel( DataTable tbl,int hearderformat,string excelFilePath = null);
        int VendorReportHeader(Excel._Worksheet worksheet, string tinno);
    }
}
