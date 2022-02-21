using CourseSheduleManagement.Method;
using CourseSheduleManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace CourseSheduleManagement.Controllers
{
    public class ExamScheduleController : Controller
    {
        ExamScheduleMethod _examScheduleMethod = new ExamScheduleMethod();
        CommonMethod _commonMethod = new CommonMethod();

        public IActionResult Index()
        {
            try
            {
                var data = _examScheduleMethod.GetExams();
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
                return View(_examScheduleMethod.GetExamById(id));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit([Bind("ScheduleId,Date,StartTime,EndTime,CourseId,HallId,BatchId,ModuleId,StaffId")] Exam exam)
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
                    if (exam.ScheduleId == 0)
                    {
                        int scheduleId = _examScheduleMethod.AddSchedule(exam.Date, exam.StartTime, exam.EndTime, exam.CourseId, exam.HallId, exam.BatchId, exam.ModuleId);


                        _examScheduleMethod.AddExam(scheduleId, exam.StaffId);

                    }
                    else
                    {
                        _examScheduleMethod.EditSchedule(exam.ScheduleId, exam.Date, exam.StartTime, exam.EndTime, exam.CourseId, exam.HallId, exam.BatchId, exam.ModuleId);
                        _examScheduleMethod.EditExam(exam.ScheduleId, exam.StaffId);


                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(exam);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }

        public IActionResult Delete(int id)
        {
            _examScheduleMethod.DeleteExam(id);
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
