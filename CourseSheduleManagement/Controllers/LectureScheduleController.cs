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

        public IActionResult AddOrEdit(int id = 0)
        {
            List<Course> courseList = _commonMethod.GetCourses();
            ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

            List<Hall> hallList = _commonMethod.GetHalls();
            ViewBag.HallList=new SelectList(hallList, "HallId", "HallName");

            List<Module> moduleList = _commonMethod.GetModules();
            ViewBag.ModuleList=new SelectList(moduleList, "ModuleId", "ModuleName");

            List<Staff> staffList = _commonMethod.GetStaff();
            ViewBag.StaffList=new SelectList(staffList, "StaffId", "FullName");


            if (id == 0)
                return View(new Lecture());
            else
                return View(_lectureScheduleMethod.GetLectureById(id));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit([Bind("ScheduleId,Date,StartTime,EndTime,CourseId,HallId,BatchId,ModuleId,StaffId,LectureType")] Lecture lecture)
        {
            try
            {
                List<Course> courseList = _commonMethod.GetCourses();
                ViewBag.CourseList=new SelectList(courseList, "CourseId", "CourseName", "CourseCode");

                List<Hall> hallList = _commonMethod.GetHalls();
                ViewBag.HallList=new SelectList(hallList, "HallId", "HallName");

                List<Module> moduleList = _commonMethod.GetModules();
                ViewBag.ModuleList=new SelectList(moduleList, "ModuleId", "ModuleName");

                List<Staff> staffList = _commonMethod.GetStaff();
                ViewBag.StaffList=new SelectList(staffList, "StaffId", "FullName");

                if (ModelState.IsValid)
                {
                    if (lecture.ScheduleId == 0)
                    {
                        int scheduleId = _lectureScheduleMethod.AddSchedule(lecture.Date, lecture.StartTime, lecture.EndTime, lecture.CourseId, lecture.HallId, lecture.BatchId, lecture.ModuleId);


                        _lectureScheduleMethod.AddLecture(scheduleId, lecture.StaffId, lecture.LectureType);

                    }
                    else
                    {
                        _lectureScheduleMethod.EditSchedule(lecture.ScheduleId, lecture.Date, lecture.StartTime, lecture.EndTime, lecture.CourseId, lecture.HallId, lecture.BatchId, lecture.ModuleId);
                        _lectureScheduleMethod.EditLecture(lecture.ScheduleId,lecture.StaffId, lecture.LectureType);


                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(lecture);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }

        public IActionResult Delete(int id)
        {
            _lectureScheduleMethod.DeleteLecture(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult GetBatchList(int courseId)
        {
            List<Batch> batchList = _commonMethod.GetBatchByCourseId(courseId);
            return Json(batchList);
        }
    }
}
