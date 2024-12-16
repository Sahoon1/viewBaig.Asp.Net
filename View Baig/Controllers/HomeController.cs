using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View_Baig.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            ViewBag.Message = "Message From View Bag";
            ViewBag.Message = "Message From View Bag";
            ViewBag.CurrentDate = DateTime.Now.ToLongDateString();
            string[] fruits = { "Apple", "Mango", "Banana", "Orange" };
            ViewBag.FruitsArray = fruits;
            ViewBag.SportsList = new List<string>()
            {
                "Cricket",
                "Football",
                "Hockey",
            };

            

            return View();


        }
    }
}