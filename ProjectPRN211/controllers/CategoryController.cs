using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectPRN211.Models;


namespace ProjectPRN211.controllers
{
    [Route("Category")]
    public class CategoryController : Controller
    {
        [Route("index")]
        [Route("")]

        public IActionResult CatrgoryView()
        {
            return View();
        }
    }
}
