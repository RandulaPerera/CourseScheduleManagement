using CourseSheduleManagement.Method;
using CourseSheduleManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CourseSheduleManagement.Controllers
{
    public class StudentViewController : Controller
    {
        CommonMethod _commonMethod = new CommonMethod();
        
        public IActionResult Index()
        {

         
            return View();

        }


        public IActionResult Lectures()
        {
            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("Student"));

            List<Module> moduleList = _commonMethod.GetModulesByCourseId(user.CourseId);
            ViewBag.ModuleList=new SelectList(moduleList, "ModuleId", "ModuleName");

            return View();

        }
        public IActionResult Exams()
        {
            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("Student"));

            List<Module> moduleList = _commonMethod.GetModulesByCourseId(user.CourseId);
            ViewBag.ModuleList=new SelectList(moduleList, "ModuleId", "ModuleName");

            return View();

        }


        [HttpGet]
        public ActionResult SearchExamsByModule(int moduleId)
        {
            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("Student"));

            var exams = _commonMethod.SearchExamsByModule(moduleId, user.CourseId);
            return Json(exams);

        }

        [HttpGet]
        public ActionResult AllExams()
        {
            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("Student"));

            var exams = _commonMethod.AllExams(user.CourseId);
            return Json(exams);

        }

        [HttpGet]
        public ActionResult SearchLecturesByDate(DateTime date)
        {

            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("Student"));

            var lectures = _commonMethod.SearchLecturesByDate(date, user.CourseId);
            return Json(lectures);

        }


        [HttpGet]
        public ActionResult SearchLecturesByModule(int moduleId)
        {
            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("Student"));

            var lectures = _commonMethod.SearchLecturesByModule(moduleId, user.CourseId);
            return Json(lectures);

        }

        [HttpGet]
        public ActionResult AllLectures()
        {
            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("Student"));

            var lectures = _commonMethod.AllLectures(user.CourseId);
            return Json(lectures);

        }

    

    }
}
