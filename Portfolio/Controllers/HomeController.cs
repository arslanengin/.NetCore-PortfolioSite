using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Data;
using Portfolio.DomainClasses;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        

        public IActionResult Index(int? page)
        {
            // WorkCategoryModel workCategoryModel = new WorkCategoryModel();
            List<Work> works = new List<Work>();
           
            using (MyContext db = new MyContext())
            {
               
                if (page == null)
                {
                    works = db.Works.Take(6).ToList();
                }
                else
                {
                    works = db.Works.Skip(6*page.Value).Take(6).ToList();
                }
                bool isAjaxCall = Request.Headers["x-requested-with"] == "XMLHttpRequest";
                if (isAjaxCall)
                {
                   return PartialView("PartialWorks", works);

                }
               
                    return View(works);
            }
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
            {
                return View();
            }

     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
