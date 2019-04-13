using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //var message = new MessageModel();
            //message.Welcome = "Chào mừng đến với Welcome";
            //return View(message);
            return View();
        }

    }
}
