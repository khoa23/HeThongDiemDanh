using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WEB_DIEM_DANH
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Lop mon hoc",
                "GiangVien/DiemDanh/LopMonHoc-{id}",
                new { controller = "GiangVien", action = "LopMonHoc" }, new { id = @"\d+" }
            );

            routes.MapRoute(
                "Danh sach sv trong lop",
                "GiangVien/DiemDanh/LopMonHoc/DanhSachLop/{id}",
                new { controller = "GiangVien", action = "DanhSachLop" }, new { id = @"\d+" }
            );

            routes.MapRoute(
                "QR",
                "GiangVien/DiemDanh/LopMonHoc/QR/{id}",
                new { controller = "GiangVien", action = "QR" }, new { id = @"\d+" }
            );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
