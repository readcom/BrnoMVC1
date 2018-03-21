using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrnoMVC1.Web.Controllers
{
    public class HelloWorldController : Controller
    {
       

        // GET: HelloWorld
        public ActionResult Index()
        {
            string text = "Hello World 2";
            
            return View(model: text);
        }
    }
}