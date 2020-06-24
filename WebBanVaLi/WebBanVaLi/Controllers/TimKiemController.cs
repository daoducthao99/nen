using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanVaLi.Models;
using PagedList;
using PagedList.Mvc;

namespace WebBanVaLi.Controllers
{
    public class TimKiemController : Controller
    {
        // GET: TimKiem
        WebBanVaLiEntities db = new WebBanVaLiEntities();
        [HttpPost]
        public ActionResult KetQuaTimKiem(FormCollection f, int? page)
        {
            string searchKey = f["txtTimKiem"].ToString();
            ViewBag.keyword = searchKey;
            List<tDanhMucSP> lstKQTK = db.tDanhMucSPs.Where
                (n => n.TenSP.Contains(searchKey)).ToList();
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            if(lstKQTK.Count==0)
            {
                ViewBag.ThongBao = "Không có sản phẩm bạn tìm kiếm";
                return View(db.tDanhMucSPs.OrderBy(n => n.TenSP).ToList().ToPagedList(pageNumber,pageSize));
            }
            ViewBag.ThongBao = "Đã tìm thấy" + lstKQTK.Count + "sản phẩm";
            return View(lstKQTK.OrderBy(n=>n.TenSP).ToList().ToPagedList(pageNumber, pageSize));
        }

        [HttpGet]
        public ActionResult KetQuaTimKiem(int? page, string searchKey)
        {
            ViewBag.keyword = searchKey;
            List<tDanhMucSP> lstKQTK = db.tDanhMucSPs.Where
                (n => n.TenSP.Contains(searchKey)).ToList();
            int pageNumber = (page ?? 1);
            int pageSize = 8;
            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không có sản phẩm bạn tìm kiếm";
                return View(db.tDanhMucSPs.OrderBy(n => n.TenSP).ToList().ToPagedList(pageNumber, pageSize));
            }
            ViewBag.ThongBao = "Đã tìm thấy" + lstKQTK.Count + "sản phẩm";
            return View(lstKQTK.OrderBy(n => n.TenSP).ToList().ToPagedList(pageNumber, pageSize));
        }
    }
}