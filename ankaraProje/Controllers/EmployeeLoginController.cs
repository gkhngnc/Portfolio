using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ankaraProje.Models;
using System.Web.Security;

namespace ankaraProje.Controllers
{
    public class EmployeeLoginController : Controller
    {
        // GET: EmployeeLogin
        dbAnkaraPortfolioEntities db = new dbAnkaraPortfolioEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblEmployee p)
        {
            var values = db.TblEmployee.FirstOrDefault(x => x.EmployeeMail == p.EmployeeMail && x.EmpyloyeePassword == p.EmpyloyeePassword);
            if (values != null)
            {
                //giriş yapma işlemi
                FormsAuthentication.SetAuthCookie(values.EmployeeMail, false);
                Session["EmployeeMail"] = values.EmployeeMail;
                return RedirectToAction("ProfileGet", "Message");

            }
            else
            {
                return RedirectToAction("Index");
            }

        }
    }
}
