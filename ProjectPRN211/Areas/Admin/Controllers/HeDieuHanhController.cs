using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Testing.Models;
using System.Linq;

namespace Project_Testing.Controllers
{
    public class HeDieuHanhController : Controller
    {
        QLdienthoaiContext db = new QLdienthoaiContext();
        public IActionResult Index()
        {
            return View(db.Hedieuhanhs.ToList());
        }

        public ActionResult Details(int id)
        {
            var dt = db.Hedieuhanhs.Find(id);
            return View(dt);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Hedieuhanh hedieuhanh)
        {
            try
            {
                db.Hedieuhanhs.Add(hedieuhanh);
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
            var dt = db.Hedieuhanhs.Find(id);
            return View(dt);

        }

        [HttpPost]
        public ActionResult Edit(Hedieuhanh hedieuhanh)
        {
            try
            {
                var oldItem = db.Hedieuhanhs.Find(hedieuhanh.Mahdh);
                oldItem.Tenhdh = hedieuhanh.Tenhdh;
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
            var dt = db.Hedieuhanhs.Find(id);
            return View(dt);
        }

        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                //Lấy được thông tin sản phẩm theo ID(mã sản phẩm)
                var dt = db.Hedieuhanhs.Find(id);
                // Xoá
                db.Hedieuhanhs.Remove(dt);
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
