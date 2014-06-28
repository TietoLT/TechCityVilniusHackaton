using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseLibrary;
using System.Data.Entity;
namespace SportiskasVilnius.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            using (var ctx = new SContext())
            {
                ctx.Events.Add(new Event() {Date = DateTime.Now, Desc = "", Id = 1, IsActive = true, LocX = "1", LocY = "1", Owner = "ME"});
               // ctx.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
