using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class PeopleController : Controller
    {
        [HttpGet]
        public IActionResult Index() 
        {
            List<PeopleModel> peopleList = new List<PeopleModel>
            {
               new PeopleModel {Name="Kalle", PhoneNumber="123987", City="Ankeborg" },
               new PeopleModel {Name="Kajsa", PhoneNumber="123555", City="Gåseborg" },
               new PeopleModel {Name="Uno", PhoneNumber="123567", City="Sunne" },
               new PeopleModel {Name="Berit", PhoneNumber="123134", City="Vadköping" },
               new PeopleModel {Name="Bennie", PhoneNumber="123653", City="Öland" }
            };
            return View(peopleList); 
        }

        [HttpPost]
        public IActionResult Index(PeopleModel peopleModel)
        {
            if(ModelState.IsValid) 
            {
                
            }
            return View();
        }


    }
}