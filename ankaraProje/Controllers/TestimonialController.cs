﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ankaraProje.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        public ActionResult AddTestimonial()
        {
            return View();
        }
        public ActionResult TestimonialList()
        {
            return View();
        }
    }
}