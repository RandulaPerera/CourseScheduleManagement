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
    public class LecturerViewController : Controller
    {
        CommonMethod _commonMethod = new CommonMethod();

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public ActionResult GetModuleList(int courseId)
        {
            List<Module> moduleList = _commonMethod.GetModulesByCourseId(courseId);
            return Json(moduleList);
        }

        public IActionResult Lectures(int courseId)
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

            return View();

        }

        public IActionResult Exams()
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

            return View();

        }


      
        [HttpGet]
        public ActionResult GetLecturesByModule(int moduleId)
        {
            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("Staff"));

            var lectures = _commonMethod.GetLecturesByModule(moduleId, user.StaffId);
            return Json(lectures);

        }

        [HttpGet]
        public ActionResult AllLectures()
        {
            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("Staff"));

            var lectures = _commonMethod.GetAllLectures(user.StaffId);
            return Json(lectures);

        }

        [HttpGet]
        public ActionResult GetExamsByModule(int moduleId)
        {
            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("Staff"));

            var exams = _commonMethod.GetExamsByModule(moduleId, user.StaffId);
            return Json(exams);

        }

        [HttpGet]
        public ActionResult GetAllExams()
        {
            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("Staff"));

            var exams = _commonMethod.GetAllExams(user.StaffId);
            return Json(exams);

        }
    }
}
