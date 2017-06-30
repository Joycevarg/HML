using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
namespace Harrison.Inventory.WinForm
{
    public partial class testreportform : Form
    {
        public testreportform()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            DataTable dt;
            string query = "SELECT * FROM testpurchaseform WHERE Tin=@value1";

            using(SqlConnection sqlConn = new SqlConnection("Initial Catalog=HML_PURCHASE;Data Source=(local);Integrated Security=SSPI;"))
            using(SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                cmd.Connection = sqlConn;
                cmd.CommandText = query;
                sqlConn.Open();
                dt = new DataTable();
                cmd.Parameters.Add("@value1", SqlDbType.VarChar).Value = txtbox.Text;
                dt.Load(cmd.ExecuteReader());

            }
            dt.ExportToExcel("C:\\Users\\Joyce Varghese\\Documents\\new.xlsx",txtbox.Text);
        }
    }

}
public static class My_DataTable_Extensions
{
    
    // Export DataTable into an excel file with field names in the header line
    // - Save excel file without ever making it visible if filepath is given
    // - Don't save excel file, just make it visible if no filepath is given
    public static void ExportToExcel(this DataTable tbl, string excelFilePath = null,string tin = null)
    {
        try
        {
            if (tbl == null || tbl.Columns.Count == 0)
                throw new Exception("ExportToExcel: Null or empty input table!\n");

            // load excel, and create a new workbook
            var excelApp = new Excel.Application();
            excelApp.Workbooks.Add();

            // single worksheet
            Excel._Worksheet workSheet = excelApp.ActiveSheet;
            int sheetstart = Header(workSheet,tin);          //to denote where data display starts

            // column headings
            for (var i = 0; i < tbl.Columns.Count; i++)
            {
                workSheet.Cells[sheetstart, i + 1] = tbl.Columns[i].ColumnName;
            }

            // rows
            for (var i = 0; i <(tbl.Rows.Count); i++)
            {
                // to do: format datetime values before printing
                for (var j = 0; j < tbl.Columns.Count; j++)
                {
                    workSheet.Cells[i + sheetstart+1, j + 1] = tbl.Rows[i][j];
                }
            }

            // check file path
            if (!string.IsNullOrEmpty(excelFilePath))
            {
                try
                {
                    excelApp.Visible = true;
                    workSheet.SaveAs(excelFilePath);
                    excelApp.Quit();
                    MessageBox.Show("Excel file saved!");
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
    public static int Header(Excel._Worksheet wrksht,string tinno)
    {
      
      int ss = 10;
      wrksht.Cells[1][1] = "TIN No:" + tinno;
      wrksht.Cells[1][2] = "Rubberboard gibberish";
      wrksht.Shapes.AddPicture("C:\\Users\\Joyce Varghese\\Pictures\\hmllogo.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 350, 50, 100,100);
      return ss;
    
    
    }

}
