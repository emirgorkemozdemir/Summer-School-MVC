using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yaz_Okulu_MVC_2.Models;

namespace Yaz_Okulu_MVC_2.Controllers
{
    public class LessonController : Controller
    {
        YazOkuluVeritabanıEntities db = new YazOkuluVeritabanıEntities();
        public ActionResult ListLessons()
        {
            var lessonList = db.DersTablosu.ToList();
            return View(lessonList);
        }

        public ActionResult DeleteLesson(int id)
        {
            var selectedLesson = db.DersTablosu.Find(id);
            db.DersTablosu.Remove(selectedLesson);
            db.SaveChanges();
            return RedirectToAction("ListLessons");
        }

        [HttpGet]
        public ActionResult AddLesson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddLesson(DersTablosu lesson)
        {
            db.DersTablosu.Add(lesson);
            db.SaveChanges();
            return RedirectToAction("ListLessons");
        }

        [HttpGet]
        public ActionResult EditLesson(int id)
        {
            var selectedLesson = db.DersTablosu.Find(id);
            return View(selectedLesson);
        }

        [HttpPost]
        public ActionResult EditLesson(DersTablosu lesson)
        {
            var editingLesson = db.DersTablosu.Find(lesson.DersID);
            editingLesson.DersAd = lesson.DersAd;
            editingLesson.MaxKont = lesson.MaxKont;
            editingLesson.MinKont = lesson.MinKont;
            editingLesson.OgrSayısı = lesson.OgrSayısı;
            db.SaveChanges();
            return RedirectToAction("ListLessons");
        }
    }
}