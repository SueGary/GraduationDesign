using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PEIS_SPZZ
{
    class DBConnection
    {
        public static string sql = @"Data Source=PENGHAORAN-PC\MYDATABASE;Initial Catalog=tj_db;Integrated Security=True";
        public static SqlConnection DtPh = new SqlConnection(sql);
    }
}
