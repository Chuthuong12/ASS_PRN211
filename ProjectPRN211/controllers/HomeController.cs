using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectPRN211.Models;
namespace ProjectPRN211.controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index(Nguoidung user)
        {
            return View();
        }
    }
}
