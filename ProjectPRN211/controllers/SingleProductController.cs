using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectPRN211.Models;

namespace ProjectPRN211.controllers
{
    [Route("SingleProduct")]
    public class SingleProductController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult SingleProductView(int id)
        {
            QLLdienthoaiContext context = new QLLdienthoaiContext();
            var sanpham = (from b in context.Sanphams
                           where b.Masp == id
                           select b

                            ).ToList();
            ViewBag.SanPhamm = sanpham;
            return View();
        }
 

    }
}
