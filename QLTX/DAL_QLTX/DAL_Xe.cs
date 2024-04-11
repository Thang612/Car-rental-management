using DTO_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLTX
{
    public class DAL_Xe:DBConnect
    {
        public DataTable layXe(string bienso, string loaixe)
        {
            string SQL = String.Format("SELECT BienSo, MoTa, TinhTrang, GiaThue, TenLoaiXe FROM Xe JOIN LoaiXe ON XE.MaLoaiXe = LoaiXe.MaLoaiXe Where LOWER(BienSo) like LOWER('%{0}%') AND TenLoaiXe like '{1}'", bienso, loaixe);
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtXe = new DataTable();
            da.Fill(dtXe);
            return dtXe;
        }

        public DataTable layXe(string bienso)
        {
            string SQL = String.Format("SELECT BienSo, MoTa, TinhTrang, GiaThue, TenLoaiXe FROM Xe JOIN LoaiXe ON XE.MaLoaiXe = LoaiXe.MaLoaiXe Where LOWER(BienSo) like LOWER('%{0}%')", bienso);
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtXe = new DataTable();
            da.Fill(dtXe);
            return dtXe;
        }
        public DataTable layXe()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT BienSo, MoTa, TinhTrang, GiaThue, TenLoaiXe FROM Xe JOIN LoaiXe ON XE.MaLoaiXe = LoaiXe.MaLoaiXe", _conn);
            DataTable dtXe = new DataTable();
            da.Fill(dtXe);
            return dtXe;
        }
    }
}
