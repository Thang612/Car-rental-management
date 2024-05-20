using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLTX;
namespace BUS_QLTX
{
    public class BUS_ThongKeBC
    {
        DAL_ThongKeBC daltkbc = new DAL_ThongKeBC();
        public DataSet GetThongKeDoanhThuByMonth(int thang, int nam)
        {
            return daltkbc.GetThongKeDoanhThuByMonth(thang,nam);
        }

    }
}
