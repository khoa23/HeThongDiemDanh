﻿using QRCoder;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB_DIEM_DANH.Models;

namespace WEB_DIEM_DANH.Controllers
{
    public class GiangVienController : Controller
    {       
        DatabaseDDSVEntities db = new DatabaseDDSVEntities();
        //[Authorize(Roles = "GIANGVIEN")]
        // GET: Giangvien
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NamHoc()
        {
            var list = from s in db.NAMHOCs select s;
            return View(list);

            //List<NAMHOC> namhoc = db.NAMHOCs.ToList();
            //List<HOCKY> hocky = db.HOCKies.ToList();
            //int id = Convert.ToInt32(Session["IDNGUOIDUNG"]);


            //var list = from n in db.NAMHOCs
            //           join dd in db.HOCKies on n.IDNAMHOC equals dd.IDNAMHOC into table1
            //           from dd in table1.ToList()
            //           join l in db.LOPMONHOCs on dd.IDHOCKY equals l.IDHOCKY into table2
            //           from l in table2.ToList()
            //           where id == l.IDGIANGVIEN
            //           select new NamHocHocKy
            //           { namhoc = n, hocky = dd };
            return View(list);
        }

        public ActionResult HocKy(int? id)
        {
            var list = from h in db.HOCKies
                       where id == h.IDNAMHOC
                       select h;
            return View(list);
        }

        public ActionResult ThongTinGV()
        {
            int id = Convert.ToInt32(Session["IDNGUOIDUNG"]);
            var v = from t in db.NGUOIDUNGs
                    where t.IDNGUOIDUNG == id
                    select t;

            var user = db.NGUOIDUNGs.FirstOrDefault(c => c.IDNGUOIDUNG == id);
            if (user != null)
            {
                return View(user);
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult MonHoc(int? id)
        {
            int idgv = Convert.ToInt32(Session["IDNGUOIDUNG"]);
            var list = from m in db.MONHOCs
                       join l in db.LOPMONHOCs
                       on m.IDMONHOC equals l.IDMONHOC
                       where idgv == l.IDGIANGVIEN
                       orderby id == l.IDHOCKY
                       select m;
            return View(list);

        }

        public ActionResult LopMonHoc(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();

            }
            var list = from s in db.LOPMONHOCs
                       where s.IDMONHOC == id
                       select s;
            return View(list);
        }

        public ActionResult DanhSachLop(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();

            }
            var list = from a in db.NGUOIDUNGs
                       join d in db.DANHSACHLOPs
                       on a.IDNGUOIDUNG equals d.IDNGUOIDUNG
                       where id == d.IDLOPMH
                       select a;
            return View(list);
        }

        //[Authorize(Roles = "GIANGVIEN")]
        public ActionResult QR(int? id)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                //id user
                int iduser = Convert.ToInt32(Session["IDNGUOIDUNG"]);
                //string idgiangvien = Convert.ToString(Session["IDNGUOIDUNG"]);



                //ramdon
                int Numrd;
                string Numrd_str;
                Random rd = new Random();
                Numrd = rd.Next(10000000, 1000000000);//biến Numrd sẽ nhận có giá trị ngẫu nhiên
                Numrd_str = rd.Next(10000000, 1000000000).ToString();//Chuyển giá trị ramdon về kiểu string

                //ngay thang
                DateTime dt = DateTime.Now;
                string strDate = dt.ToString("dd/MM/yy,hh:mm");

                //lay idlopmonhoc
                string idlopmonhoc = Convert.ToString(id); //chuyển id ở trên qua string

                //ma lop mon hoc
                var malop = from t in db.LOPMONHOCs
                            where t.IDLOPMH == id
                            select new
                            {
                                t.MALOPMH
                            };

                string chuoimalop = Convert.ToString(malop);

                //bo gv, lay ma lops
                //string dayqr = idmonhoc+'-'+Numrd_str+'-'+strDate;
                string dayqr = idlopmonhoc + '-' + Numrd_str + '-' + strDate;

                //linq              
                LICHHOC lichhoc = new LICHHOC();
                lichhoc.THOIGIANDIEMDANH = DateTime.Now;
                lichhoc.MAQR = dayqr;
                lichhoc.IDLOPMH = id.Value;
                lichhoc.IDNGUOIDUNG = iduser;
                db.LICHHOCs.Add(lichhoc);
                db.SaveChangesAsync();



                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(dayqr, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                using (Bitmap bitMap = qrCode.GetGraphic(20))
                {
                    bitMap.Save(ms, ImageFormat.Png);
                    ViewBag.QRCodeImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }
            }

            return View();
        }

        public ActionResult DanhSachDiemDanh(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();

            }
            List<NGUOIDUNG> nguoidung = db.NGUOIDUNGs.ToList();
            List<DIEMDANHSV> diemdanhsv = db.DIEMDANHSVs.ToList();


            var list = from n in db.NGUOIDUNGs
                       join dd in db.DIEMDANHSVs on n.IDNGUOIDUNG equals dd.IDNGUOIDUNG into table1
                       from dd in table1.ToList()
                       where id == dd.IDLOPMH
                       select new DanhSachDiemDanh
                       { nguoidung = n, diemdanhsv = dd };
            //
            
            //



            return View(list);
        }
        

    }
}