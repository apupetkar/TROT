using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TROT.Controllers
{
    public class MessagesController : Controller
    {
        // GET: Messages
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Thanks()
        {
            return View();
        }

        //Q3PCUyBcVXsDsNJZLH9cn9GEwIVUXjUtytLsMEkqYA--.html
        [Route("~/AAA")]
        public ActionResult YahooVerification()
        {
            return View();
        }
    }
}