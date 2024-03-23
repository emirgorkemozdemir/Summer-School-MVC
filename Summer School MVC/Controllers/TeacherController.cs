using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yaz_Okulu_MVC_2.Models;

namespace Yaz_Okulu_MVC_2.Controllers
{
    public class TeacherController : Controller
    {
        YazOkuluVeritabanıEntities db = new YazOkuluVeritabanıEntities();

        public ActionResult ListTeachers()
        {
            var teacherList = db.ÖğretmenTablosu.ToList();
            return View(teacherList);
        }

        public ActionResult DeleteTeacher(int id)
        {
            var selectedTeacher = db.ÖğretmenTablosu.Find(id);
            db.ÖğretmenTablosu.Remove(selectedTeacher);
            db.SaveChanges();
            return RedirectToAction("ListTeachers");
        }

        [HttpGet]
        public ActionResult AddTeacher()
        {
            var lessonsList = db.DersTablosu.ToList();
            List<SelectListItem> lessons = (from i in lessonsList select new SelectListItem { Text = i.DersAd, Value = i.DersID.ToString()}).ToList();
            ViewBag.list = lessons;
            return View();
        }


        [HttpPost]
        public ActionResult AddTeacher(ÖğretmenTablosu teacher)
        {
            db.ÖğretmenTablosu.Add(teacher);
            db.SaveChanges();
            return RedirectToAction("ListTeachers");
        }

        [HttpGet]
        public ActionResult EditTeacher(int id)
        {
            var lessonsList = db.DersTablosu.ToList();
            List<SelectListItem> lessons = (from i in lessonsList select new SelectListItem { Text = i.DersAd, Value = i.DersID.ToString() }).ToList();
            ViewBag.list = lessons;

            var selectedTeacher = db.ÖğretmenTablosu.Find(id);
            return View(selectedTeacher);
        }

        [HttpPost]
        public ActionResult EditTeacher(ÖğretmenTablosu teacher)
        {
            var editingTeacher = db.ÖğretmenTablosu.Find(teacher.OgrtID);
            editingTeacher.OgrtAdSoyad = teacher.OgrtAdSoyad;
            editingTeacher.OgrtDersID = teacher.OgrtDersID;

            db.SaveChanges();

            return RedirectToAction("ListTeachers");
            
        }
    }
}