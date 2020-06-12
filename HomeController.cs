using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quadratic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Quadratic(double a, double b, double c)
        {
            var car = new { Manufacturer = "Lexus", Model = "is250", MaxSpeed = 280 };
            ViewBag.carinfo = car.MaxSpeed;


            double d = Math.Pow(b, 2) - 4 * a * c;
            double discrf = Math.Pow(d, 0.5);

            double xx1 = (-b - discrf) / (2 * a);
            double xx2 = (-b + discrf) / (2 * a);
            
            ViewBag.x1 = xx1;
            ViewBag.x2 = xx2;

            if (d < 0)
            {
                return View("Quadratic0");
            }

            else if (d == 0)
            {
                return View("Quadratic1");
            }

            else
            {
                return View("Quadratic2");
            }
            

            
        }
    }
}