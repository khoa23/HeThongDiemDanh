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
    
    public partial class LOPSINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOPSINHVIEN()
        {
            this.NGUOIDUNGs = new HashSet<NGUOIDUNG>();
        }
    
        public int IDLOPSINHVIEN { get; set; }
        public string MALOPSV { get; set; }
        public string TENLOPSV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOIDUNG> NGUOIDUNGs { get; set; }
    }
}
