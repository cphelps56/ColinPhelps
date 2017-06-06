using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColinPhelps.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public FileResult Index()
        {
            return File("Views/Error/Error.html","text/html");
        }
    }
}