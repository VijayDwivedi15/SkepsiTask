using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Web.Mvc;

namespace internshalaTask.Controllers
{
    public class HomeController : Controller
    {
        public static string resulttime = String.Empty;
         

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult GetTimeData(float Sunrise = 0, float Sunset = 0)
        {

            var latval = Sunrise;
            var longvar = Sunset;

            resulttime = "https://api.sunrise-sunset.org/json?lat="+ Sunrise+"&lng="+Sunset+"&callback=mycallback";


            var result = new { datares= resulttime };

            

            return Json(result, JsonRequestBehavior.AllowGet);
    }
}
}