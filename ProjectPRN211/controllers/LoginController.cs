using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectPRN211.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPRN211.controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        QLLdienthoaiContext context = new QLLdienthoaiContext();
        [HttpPost]
        public IActionResult Login(string user, string pass)
        {
            ViewBag.User = user;
            ViewBag.Pass = pass;
            List<Nguoidung> lu = context.Nguoidungs.ToList();
            Nguoidung u = lu.Where(item => item.Email == user && item.Matkhau == pass).FirstOrDefault();
            if (u == null)
            {
                ViewBag.User = "Dat sai roi";
                return View();
            }
            else
            {
                //HttpContext.Session.SetInt32("User", u.MaNguoiDung);
                return RedirectToAction("Index", "Home", new { user = u });
            }
        }
    }
}
