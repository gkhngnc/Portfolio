using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ankaraProje.Models;
namespace ankaraProje.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        dbAnkaraPortfolioEntities db = new dbAnkaraPortfolioEntities(); 
        public ActionResult Index()
        {
            ViewBag.v= db.TblTestimonial.Count();
            ViewBag.v2= db.TblSkill.Count();
            ViewBag.v3 = db.TblSkill.Where(x => x.Value >= 80).Count().ToString();
            ViewBag.v4= Math.Round(decimal.Parse(db.TblSkill.Average(x => x.Value).ToString()), 2); 
            return View();
        }
    }
}