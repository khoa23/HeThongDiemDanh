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
    
    public partial class DANGNHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANGNHAP()
        {
            this.CHITIETDANGNHAPs = new HashSet<CHITIETDANGNHAP>();
        }
    
        public int IDDANGNHAP { get; set; }
        public Nullable<int> IDPHANQUYEN { get; set; }
        public string TENDANGNHAP { get; set; }
        public string MATKHAU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDANGNHAP> CHITIETDANGNHAPs { get; set; }
    }
}
