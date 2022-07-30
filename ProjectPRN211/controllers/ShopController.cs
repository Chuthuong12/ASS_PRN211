using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectPRN211.Models;

namespace ProjectPRN211.controllers
{

    public class ShopController : Controller
    {

        QLLdienthoaiContext context = new QLLdienthoaiContext();

        public IActionResult ShopView()
        {

            ViewBag.SanPham = context.Sanphams.ToList();
            ViewBag.HeDieuHanh = context.Hedieuhanhs.ToList();
            ViewBag.HangSanXuat = context.Hangsanxuats.ToList();
            return View();
        }

        [HttpPost]

        public IActionResult ShopView(int id)
        {


            var sanpham = (from b in context.Sanphams
                           where b.Masp == id
                           select b

                           ).ToList();
            return View(sanpham);
        }

        public IActionResult Shopsp(int id)
        {

            var hangsp = (from b in context.Sanphams
                          join r in context.Hangsanxuats on b.Mahang equals r.Mahang
                          where b.Mahang == id
                          select b

                           ).ToList();
            ViewBag.SanPham = hangsp;
            return RedirectToAction("ShopView");
        }

        public IActionResult Sort()
        {
          
               
            ViewBag.SanPham = context.Sanphams.OrderByDescending(b => b.Giatien).ToList();

            return View("ShopView");
        }
        public IActionResult Sort2()
        {

            ViewBag.SanPham = context.Sanphams.OrderBy(b => b.Giatien).ToList();

            return View("ShopView");
        }
        public IActionResult Sort3()
        {

            ViewBag.SanPham = context.Sanphams.OrderBy(b => b.Tensp).ToList();

            return View("ShopView");
        }
        public IActionResult Sort4()
        {

            ViewBag.SanPham = context.Sanphams.OrderByDescending(b => b.Tensp).ToList();

            return View("ShopView");
        }

    }
}
