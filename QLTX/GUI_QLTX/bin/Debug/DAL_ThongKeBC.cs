using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_QLTX
{
    public class DAL_ThongKeBC: DBConnect
    {
        
        public DataSet GetThongKeDoanhThuByMonth(int month, int year)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetThongKeDoanhThuByMonth";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            cmd.Parameters.Add(new SqlParameter("@Thang", month));
            cmd.Parameters.Add(new SqlParameter("@Nam", year));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            _conn.Close();
            return ds;
        }
    }
}
