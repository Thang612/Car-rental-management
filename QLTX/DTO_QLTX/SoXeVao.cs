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
    
    public partial class SoXeVao
    {
        public int MaXeVao { get; set; }
        public Nullable<System.DateTime> NgayVao { get; set; }
        public string ChuThich { get; set; }
        public Nullable<int> MaXe { get; set; }
    
        public virtual Xe Xe { get; set; }
    }
}