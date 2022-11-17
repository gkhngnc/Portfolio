using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ankaraProje.Models;

namespace ankaraProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            return PartialView();
        }

        public PartialViewResult Partial2()
        {
            return PartialView();
        }

        public PartialViewResult Partial3()
        {
            return PartialView();
        }

        dbAnkaraPortfolioEntities db = new dbAnkaraPortfolioEntities();
        public PartialViewResult Partial4()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        } 
        public PartialViewResult PartialTestimonial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
    }
}