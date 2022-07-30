using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectPRN211.Models;
namespace ProjectPRN211.controllers
{
    public class CartController : Controller
    {
        QLLdienthoaiContext context = new QLLdienthoaiContext();

        public IActionResult CartView()
        {
            int uid = (int)HttpContext.Session.GetInt32("User");
            List<Donhang> ld = context.Donhangs.Where(item => item.MaNguoidung == uid).ToList();
            context.Chitietdonhangs.ToList();
            context.Donhangs.ToList();
            context.Sanphams.ToList();


            List<Chitietdonhang> lctdh = new List<Chitietdonhang>();

            foreach (var item in ld)
            {
                lctdh.AddRange(context.Chitietdonhangs.Where(c => c.Madon == item.Madon));
            }
            ViewBag.mess = lctdh.Count;
            return View(lctdh);
           
        }
    }
}
