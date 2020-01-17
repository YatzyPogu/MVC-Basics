using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class GuessNumberController : Controller
    {



        [HttpGet]
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("HiddenNr", NumberWizard.Magic());
            return View();
        }

        [HttpPost]
        public IActionResult Index(int num)
        {
            

                if (num == 0 || num > 100 || num < 1)
                {
                    ViewBag.Message = "Try again!";
                }
                else
                {
                    int? theNumber = HttpContext.Session.GetInt32("HiddenNr");

                    if (theNumber == null)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Message = NumberWizard.Guessing((int)theNumber, num);
                    }

                }
            
            
           

            return View();
        }
    }
}