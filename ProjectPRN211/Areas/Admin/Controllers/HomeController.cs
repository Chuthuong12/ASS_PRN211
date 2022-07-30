using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project_Testing.Models;
using System.Linq;

namespace Project_Testing.Controllers
{
    public class HomeController : Controller
    {
        QLdienthoaiContext db = new QLdienthoaiContext();
        public IActionResult Index()
        {
            ViewBag.Sanpham = db.Sanphams.ToList();
            return View(db.Sanphams.ToList());
        }

        public ActionResult Details(int id)
        {
            var dt = db.Sanphams.Find(id);
            return View(dt);
        }

        public ActionResult Create()
        {
            //Để tạo dropdownList bên view
            var hangselected = new SelectList(db.Hangsanxuats, "Mahang", "Tenhang");
            ViewBag.Mahang = hangselected;
            var hdhselected = new SelectList(db.Hedieuhanhs, "Mahdh", "Tenhdh");
            ViewBag.Mahdh = hdhselected;
            return View();
        }

        // Tạo sản phẩm mới phương thức POST: Admin/Home/Create
        [HttpPost]
        public ActionResult Create(Sanpham sanpham)
        {
            try
            {
                //Thêm  sản phẩm mới
                db.Sanphams.Add(sanpham);
                // Lưu lại
                db.SaveChanges();
                // Thành công chuyển đến trang index
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // Sửa sản phẩm GET lấy ra ID sản phẩm: Admin/Home/Edit/5
        public ActionResult Edit(int id)
        {
            // Hiển thị dropdownlist
            var dt = db.Sanphams.Find(id);
            var hangselected = new SelectList(db.Hangsanxuats, "Mahang", "Tenhang", dt.Mahang);
            ViewBag.Mahang = hangselected;
            var hdhselected = new SelectList(db.Hedieuhanhs, "Mahdh", "Tenhdh", dt.Mahdh);
            ViewBag.Mahdh = hdhselected;
            // 
            return View(dt);

        }

        // POST: Admin/Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Sanpham sanpham)
        {
            try
            {
                // Sửa sản phẩm theo mã sản phẩm
                var oldItem = db.Sanphams.Find(sanpham.Masp);
                oldItem.Tensp = sanpham.Tensp;
                oldItem.Giatien = sanpham.Giatien;
                oldItem.Soluong = sanpham.Soluong;
                oldItem.Mota = sanpham.Mota;
                oldItem.Anhbia = sanpham.Anhbia;
                oldItem.Bonhotrong = sanpham.Bonhotrong;
                oldItem.Ram = sanpham.Ram;
                oldItem.Thesim = sanpham.Thesim;
                oldItem.Mahang = sanpham.Mahang;
                oldItem.Mahdh = sanpham.Mahdh;
                // lưu lại
                db.SaveChanges();
                // xong chuyển qua index
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // Xoá sản phẩm phương thức GET: Admin/Home/Delete/5
        public ActionResult Delete(int id)
        {
            var dt = db.Sanphams.Find(id);
            return View(dt);
        }

        // Xoá sản phẩm phương thức POST: Admin/Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                //Lấy được thông tin sản phẩm theo ID(mã sản phẩm)
                var dt = db.Sanphams.Find(id);
                // Xoá
                db.Sanphams.Remove(dt);
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
