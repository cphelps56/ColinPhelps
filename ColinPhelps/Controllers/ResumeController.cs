using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColinPhelps.Controllers
{
    public class ResumeController : Controller
    {
        // GET: Resume
        public FileResult Index()
        {
            return File("Views/Resume/resume.pdf", "application/pdf");
        }
    }
}