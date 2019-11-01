﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel;

    public partial class LOPMONHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOPMONHOC()
        {
            this.DANHSACHLOPs = new HashSet<DANHSACHLOP>();
        }
    
        public int IDLOPMH { get; set; }
        [DisplayName("Mã lớp")]
        public string MALOPMH { get; set; }
        [DisplayName("Tên lớp")]
        public string TENLOPMH { get; set; }
        [DisplayName("Nhóm")]
        public string NHOMMONHOC { get; set; }
        public bool TOTHUCHANH { get; set; }
        [DisplayName("Thứ")]
        public string THU { get; set; }
        [DisplayName("Số tiết")]
        public Nullable<int> SOTIET { get; set; }
        [DisplayName("Tiết bắt đầu")]
        public Nullable<int> TIETBATDAU { get; set; }
        [DisplayName("Ngày bắt đầu")]
        public System.DateTime NGAYBATDAU { get; set; }
        [DisplayName("Ngày kết thúc")]
        public System.DateTime NGAYKETTHUC { get; set; }
        [DisplayName("Phòng")]
        public string PHONGHOC { get; set; }
        [DisplayName("ID Giảng viên")]
        public int IDGIANGVIEN { get; set; }
        [DisplayName("ID Môn học")]
        public int IDMONHOC { get; set; }
        [DisplayName("ID Học kỳ")]
        public int IDHOCKY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHLOP> DANHSACHLOPs { get; set; }
        public virtual GIANGVIEN GIANGVIEN { get; set; }
        public virtual HOCKY HOCKY { get; set; }
        public virtual MONHOC MONHOC { get; set; }
    }
}
