﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColinPhelps.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ViewResult Index()
        {
            return View("ContactPageContent");
        }
    }
}