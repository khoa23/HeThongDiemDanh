//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEB_DIEM_DANH.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            this.DANHSACHLOPs = new HashSet<DANHSACHLOP>();
        }
    
        public int IDSINHVIEN { get; set; }
        public string MASOSINHVIEN { get; set; }
        public string TENSINHVIEN { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string EMAIL { get; set; }
        public string SODIENTHOAI { get; set; }
        public string DIACHI { get; set; }
        public int IDLOPSINHVIEN { get; set; }
        public int IDPHANQUYEN { get; set; }
        public int IDDANGNHAP { get; set; }
    
        public virtual CHITIETDANGNHAP CHITIETDANGNHAP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHLOP> DANHSACHLOPs { get; set; }
        public virtual LOPSINHVIEN LOPSINHVIEN { get; set; }
    }
}
