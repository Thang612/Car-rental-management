//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO_QLTX
{
    using System;
    using System.Collections.Generic;
    
    public partial class HopDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HopDong()
        {
            this.ChiTietHopDongs = new HashSet<ChiTietHopDong>();
            this.HoaDons = new HashSet<HoaDon>();
        }
    
        public int MaHopDong { get; set; }
        public Nullable<System.DateTime> NgayLaphopDong { get; set; }
        public Nullable<double> TongTien { get; set; }
        public Nullable<double> TienDatCoc { get; set; }
        public string CacDieuKhoan { get; set; }
        public Nullable<int> MaNguoiDung { get; set; }
        public Nullable<int> MaKhachHang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHopDong> ChiTietHopDongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
    }
}