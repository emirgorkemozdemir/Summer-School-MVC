using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yaz_Okulu_MVC_2.Models;

namespace Yaz_Okulu_MVC_2.Controllers
{
    public class StudentController : Controller
    {
        YazOkuluVeritabanıEntities db = new YazOkuluVeritabanıEntities();

        public ActionResult ListStudents()
        {
            var studentList = db.ÖğrenciTablosu.ToList();
            return View(studentList);
        }

        public ActionResult DeleteStudent(int id)
        {
            var selectedStudent = db.ÖğrenciTablosu.Find(id);
            db.ÖğrenciTablosu.Remove(selectedStudent);
            db.SaveChanges();
            return RedirectToAction("ListStudents");
        }


        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(ÖğrenciTablosu student)
        {
            db.ÖğrenciTablosu.Add(student);
            db.SaveChanges();
            return RedirectToAction("ListStudents");
        }

        [HttpGet]
        public ActionResult EditStudent(int id)
        {
            var selectedStudent = db.ÖğrenciTablosu.Find(id);
            return View(selectedStudent);
        }

        [HttpPost]
        public ActionResult EditStudent(ÖğrenciTablosu student)
        {
            var editingStudent = db.ÖğrenciTablosu.Find(student.OgrID);
            editingStudent.OgrAd = student.OgrAd;
            editingStudent.OgrSoyad = student.OgrSoyad;
            editingStudent.OgrMail = student.OgrMail;
            editingStudent.OgrSifre = student.OgrSifre;
            editingStudent.OgrOkulNo = student.OgrOkulNo;
            editingStudent.Bakiye = student.Bakiye;
            db.SaveChanges();
            return RedirectToAction("ListStudents");
        }

        [HttpGet]
        public ActionResult StudentApplyForLesson()
        {
            var lessonsList = db.DersTablosu.ToList();
            List<SelectListItem> lessons = (from i in lessonsList select new SelectListItem { Text = i.DersAd, Value = i.DersID.ToString() }).ToList();
            ViewBag.list = lessons;

            var teachersList = db.ÖğretmenTablosu.ToList();
            List<SelectListItem> teachers = (from i in teachersList select new SelectListItem { Text = i.OgrtAdSoyad, Value = i.OgrtID.ToString() }).ToList();
            ViewBag.list2 = teachers;

            return View();
        }

        public List<SelectListItem> getTeachersByID(int id)
        {
            var teachersList = db.ÖğretmenTablosu.Where(i => i.OgrtDersID == id).ToList();
            List<SelectListItem> teachers = (from i in teachersList select new SelectListItem { Text = i.OgrtAdSoyad, Value = i.OgrtID.ToString() }).ToList();
            return teachers;
        }

    }
}