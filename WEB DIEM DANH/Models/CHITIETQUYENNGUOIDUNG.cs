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
    
    public partial class CHITIETQUYENNGUOIDUNG
    {
        public int IDNGUOIDUNG { get; set; }
        public int IDQUYENNGUOIDUNG { get; set; }
        public Nullable<bool> TRANGTHAI { get; set; }
    
        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
        public virtual QUYENNGUOIDUNG QUYENNGUOIDUNG { get; set; }
    }
}