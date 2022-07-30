using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Testing.Models;
using System.Linq;

namespace Project_Testing.Controllers
{
    public class HangSanXuatController : Controller
    {
        QLdienthoaiContext db = new QLdienthoaiContext();
        public IActionResult Index()
        {
            return View(db.Hangsanxuats.ToList());
        }

        public ActionResult Details(int id)
        {
            var dt = db.Hangsanxuats.Find(id);
            return View(dt);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Hangsanxuat hangsanxuat)
        {
            try
            {
                db.Hangsanxuats.Add(hangsanxuat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(int id)
        {
            var dt = db.Hangsanxuats.Find(id);
            return View(dt);

        }

        [HttpPost]
        public ActionResult Edit(Hangsanxuat hangsanxuat)
        {
            try
            {
                var oldItem = db.Hangsanxuats.Find(hangsanxuat.Mahang);
                oldItem.Tenhang = hangsanxuat.Tenhang;
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
            var dt = db.Hangsanxuats.Find(id);
            return View(dt);
        }

        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                //Lấy được thông tin sản phẩm theo ID(mã sản phẩm)
                var dt = db.Hangsanxuats.Find(id);
                // Xoá
                db.Hangsanxuats.Remove(dt);
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
