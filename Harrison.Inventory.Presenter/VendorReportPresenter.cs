using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harrison.Inventory.Service;
using Harrison.Inventory.Data.Model;
using Harrison.Inventory.Data.SqlClient;

namespace Harrison.Inventory.Presenter
{
    public class VendorReportPresenter:IVendorReportPresenter
    {
        IVendorServices _ivendorservices { get; set; }
        IVendorReportService _ivendorreportservice { get; set; }
        IVendorReportView _ivendorreportview { get; set; }

        public VendorReportPresenter(IVendorReportView vendorreportview)
        {
            _ivendorreportview = vendorreportview;
            _ivendorservices = new VendorService(new VendorData());
            _ivendorreportservice = new VendorReportService();
        }

        public void SetVendorNames()
        {
            _ivendorreportview.SetVendorValues(_ivendorservices.ArrangeVendor(SortType.Ascending, SortFieldType.Id));  
       
        }
        public void GenerateReport(object venid, DateTime fromdate, DateTime todate)
        {
             _ivendorreportservice.DataTableToExcel(int.Parse(venid.ToString()), fromdate.ToString("yyyy-MM-dd"), todate.ToString("yyyy-MM-dd"));
        }
        public void GenerateReport(object venid)
        {
            _ivendorreportservice.DataTableToExcel(int.Parse(venid.ToString()));
        }
        
    }
}
