using CourseSheduleManagement.Method;
using CourseSheduleManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace CourseSheduleManagement.Controllers
{
    public class LectureScheduleController : Controller
    {
        LectureScheduleMethod _lectureScheduleMethod = new LectureScheduleMethod();
        CommonMethod _commonMethod = new CommonMethod();

        public IActionResult Index()
        {
            try
            {
                var data = _lectureScheduleMethod.GetLectures();
                return View(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult AddOrEdit(int id)
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "Name");

            Lecture lecture = new Lecture();
            if (id > 0)
                lecture = _lectureScheduleMethod.GetLectureById(id);
            return View(lecture);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, [Bind("ScheduleId,Date,StartTime,EndTime,HallId,BatchId,ModuleId,LecturerBy,Type")] Lecture lecture)
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "Name");

            if (ModelState.IsValid)
            {
                _lectureScheduleMethod.AddOrEditLecture(lecture.ScheduleId, lecture.Date, lecture.StartTime, lecture.EndTime, lecture.HallId, lecture.BatchId, lecture.ModuleId, lecture.LecturerBy, lecture.Type);
                return RedirectToAction(nameof(Index));
            }
            return View(lecture);
        }

        public IActionResult Delete(int id)
        {
            _lectureScheduleMethod.DeleteLecture(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
