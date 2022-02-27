using CourseSheduleManagement.Method;
using CourseSheduleManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace CourseSheduleManagement.Controllers
{
    public class StudentViewController : Controller
    {
        CommonMethod _commonMethod = new CommonMethod();
        
        public IActionResult Index()
        {

            var user =JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("Student"));
            return View();

        }


        public IActionResult Lectures()
        {

            return View();

        }
        public IActionResult Exams()
        {

            return View();

        }


        [HttpGet]
        public ActionResult SearchLecturesByDate(DateTime date)
        {
            
                var lectures = _commonMethod.SearchLecturesByDate(date);
                return Json(lectures);

           
        
        }

        [HttpGet]
        public ActionResult SearchExamsByDate(DateTime date)
        {

            var exams = _commonMethod.SearchExamsByDate(date);
            return Json(exams);



        }

    }
}
