using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TROT.Controllers
{
    public class DownloadController : Controller
    {
        // GET: Download
        
        public ActionResult Index(string url)
        {
            
            if (String.IsNullOrEmpty(url))
            {
                //Default Home url
                url = "https://onedrive.live.com/embed?cid=F28C3659F8F15706&resid=F28C3659F8F15706%21116&authkey=AARO0PKnHL3BDaA&em=2";
            }
            return View(model: url);
        }

        //[Route("Download/{url:string}")]
    }
}