using Microsoft.AspNetCore.Mvc;
using ProjectPRN211.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPRN211.controllers
{
    public class SignUpController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        QLLdienthoaiContext context = new QLLdienthoaiContext();

        [HttpPost]
        public IActionResult SignUp(string user, string pass, string repass)
        {
            context.Nguoidungs.ToList();
            List<Nguoidung> lnd = context.Nguoidungs.ToList();
            Nguoidung u = lnd.Where(item => item.Email.Equals(user) && item.Matkhau.Equals(pass)).FirstOrDefault();

            if (!pass.Equals(repass) || u != null)
            {
                ViewBag.mess = "Dữ liệu không hợp lệ";
                ViewBag.test = !pass.Equals(repass);
                ViewBag.test1 = u != null;
            }
            else
            {
                Nguoidung nd = new Nguoidung()
                {
                    Email = user,
                    Matkhau = pass,
                };
                context.Nguoidungs.Add(nd);
                context.SaveChanges();
                ViewBag.mess = "Đăng ký thành công!";
            }
            return View();
        }
    }
}
