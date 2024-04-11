using DAL_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLTX
{
    public class BUS_Xe
    {
        DAL_Xe dalXe = new DAL_Xe();
        public DataTable layXe()
        {
            return dalXe.layXe();
        }
        public DataTable layXe(string bienso)
        {
            return dalXe.layXe(bienso);
        }

        public DataTable layXe(string bienso, string loaixe)
        {
            return dalXe.layXe(bienso, loaixe);
        }
    }
}
