using Microsoft.AspNetCore.Mvc;
using System;

namespace Dojo_Survey.Controllers
{

    public class HomeController : Controller
    {
        //localhost:5000
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        // //localhost:5000/result
        [HttpPost("result")]
        public ViewResult Result(string name, string location, string language, string comment)
        {

            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;

            return View();
        }

    }
}