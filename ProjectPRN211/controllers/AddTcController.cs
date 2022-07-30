using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectPRN211.Models;
using System;
using System.Linq;

namespace ProjectPRN211.controllers
{

    public class AddTcController : Controller
    {
        QLLdienthoaiContext context = new QLLdienthoaiContext();

        public IActionResult Index(int id)
        {
            Sanpham sp = context.Sanphams.Find(id);
            int user = (int)HttpContext.Session.GetInt32("User");
            DateTime d = DateTime.Now;
            Donhang dh = new Donhang()
            {
                Ngaydat = d,
                Tinhtrang = 1,
                MaNguoidung = user,
            };
            context.Donhangs.Add(dh);
            context.SaveChanges();
            int madon = context.Donhangs.OrderByDescending(d => d.Madon).FirstOrDefault().Madon;
            Chitietdonhang ctdh = new Chitietdonhang()
            {
                Madon = madon,
                Masp = id,
                Soluong = 1,
                Dongia = sp.Giatien,
                Thanhtien = sp.Giatien
            };
            context.Chitietdonhangs.Add(ctdh);
            context.SaveChanges();
            return RedirectToAction("Index", "Cart");
        }
    }
}
