﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ankaraProje.Models;

namespace ankaraProje.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }

        dbAnkaraPortfolioEntities db = new dbAnkaraPortfolioEntities();


        public ActionResult SkillList()

        {
            var values = db.TblSkill.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(TblSkill p)
        {
            db.TblSkill.Add(p);
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public ActionResult DeleteSkill(int id)
        {
           var values= db.TblSkill.Find(id); 
            db.TblSkill.Remove(values); db.SaveChanges();


            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id) 
        { 
            var values= db.TblSkill.Find(id);
            return View(values);
        }

        [HttpPost] 
        public ActionResult UpdateSkill(TblSkill p)
        {
            var values = db.TblSkill.Find(p.SkillID);
            values.Title = p.Title;
            values.Value = p.Value; 
            db.SaveChanges ();
            return RedirectToAction("SkillList");
        }
    }
}