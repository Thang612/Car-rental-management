namespace DTO_QLTX
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHopDong")]
    public partial class ChiTietHopDong
    {
        [Key]
        public int Ma { get; set; }

        public int? SoLuong { get; set; }

        public double? GiamGia { get; set; }

        public DateTime? NgayKhoiHanh { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        public int? MaXe { get; set; }

        public int? MaHopDong { get; set; }

        public virtual HopDong HopDong { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
