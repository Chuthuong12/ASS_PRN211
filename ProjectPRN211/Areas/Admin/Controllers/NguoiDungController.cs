using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project_Testing.Models;
using System.Linq;

namespace Project_Testing.Controllers
{
    public class NguoiDungController : Controller
    {
        QLdienthoaiContext db = new QLdienthoaiContext();
        public IActionResult Index()
        {
            return View(db.Nguoidungs.ToList());
        }

        public ActionResult Details(int id)
        {
            var dt = db.Nguoidungs.Find(id);
            return View(dt);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Nguoidung nguoidung)
        {
            try
            {
                db.Nguoidungs.Add(nguoidung);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var dt = db.Nguoidungs.Find(id);
            var quyenselected = new SelectList(db.Nguoidungs, "Idquyen", "TenQuyen", dt.Idquyen);
            ViewBag.IDQuyen = quyenselected;
            return View(dt);

        }

        [HttpPost]
        public ActionResult Edit(Nguoidung nguoidung)
        {
            try
            {
                var oldItem = db.Nguoidungs.Find(nguoidung.MaNguoiDung);
                oldItem.Hoten = nguoidung.Hoten;
                oldItem.Email = nguoidung.Email;
                oldItem.Dienthoai = nguoidung.Dienthoai;
                oldItem.Matkhau = nguoidung.Matkhau;
                oldItem.Idquyen = nguoidung.Idquyen;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            var dt = db.Nguoidungs.Find(id);
            return View(dt);
        }

        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                //Lấy được thông tin sản phẩm theo ID(mã sản phẩm)
                var dt = db.Nguoidungs.Find(id);
                // Xoá
                db.Nguoidungs.Remove(dt);
                // Lưu lại
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
