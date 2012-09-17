using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.KML.Controllers
{
    public class KMLController : Controller
    {
        //
        // GET: /KML/

        public ActionResult Index()
        {
            var officePlaceMarks = new List<Models.KMPlaceMarkLViewModel>()
            {
                new Models.KMPlaceMarkLViewModel(){ Name ="Dallas", Description = "2811 McKinney Ave", Point="-96.8039,32.7828"},
                new Models.KMPlaceMarkLViewModel(){ Name ="Houston", Description = "4203 Montrose Blvd", Point="-95.3631,29.7631"}
            };
            return View(officePlaceMarks);
        }

    }
}
