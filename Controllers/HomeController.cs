using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using final_rtj34.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace final_rtj34.Controllers
{
    public class HomeController : Controller
    {

        private EntertainerContext EntContext { get; set; }
   

        public HomeController(EntertainerContext ent)
        {

            EntContext = ent;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var ent = EntContext.Entertainers
                .ToList();
            return View(ent);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Entertainer ent)
        {
            if (ModelState.IsValid)
            {
                EntContext.Add(ent);
                EntContext.SaveChanges();
                return Redirect("List");


            }
            else
            {
                return Redirect("Add");
            }

        }


        [HttpGet]
        public IActionResult Details(int entertainerID)
        {
            var entry = EntContext.Entertainers
                .Single(x => x.EntertainerID == entertainerID);

            return View("Details",entry);
        }
        [HttpGet]
        public IActionResult Edit(int entertainerID)
        {
            var entry = EntContext.Entertainers
                .Single(x => x.EntertainerID == entertainerID);
            return View("Edit",entry);
        }
        [HttpPost]
        public IActionResult Edit(Entertainer ent)
        {
            EntContext.Update(ent);
            EntContext.SaveChanges();
            return Redirect("List");
        }

        [HttpGet]
        public IActionResult Delete(int entertainerID)
        {
            var entry = EntContext.Entertainers
                  .Single(x => x.EntertainerID == entertainerID);
            return View("Delete", entry);

        }
        [HttpPost]
        public IActionResult Delete(Entertainer ent)
        {
            EntContext.Entertainers.Remove(ent);
            EntContext.SaveChanges();
            return Redirect("List");
        }


        //[HttpPost]
        //public IActionResult Edit(Entertainer ent)
        //{
        //    EntContext.Update(ent);
        //    EntContext.SaveChanges();
        //    return Redirect("List");
        //}


    }
}
