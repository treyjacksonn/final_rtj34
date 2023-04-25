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

        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details(int entertainerID)
        {
            var entry = EntContext.Entertainers
                .Single(x => x.EntertainerID == entertainerID);

            return View("Details",entry);
        }
        [HttpPost]
        public IActionResult Edit(int entertainerID)
        {
            var entry = EntContext.Entertainers
                .Single(x => x.EntertainerID == entertainerID);
            return View("Edit",entry);
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
