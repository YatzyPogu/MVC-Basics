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
        
        public IActionResult Index() 
        {
            return View(PeopleModel.peopleList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PeopleViewModel peopleViewModel)
        {
            if (ModelState.IsValid)
            {
                PeopleModel.peopleList.Add(
                    new PeopleModel()
                    {
                        Name = peopleViewModel.Name,
                        PhoneNumber = peopleViewModel.PhoneNumber,
                        City = peopleViewModel.City

                    });
                return RedirectToAction("Index");
                

            }
            return View(peopleViewModel);


        }
        public IActionResult Delete(int id)
        {
            foreach (PeopleModel person in PeopleModel.peopleList.ToList()) 
            {
                if (person.Id == id)
                {
                    PeopleModel.peopleList.Remove(person);
                }
            }

            return RedirectToAction("Index");
        }
        //public IActionResult Sort(int id)
        //{
           
        //}
        public IActionResult Filter(string search)
        {
            List<string> thechosenOnes = new List<string>();
            foreach (PeopleModel person in PeopleModel.peopleList) 
            {

                if (ModelState.IsValid) 
                {
                    if (person.Name.Contains(search))
                    {
                        thechosenOnes.Add(person.Name);
                    }
                }
                
                
            }
            return View(thechosenOnes);
        }

    }
}