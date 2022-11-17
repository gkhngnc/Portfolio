using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ankaraProje.Models;
namespace ankaraProje.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        dbAnkaraPortfolioEntities db = new dbAnkaraPortfolioEntities();        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblAdmin p) 
        { 
            var values = db.TblAdmin.FirstOrDefault(x=>x.UserName== p.UserName && x.Password == p.Password);
            if (values != null)
            {
                //giriş yapma işlemi
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["Username"] = values.UserName;
                return RedirectToAction("SkillList","Skill");

            }
            else
            {
                return RedirectToAction("Index");   
            }
           
        }
    }
}