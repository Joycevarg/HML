using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.OleDb;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Service
{
    public class ServiceFunctions : IServicefunctions
    {
        public string GenerateID(string stringpart, int number, int noofdigits)
        {
            string id = "", numberpart = "";
            numberpart = number.ToString();
            while (numberpart.Length < noofdigits)
            {
                numberpart = "0" + numberpart;
            }
            id = stringpart + numberpart;
            return id;
        }
        public string GenerateID(string stringpart, int number)
        {
            return stringpart + number.ToString();

        }
        public int GetIDint(string id)
        {
            int i;
            for (i = id.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(id[i]))
                    break;
            }
            return int.Parse(id.Substring(i + 1));
        }

        public int GetIDint(string id, int noofdigits)
        {
            return int.Parse(id.Substring(id.Length - noofdigits));
        }

        public void ExportToExcel(DataTable tbl,int headerformat,int venid,string excelFilePath = null)
        {
            int start=0;
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Excel.Application();
                excelApp.Workbooks.Add();
                
                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;
                if (headerformat == 1)
                { start = VendorReportHeader(workSheet,venid); }
                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[start, i + 1] = tbl.Columns[i].ColumnName;
                }

                // rows
                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2+start, j + 1] = tbl.Rows[i][j];
                    }
                }

                // check file path
                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
        public int VendorReportHeader(Excel._Worksheet worksheet,int vendorid)
        {
            IVendorServices _vendorservice = new VendorService(new VendorData());
            worksheet.Cells[1, 1] = "TIN:"+_vendorservice.GetTIN(vendorid);
            worksheet.Cells[2, 1] = "Rubber Board License No:";
            worksheet.Cells[5, 1] = "HARRISONS MALAYALAM LIMITED";
            worksheet.Cells[6, 1] = "Mooply Estate-Centrifuge Latex Factory";
            worksheet.Cells[7, 1] = "Palappilly P.O,Thrissur";
            worksheet.Cells[8, 1] = "Bought Latex Statement";
            worksheet.Shapes.AddPicture("C:\\Users\\Joyce Varghese\\Documents\\hml'\\HML\\hmllogo.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 160, 12, 45, 45); 
            for(int i=1;i<9;i++)
            worksheet.Cells[i, 1].Font.Bold = true;
            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[100, 100]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            worksheet.Cells[10, 1] = "Name of Vendor:";
            worksheet.Cells[10, 2] = _vendorservice.GetVendorName(vendorid);
            for(int i=5;i<10;i++)
            worksheet.Range[worksheet.Cells[i, 1], worksheet.Cells[i, 8]].Merge();
            return 12;
        }
    }
}
    

