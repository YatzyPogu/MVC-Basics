using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class HealthController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string temp)
        {

            if (string.IsNullOrWhiteSpace(temp))
            {
                ViewBag.Message = "Try again!";
            }
            else
            {
                int newTemp = 0;
                try
                {
                    newTemp = Convert.ToInt32(temp);
                }
                catch
                {
                    ViewBag.Message = "That's not a digit!";
                    return View();
                }

                ViewBag.Message = Doctor.FeverCheck(newTemp);
            }

            return View();
        }

    }
}