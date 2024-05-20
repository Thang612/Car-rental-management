using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLTX
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("data source=DESKTOP-TM2B6F7\\MSSQLSERVER01;initial catalog=QLTX;Integrated Security = True");
    }
}
