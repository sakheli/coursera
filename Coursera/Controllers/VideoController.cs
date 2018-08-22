using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coursera.Controllers {
    public class VideoController : Controller {

        [AllowAnonymous]
        // GET: Video
        public ActionResult Index() {
            return View();
        }
    }
}