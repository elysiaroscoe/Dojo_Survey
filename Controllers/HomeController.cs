using Microsoft.AspNetCore.Mvc;
using System;
using Dojo_Survey.Models;

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
        public IActionResult Result(Survey yourSurvey)
        {
            return View(yourSurvey);
        }

    }
}