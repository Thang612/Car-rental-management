using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLTX;
using DTO_QLTX;

namespace BUS_QLTX
{
    public class BUS_NguoiDung
    {
        DAL_NguoiDung dalNguoiDung = new DAL_NguoiDung();
        public NguoiDung layNguoiDung (string username, string password)
        {
            return dalNguoiDung.layNguoiDung(username, password);   
        }


    }
}
