using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Testing.Models;
using System.Linq;

namespace Project_Testing.Controllers
{
    public class PhanQuyenController : Controller
    {
        QLdienthoaiContext db = new QLdienthoaiContext();
        public IActionResult Index()
        {
            return View(db.PhanQuyens.ToList());
        }

        public ActionResult Details(int id)
        {
            var dt = db.PhanQuyens.Find(id);
            return View(dt);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PhanQuyen phanquyen)
        {
            try
            {
                db.PhanQuyens.Add(phanquyen);
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
            var dt = db.PhanQuyens.Find(id);
            return View(dt);

        }

        [HttpPost]
        public ActionResult Edit(PhanQuyen phanquyen)
        {
            try
            {
                var oldItem = db.PhanQuyens.Find(phanquyen.Idquyen);
                oldItem.TenQuyen = phanquyen.TenQuyen;
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
            var dt = db.PhanQuyens.Find(id);
            return View(dt);
        }

        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                //Lấy được thông tin sản phẩm theo ID(mã sản phẩm)
                var dt = db.PhanQuyens.Find(id);
                // Xoá
                db.PhanQuyens.Remove(dt);
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
