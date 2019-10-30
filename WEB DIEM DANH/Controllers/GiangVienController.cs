using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_DIEM_DANH.Models;

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
        }

        public ActionResult LopMonHoc(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();

            }
            var list = from s in db.LOPMONHOCs where s.IDMONHOC == id select s;
            return View(list);
        }

        public ActionResult Test(int id=2) /////////////////////////////////
        {
            if (id == null)
            {
                return HttpNotFound();

            }
            var list = from s in db.LOPMONHOCs where s.IDMONHOC == id select s;
            return View(list);
        }
    }
}