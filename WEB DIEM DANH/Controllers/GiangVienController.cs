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
            string selectSQL = "select s.* from LOPMONHOC l, SINHVIEN s, DANHSACHLOP d where  id = d.IDLOPMH and s.IDSINHVIEN = d.IDSINHVIEN";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ListItem newItem = new ListItem();
                    newItem.Text = reader["MaSoSinhVien"].ToString();
                    newItem.Text = reader["TenSinhVien"].ToString();
                    
                }
                reader.Close();
            }
            finally
            {
                con.Close();
            }
            return View();
        }

    }
}