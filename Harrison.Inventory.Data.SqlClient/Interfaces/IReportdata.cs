﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Harrison.Inventory.Data.SqlClient
{
    public interface IReportdata
    {
        DataTable GetReportData(int venid, string fromdate, string todate);
       
    }
}
