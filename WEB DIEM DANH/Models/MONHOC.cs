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
    
    public partial class MONHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONHOC()
        {
            this.LOPMONHOCs = new HashSet<LOPMONHOC>();
        }
    
        public int IDMONHOC { get; set; }
        public string MAMONHOC { get; set; }
        public string TENMONHOC { get; set; }
        public Nullable<int> SOBUOI { get; set; }
        public Nullable<double> SOTINCHI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOPMONHOC> LOPMONHOCs { get; set; }
    }
}
