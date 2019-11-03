using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_DIEM_DANH.Models;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using ZXing;
using ZXing.QrCode;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace WEB_DIEM_DANH.Controllers
{
    public class GiangVienController : Controller
    {
        DiemDanhEntities db = new DiemDanhEntities();
        // GET: GiangVien
        public ActionResult IndexGV()
        {
            return View();
        }

        public ActionResult DiemDanh()
        {
            var list = from s in db.MONHOCs select s;
            return View(list);
            string luuidDiemDanh = Request.AnonymousID.ToString();
        }

        public ActionResult LopMonHoc(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();

            }
            int? idlopmonhoc = id;
            var list = from s in db.LOPMONHOCs where s.IDMONHOC == id select s;
            return View(list);
        }
        private string connectionString = WebConfigurationManager.ConnectionStrings["DiemDanhConnectionString"].ConnectionString;

        public ActionResult DanhSachLop(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();

            }
            //var list = from s in db.DANHSACHLOPs where s.IDLOPMH == id select s;
            var list = from a in db.SINHVIENs
                       join d in db.DANHSACHLOPs
                       on a.IDSINHVIEN equals d.IDSINHVIEN

                       where id == d.IDLOPMH
                       select a;
                        
            //var list1 = from c in db.SINHVIENs where c.IDSINHVIEN ==  select c;
            return View(list);
        }

    }
}