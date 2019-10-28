using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_DIEM_DANH.Models;

namespace WEB_DIEM_DANH.Controllers
{
    public class NguoiDungController : Controller
    {
        dbDiemDanhDataContext db = new dbDiemDanhDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dangnhap()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Dangnhap(FormCollection collection)
        {
            var Taikhoan = collection["Taikhoan"];
            var Matkhau = collection["Matkhau"];
            if (String.IsNullOrEmpty(Taikhoan))
            {
                ViewData["Loi2"] = "Vui lòng nhập tên đăng nhập";
            }
            if (String.IsNullOrEmpty(Matkhau))
            {
                ViewData["Loi3"] = "Vui lòng nhập Mật Khẩu";
            }
            else
            {
                DANGNHAP dangnhap = db.DANGNHAPs.SingleOrDefault(n => n.TENDANGNHAP == Taikhoan && n.MATKHAU == Matkhau);
                if (dangnhap != null)
                {
                    ViewBag.Thongbao = "Đăng Nhập Thành Công";
                    Session["Taikhoan"] = dangnhap;
                    if (dangnhap.IDPHANQUYEN == 1) return RedirectToAction("IndexAdmin", "Admin");
                    if (dangnhap.IDPHANQUYEN == 2) return RedirectToAction("IndexGV", "GiangVien");
                    if (dangnhap.IDPHANQUYEN == 3) return RedirectToAction("IndexSV", "SinhVien");
                }
                else
                    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }

            return View();
        }
    }
}