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
    
    public partial class QUANTRIVIEN
    {
        public int IDQTV { get; set; }
        public string MAQTV { get; set; }
        public string TENQTV { get; set; }
        public bool TRANGTHAI { get; set; }
        public bool PHANQUYENQTV { get; set; }
        public int IDPHANQUYEN { get; set; }
        public int IDDANGNHAP { get; set; }
    
        public virtual CHITIETDANGNHAP CHITIETDANGNHAP { get; set; }
    }
}