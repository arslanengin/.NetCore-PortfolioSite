using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using Portfolio.DomainClasses;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class WorksController : Controller
    {
        public IActionResult Detail(int id)
        {
           
            WorkPhotos workPhotos = new WorkPhotos();
            using(MyContext db= new MyContext())
            {
                 workPhotos.Work = db.Works.Where(t => t.WorkID == id).FirstOrDefault();
                workPhotos.Photos = db.Photos.Where(t => t.WorkID == id).ToList();
            }
            return View(workPhotos);
        }

        public IActionResult Work()
        {
            List<Work> works = new List<Work>();

            using (MyContext db = new MyContext())
            {

               
                
                    works = db.Works.ToList();
                
               
                

                return View(works);
            }
        }




    }
}