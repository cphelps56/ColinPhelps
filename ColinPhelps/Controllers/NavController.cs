﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColinPhelps.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        public PartialViewResult Header()
        {
            return PartialView();
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }

        public PartialViewResult SocialMedia()
        {
            return PartialView();
        }
    }
}